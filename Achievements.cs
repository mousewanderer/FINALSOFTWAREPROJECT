using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

                                

                                // ACHIEVEMENTS CHECKER

                                int passingScore = 8;


                                // Check if any score meets the passing condition
                                bool passedAnyQuiz = MATH1SCOREraw >= passingScore ||
                                                      INFO1SCOREraw >= passingScore ||
                                                      BIO1SCOREraw >= passingScore ||
                                                      PHY1SCOREraw >= passingScore;
                                if (passedAnyQuiz)
                                {
                                    I_PASSED_one();
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










        private void  I_PASSED_one()
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


    }
}
