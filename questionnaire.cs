using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private string filelocate;

        public questionnaire(string locate)
        {
            InitializeComponent();
            filelocate = locate;
        }

        private void questionnaire_Load(object sender, EventArgs e)
        {

            questions = LoadQuestions(filelocate);
            Shuffle(questions);
            DisplayQuestion();
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
            QUESTION_Label.Text = $"Q{currentIndex + 1}: {q.Text}";

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
                if (selected == null)
                {
                    MessageBox.Show("Select an answer.");
                    return;
                }

                var q = questions[currentIndex];
                var correctChoice = q.Choices.Find(c => c.Label == q.CorrectAnswer).Choice;

                if (selected.Text == correctChoice)
                {
                    lblFeedback.Text = " OH whwat nnnan";
                    score++;
                }
                else
                {
                    lblFeedback.Text = $" OH whwat";
                }

                SCORELABEL.Text = $"Score: {score}/{questions.Count}";
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

                Quizbot quiz = new Quizbot();

                

                this.Hide();
                
            }
        }
        }
    }
