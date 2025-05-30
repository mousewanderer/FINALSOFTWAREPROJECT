﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;





namespace SOFTDEV_FINAL_PROJECT
{
    public partial class Quizbot : Form
    {

        private string studentName;
        private string studentID;
        public Quizbot(string name, string id)
        {


            studentName = name;
            studentID = id;
            InitializeComponent();
        }
        private void Quizbot_Load(object sender, EventArgs e)
        {

            string query = @"
        SELECT 
            S.StudentID,
            S.FirstName + ' ' + S.LastName AS FullName,
            Q.numquiz,
            Q.Leveling,
            CASE WHEN Q.Math1 = -1 THEN '-1' ELSE CAST(Q.Math1 AS VARCHAR) END AS Math1,
            CASE WHEN Q.Math2 = -1 THEN '-1' ELSE CAST(Q.Math2 AS VARCHAR) END AS Math2,
            CASE WHEN Q.InfoTech1 = -1 THEN '-1' ELSE CAST(Q.InfoTech1 AS VARCHAR) END AS InfoTech1,
            CASE WHEN Q.InfoTech2 = -1 THEN '-1' ELSE CAST(Q.InfoTech2 AS VARCHAR) END AS InfoTech2,
            CASE WHEN Q.Biology1 = -1 THEN '-1' ELSE CAST(Q.Biology1 AS VARCHAR) END AS Biology1,
            CASE WHEN Q.Physics1 = -1 THEN '-1' ELSE CAST(Q.Physics1 AS VARCHAR) END AS Physics1
        FROM Students S
        INNER JOIN Quizzes Q ON S.StudentID = Q.StudentID
        WHERE S.StudentID = @StudentID;
    ";

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string MATH1SCOREraw = reader["Math1"].ToString();
                                string MATH2SCOREraw = reader["Math2"].ToString();
                                string INFO1SCOREraw = reader["InfoTech1"].ToString();
                                string INFO2SCOREraw = reader["InfoTech2"].ToString();
                                string BIO1SCOREraw = reader["Biology1"].ToString();
                                string PHY1SCOREraw = reader["Physics1"].ToString();

                                MATH1SCORE.Text = MATH1SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {MATH1SCOREraw}/15";
                                MATH2SCORE.Text = MATH2SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {MATH2SCOREraw}/30";
                                INFO1SCORE.Text = INFO1SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {INFO1SCOREraw}/15";
                                INFO2SCORE.Text = INFO2SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {INFO2SCOREraw}/30";
                                BIO1SCORE.Text = BIO1SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {BIO1SCOREraw}/15";
                                PHY1SCORE.Text = PHY1SCOREraw == "-1" ? "NOT TAKEN" : $"Best: {PHY1SCOREraw}/15";




                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading scores: " + ex.Message);
            }
        }







        // LOAD ZONE

        String CURRENT_QUIZ = "";



        bool started = false;



        // QUIZ BOT CLICK0------------------------------------------------------

        private void Math1button_Click(object sender, EventArgs e)
        {


            if (!(started))
            {
                CURRENT_QUIZ = "Math1_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();
            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }

        }

        private void InfoTech1button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "InfoTech1_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();
            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Math2button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "Math2_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();
            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }

        }

        private void InfoTech2button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "InfoTech2_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();

            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Biology1button_Click(object sender, EventArgs e)
        {


            if (!(started))
            {
                CURRENT_QUIZ = "Biology1_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();

            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Physics1button_Click(object sender, EventArgs e)
        {


            if (!(started))
            {
                CURRENT_QUIZ = "Physics1_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ, studentName, studentID);

                question.Show();

            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void INFO2SCORE_Click(object sender, EventArgs e)
        {

        }
    }
}
