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
    public partial class DASHBOARD_form : Form
    {
        private string studentName;
        private string studentID;


        public DASHBOARD_form(string name, string id)
        {


            InitializeComponent();
            studentName = name;
            studentID = id;






        }

        private void DASHBOARD_form_Load_1(object sender, EventArgs e)
        {
            NAME_LABEL.Text = $"Welcome, {studentName} (ID: {studentID})";


            using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
            {
                
                    conn.Open();

                    string query = "SELECT numquiz, Leveling FROM Quizzes WHERE StudentID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", studentID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                            num_quizzes.Text = $"Your quizzes are {reader["numquiz"].ToString()}   ";
                            LEVEL_label.Text = $"Your level is {reader["Leveling"].ToString()}   ";
                            }

                        }

                        }
                

            }
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
