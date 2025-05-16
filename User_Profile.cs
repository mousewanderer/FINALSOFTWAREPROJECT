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
using System.Xml.Linq;
using SOFTDEV_FINAL_PROJECT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SOFTDEV_FINAL_PROJECT
{
    public partial class User_Profile : Form

    {

        private string studentFirstName;
        private string studentID;
        private string studentLastName;



        public User_Profile(string name, string id)
        {
            InitializeComponent();
        
            studentFirstName = name;
            studentID = id;
        }


        private void User_Profile_Load(object sender, EventArgs e)
        {
            NAME_LABEL.Text = $"Welcome, {studentFirstName} (ID: {studentID})";

            using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
            {
                conn.Open();

                // FIRST QUERY: Get quiz and level info
                string query1 = "SELECT numquiz, Leveling FROM Quizzes WHERE StudentID = @ID";

                using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                {
                    cmd1.Parameters.AddWithValue("@ID", studentID);

                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            num_quizzes.Text = $"You take :{reader1["numquiz"].ToString()} quizzes";
                            LEVEL_label.Text = $"Level: {reader1["Leveling"].ToString()}";
                            Firstname.Text = $"{studentFirstName}";
                        }
                    }
                }

                // SECOND QUERY: Get personal info
                string query2 = "SELECT LastName, Age, Gender, Program, Username FROM Students WHERE StudentID = @ID";

                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@ID", studentID);

                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            lastname.Text = $"{reader2["LastName"].ToString()}";
                            Agelabel.Text = $"{reader2["Age"].ToString()}";
                            Gender.Text = $"{reader2["Gender"].ToString()}";
                            CourseLabel.Text = $"{reader2["Program"].ToString()}";
                            Usernamelabel.Text = $"{reader2["Username"].ToString()}"; // corrected to Username
                        }
                    }
                }
            }


            //---------------------------------------------------------------





        }






        private void Userprofilepicture_Click(object sender, EventArgs e)
        {

        }

        private void Firstname_Click(object sender, EventArgs e)
        {

        }


    }
}
