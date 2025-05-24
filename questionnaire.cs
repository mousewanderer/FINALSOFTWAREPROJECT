using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;

namespace SOFTDEV_FINAL_PROJECT
{
    public partial class questionnaire : Form
    {

        private string CURRENT_QUIZ;

        private string studentName;
        private string studentID;
        private string quizColumn = "";

        bool bypassAnswerCheck = false;

        public questionnaire(string locate, string name, string id)
        {

            studentName = name;
            studentID = id;
            InitializeComponent();
            CURRENT_QUIZ = locate;
        }


        int countdownTime = 60; // 60 second

      


        private void questionnaire_Load(object sender, EventArgs e)
        {

            questions = LoadQuestions(CURRENT_QUIZ);
            Shuffle(questions);
            DisplayQuestion();
            countdownTime = 60; // Start from 60 seconds loading problems
            lblFeedback.Text = $"TIME: {countdownTime.ToString()} ";
            timer1.Interval = 1000; // 1 second
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
        int currentIndex = 0;






        void DisplayQuestion()
        {
            if (currentIndex >= questions.Count)
            {
                MessageBox.Show($"🎉 Quiz completed!\nYour score: {score}/{questions.Count}");
                return;
            }

            var q = questions[currentIndex];
            QUESTION_Label.Text = $"{currentIndex + 1}: {q.Text}";

            var randomized = new List<(string Label, string Choice)>(q.Choices);
            Shuffle(randomized);

            // Set text and tags
            rbA.Text = randomized[0].Choice;
            rbA.Tag = randomized[0].Label;

            rbB.Text = randomized[1].Choice;
            rbB.Tag = randomized[1].Label;

            rbC.Text = randomized[2].Choice;
            rbC.Tag = randomized[2].Label;

            rbD.Text = randomized[3].Choice;
            rbD.Tag = randomized[3].Label;

            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
            lblFeedback.Text = "";
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
            if (currentIndex < questions.Count)
            {
                var selected = new[] { rbA, rbB, rbC, rbD }.FirstOrDefault(rb => rb.Checked);

                if (selected == null && !bypassAnswerCheck)
                {
                    MessageBox.Show("Select an answer.");
                    return;
                }
                countdownTime = 61; //seconds loading problems

                var q = questions[currentIndex];
                var correctChoice = q.Choices.Find(c => c.Label == q.CorrectAnswer).Choice;

                if (selected.Text == correctChoice)
                {

                    score++;
                }
                else
                {

                }

                SCORELABEL.Text = $"{score}/{questions.Count}";
                currentIndex++;

                if (currentIndex == questions.Count)
                {
                    NEXTbutton.Text = "Complete";
                }
                else
                {
                    DisplayQuestion(); // Only load next question if not last
                }
            }
            else
            {
                MessageBox.Show($"🎉 Quiz completed!\nYour score: {score}/{questions.Count}", "Finished");

                new Quizbot(studentName, studentID);


                if (CURRENT_QUIZ == "Math1_Quiz.xlsx") quizColumn = "Math1";
                else if (CURRENT_QUIZ == "Math2_Quiz.xlsx") quizColumn = "Math2";
                else if (CURRENT_QUIZ == "InfoTech1_Quiz.xlsx") quizColumn = "InfoTech1";
                else if (CURRENT_QUIZ == "InfoTech2_Quiz.xlsx") quizColumn = "InfoTech2";
                else if (CURRENT_QUIZ == "Biology1_Quiz.xlsx") quizColumn = "Biology1";
                else if (CURRENT_QUIZ == "Physics1_Quiz.xlsx") quizColumn = "Physics1";

                else
                {
                    MessageBox.Show("Unknown quiz type. Cannot save.");
                    return;
                }

                SaveQuizScoreToDatabase(quizColumn, score);



                Quizbot quiz = new Quizbot(studentName, studentID);



                this.Hide();

            }
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

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }



        // TIME FOR THE LABEL MODIFY
        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            lblFeedback.Text = countdownTime.ToString() + "s";

            if (countdownTime <= 0)
            {
                timer1.Stop();
                bypassAnswerCheck = true; // tell the button to skip validation
                lblFeedback.Text = "Time's up!";
                // NEXT QUESTION

                NEXTbutton.PerformClick();

                bypassAnswerCheck = false;

            }


        }

        private void SCORELABEL_Click(object sender, EventArgs e)
        {

        }
    }
}
