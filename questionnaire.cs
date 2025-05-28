using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using Timer = System.Windows.Forms.Timer; // Add this with other using directives

namespace SOFTDEV_FINAL_PROJECT
{
    public partial class questionnaire : Form
    {
        private string CURRENT_QUIZ;
        private string studentName;
        private string studentID;
        private string quizColumn = "";
        private bool isTimeUp = false;

        public questionnaire(string locate, string name, string id)
        {
            studentName = name;
            studentID = id;
            InitializeComponent();
            CURRENT_QUIZ = locate;
        }

    
                    
        int countdownTime = 60; // 60 seconds per question
        int questionTimeLimit = 60; // Can be adjusted per question if needed



        private void questionnaire_Load(object sender, EventArgs e)
        {

            questions = LoadQuestions(CURRENT_QUIZ);
            Shuffle(questions);
            DisplayQuestion();
            ResetTimer();
            timer1.Start();
        }


        class Question
        {
            public string Text;
            public List<(string Label, string Choice)> Choices;
            public string CorrectAnswer;
        }

        List<Question> questions;
        int currentQuestionIndex = 0;
        int score = 0;

        void DisplayQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                CompleteQuiz();
                return;
            }

            var q = questions[currentQuestionIndex];
            QUESTION_Label.Text = $"{currentQuestionIndex + 1}: {q.Text}";

            var randomized = new List<(string Label, string Choice)>(q.Choices);
            Shuffle(randomized);

            rbA.Text = randomized[0].Choice;
            rbA.Tag = randomized[0].Label;

            rbB.Text = randomized[1].Choice;
            rbB.Tag = randomized[1].Label;

            rbC.Text = randomized[2].Choice;
            rbC.Tag = randomized[2].Label;

            rbD.Text = randomized[3].Choice;
            rbD.Tag = randomized[3].Label;

            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;

            lblFeedback.Text = $"Time: {countdownTime}s";
       

            // Reset timer for new question
            ResetTimer();
        }

        void ResetTimer()
        {
            countdownTime = questionTimeLimit;
            timer1.Stop();
            timer1.Start();
            isTimeUp = false;
          
        }

        void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                (list[n], list[k]) = (list[k], list[n]);
            }
        }

        List<Question> LoadQuestions(string path)
        {
            var questions = new List<Question>();
            using (var workbook = new XLWorkbook(path))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1))
                {
                    questions.Add(new Question
                    {
                        Text = row.Cell(1).GetString(),
                        Choices = new List<(string, string)>
                        {
                            ("A", row.Cell(2).GetString()),
                            ("B", row.Cell(3).GetString()),
                            ("C", row.Cell(4).GetString()),
                            ("D", row.Cell(5).GetString())
                        },
                        CorrectAnswer = row.Cell(6).GetString().ToUpper()
                    });
                }
            }
            return questions;
        }

        private void NEXTbutton_Click(object sender, EventArgs e)
        {
            ProcessQuestion();
        }

        private void ProcessQuestion()
        {
            if (currentQuestionIndex >= questions.Count) return;

            var selected = new[] { rbA, rbB, rbC, rbD }.FirstOrDefault(rb => rb.Checked);

            // Only check answer if time hasn't run out and an answer was selected
            if (!isTimeUp && selected != null)
            {
                var q = questions[currentQuestionIndex];
                var correctChoice = q.Choices.Find(c => c.Label == q.CorrectAnswer).Choice;

                if (selected.Text == correctChoice)
                {
                    score++;
                }
            }

            SCORELABEL.Text = $"{score}/{questions.Count}";
            currentQuestionIndex++;

            if (currentQuestionIndex == questions.Count)
            {
                NEXTbutton.Text = "Complete";
            }

            DisplayQuestion();
        }

        private void CompleteQuiz()
        {
            timer1.Stop();
            MessageBox.Show($"🎉 Quiz completed!\nYour score: {score}/{questions.Count}", "Finished");

            // Determine quiz column for database
            quizColumn = CURRENT_QUIZ switch
            {
                "Math1_Quiz.xlsx" => "Math1",
                "Math2_Quiz.xlsx" => "Math2",
                "InfoTech1_Quiz.xlsx" => "InfoTech1",
                "InfoTech2_Quiz.xlsx" => "InfoTech2",
                "Biology1_Quiz.xlsx" => "Biology1",
                "Physics1_Quiz.xlsx" => "Physics1",
                _ => null
            };

            if (quizColumn != null)
            {
                SaveQuizScoreToDatabase(quizColumn, score);
            }
            else
            {
                MessageBox.Show("Unknown quiz type. Cannot save.");
            }

            Quizbot quiz = new Quizbot(studentName, studentID);
            this.Hide();
        }

        private void SaveQuizScoreToDatabase(string quizColumn, int score)
        {
            string connectionString = "Server=localhost;Database=Final_projectDB;Trusted_Connection=True;";
            int? previousScore = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Get the current score
                    string getScoreQuery = $"SELECT {quizColumn} FROM Quizzes WHERE StudentID = @StudentID";
                    using (SqlCommand getCmd = new SqlCommand(getScoreQuery, conn))
                    {
                        getCmd.Parameters.AddWithValue("@StudentID", studentID);
                        object result = getCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            previousScore = Convert.ToInt32(result);
                        }
                    }

                    // Step 2: Compare and update only if the new score is higher
                    if (previousScore == null || score > previousScore)
                    {
                        string updateQuery;

                        if (score >= 8)
                        {
                            updateQuery = $@"
                  UPDATE Quizzes 
                  SET {quizColumn} = @Score, 
                      numquiz = numquiz + 1,
                      Leveling = Leveling + 1
                  WHERE StudentID = @StudentID";
                        }
                        else
                        {
                            updateQuery = $@"
                  UPDATE Quizzes 
                  SET {quizColumn} = @Score, 
                      numquiz = numquiz + 1
                  WHERE StudentID = @StudentID";
                        }

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Score", score);
                            updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                            int rows = updateCmd.ExecuteNonQuery();
                            if (rows == 0)
                            {
                                MessageBox.Show("Failed to update score. Student ID may not exist.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Previous score is higher. No update made.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving score: " + ex.Message);
            }
        }
        static DateTime lastTick = DateTime.MinValue;


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Use high precision timing
            var now = DateTime.Now;

            lblFeedback.ForeColor = Color.FromArgb(40, 122, 116);


            // Ensure at least 1 second has passed
            if ((now - lastTick).TotalSeconds >= 1)
            {
                countdownTime--;
                lastTick = now;

                lblFeedback.Text = $"Time: {countdownTime}s";

                if (countdownTime <= 0)
                {
                    timer1.Stop();
                    isTimeUp = true;
                    lblFeedback.Text = "Time's up!";

                    // Use async delay instead of nested timer
                    Task.Delay(1500).ContinueWith(t =>
                    {
                        this.Invoke((MethodInvoker)delegate {
                            ProcessQuestion();
                        });
                    });
                }
                else if (countdownTime <= 10)
                {
                    lblFeedback.ForeColor = Color.Red;
                }
                else
                {
                    lblFeedback.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}