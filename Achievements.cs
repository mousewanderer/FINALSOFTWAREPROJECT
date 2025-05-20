using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTDEV_FINAL_PROJECT
{
    public partial class Achievements : Form
    {


        private string studentName;
        private string studentID;
        public Achievements(string name, string id)
        {
            studentName = name;
            studentID = id;
            InitializeComponent();
        }


        

       

        private void Achievements_Load(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            S.StudentID,
            S.FirstName + ' ' + S.LastName AS FullName,
            Q.numquiz,
            Q.Leveling,
            CASE WHEN Q.Math1 = -1 THEN -1 ELSE CAST(Q.Math1 AS VARCHAR) END AS Math1,
            CASE WHEN Q.Math2 = -1 THEN -1 ELSE CAST(Q.Math2 AS VARCHAR) END AS Math2,
            CASE WHEN Q.InfoTech1 = -1 THEN -1 ELSE CAST(Q.InfoTech1 AS VARCHAR) END AS InfoTech1,
            CASE WHEN Q.InfoTech2 = -1 THEN -1 ELSE CAST(Q.InfoTech2 AS VARCHAR) END AS InfoTech2,
            CASE WHEN Q.Biology1 = -1 THEN -1 ELSE CAST(Q.Biology1 AS VARCHAR) END AS Biology1,
            CASE WHEN Q.Physics1 = -1 THEN -1 ELSE CAST(Q.Physics1 AS VARCHAR) END AS Physics1
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
                                int MATH1SCOREraw = Convert.ToInt32(reader["Math1"]);
                                int MATH2SCOREraw = Convert.ToInt32(reader["Math2"]);
                                int INFO1SCOREraw = Convert.ToInt32(reader["InfoTech1"]);
                                int INFO2SCOREraw = Convert.ToInt32(reader["InfoTech2"]);
                                int BIO1SCOREraw = Convert.ToInt32(reader["Biology1"]);
                                int PHY1SCOREraw = Convert.ToInt32(reader["Physics1"]);

                                

                                // ACHIEVEMENTS CHECKER for passed quiz

                                int passingScore = 8;
                                int passingScoreSecondary = 15;

                                int maxscore = 15;
                                int maxScoreSecondary = 30;


                                // Check if any score meets the passing condition
                                bool passedAnyQuiz = MATH1SCOREraw >= passingScore ||
                                                      INFO1SCOREraw >= passingScore ||
                                                      BIO1SCOREraw >= passingScore ||
                                                      PHY1SCOREraw >= passingScore;
                                bool passedSECONDARY = MATH2SCOREraw >= passingScoreSecondary || INFO2SCOREraw >= passingScoreSecondary;

                                // must all passed quizzes
                                bool passedALL = MATH1SCOREraw >= passingScore &&
                                                      INFO1SCOREraw >= passingScore &&
                                                      BIO1SCOREraw >= passingScore &&
                                                       MATH2SCOREraw >= passingScoreSecondary &&
                                                       INFO2SCOREraw >= passingScoreSecondary &&
                                                       PHY1SCOREraw >= passingScore;
                                // ATLEAST 1 perfect quiz
                                bool PERFECTED = MATH1SCOREraw >= maxscore ||
                                                      INFO1SCOREraw >= maxscore ||
                                                      BIO1SCOREraw >= maxscore ||
                                                      PHY1SCOREraw >= maxscore ||
                                                      MATH2SCOREraw >= maxScoreSecondary ||
                                                       INFO2SCOREraw >= maxScoreSecondary;

                                // PERFECTED both INFO1 and 2
                                bool coding = INFO1SCOREraw >= maxscore && INFO2SCOREraw >= maxScoreSecondary;


                                // PERFECTED in biology
                                bool nature = BIO1SCOREraw >= maxscore ;

                                // PASSED 1 quizzes
                                if (passedAnyQuiz)
                                {
                                    I_PASSED_one();
                                }

                                // PASSED both 1 and 2
                                if (passedSECONDARY && passedAnyQuiz)
                                {
                                    //
                                    PASSED_both_1_and_2();

                                }

                                // PASSED ALL
                                if (passedALL)
                                {
                                    //
                                    PASSEDALL();
                                }

                                // PASSED ALL
                                if (PERFECTED)
                                {
                                    //

                                    PERFECT();
                                }

                                if (coding)
                                {
                                    CODINGEXPERT();
                                }

                                if (nature)
                                {
                                    NATURELOVER();
                                }





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





        private void PERFECT()
        {

            PERFECT_1_quiz.BackgroundImage = null;
            // Set the background image

            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "PERFECT1.png");
            PERFECT_1_quiz.BackgroundImage = Image.FromFile(imagePath);

            PERFECT_1_quiz.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            PERFECT_1_quiz.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            PERFECT_1_quiz.BackColor = Color.Yellow; // Change the background color to green (you can choose any color you prefer)
        }




        private void PASSED_both_1_and_2()
        {

            PASSED_2_QUIZZES.BackgroundImage = null;
            // Set the background image

            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "PASSED2.png");
            PASSED_2_QUIZZES.BackgroundImage = Image.FromFile(imagePath);

            PASSED_2_QUIZZES.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            PASSED_2_QUIZZES.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            PASSED_2_QUIZZES.BackColor = Color.YellowGreen; // Change the background color to green (you can choose any color you prefer)
        }

        private void PASSEDALL()
        {

            PASSED_ALL.BackgroundImage = null;
            // Set the background image

            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "PASSEDALL.png");
            PASSED_ALL.BackgroundImage = Image.FromFile(imagePath);

            PASSED_ALL.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            PASSED_ALL.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            PASSED_ALL.BackColor = Color.Red; // Change the background color to green (you can choose any color you prefer)
        }



        private void I_PASSED_one()
        {
            // Change the image of PASSED_1_quiz PictureBox

            // Remove the background image (if the lock is set as the background image)
            PASSED_1_quiz.BackgroundImage = null;
            // Set the background image
            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "PASSED1.png");
            PASSED_1_quiz.BackgroundImage = Image.FromFile(imagePath);

            PASSED_1_quiz.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            PASSED_1_quiz.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            PASSED_1_quiz.BackColor = Color.Green; // Change the background color to green (you can choose any color you prefer)
        }

        private void NATURELOVER()
        {

            BIOLOGY.BackgroundImage = null;
            // Set the background image

            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "BIOLOGY.png");
            BIOLOGY.BackgroundImage = Image.FromFile(imagePath);

            BIOLOGY.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            BIOLOGY.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            BIOLOGY.BackColor = Color.LightGreen; // Change the background color to green (you can choose any color you prefer)
        }


        private void CODINGEXPERT()
        {

            CODING_EXPERT.BackgroundImage = null;
            // Set the background image

            string imagePath = Path.Combine(Application.StartupPath, "ACHIEVEMENTS", "CODINGPRO.png");
            CODING_EXPERT.BackgroundImage = Image.FromFile(imagePath);

            CODING_EXPERT.BackgroundImageLayout = ImageLayout.Zoom; // Ensures the image is zoomed to fit the PictureBox

            // Optionally, change the border color (if you want to make it more visually prominent)
            CODING_EXPERT.BorderStyle = BorderStyle.FixedSingle; // Makes a border visible
            CODING_EXPERT.BackColor = Color.SkyBlue; // Change the background color to green (you can choose any color you prefer)
        }


    }
}
