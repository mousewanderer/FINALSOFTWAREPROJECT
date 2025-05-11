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
    public partial class CREATE_form : Form
    {
        public CREATE_form()
        {
            InitializeComponent();
        }

      


        private void CREATE_form_Load(object sender, EventArgs e)
        {

        
        
            // Add categories to the gender
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("LGBTQIA");
            comboBoxGender.Items.Add("Rather not say");


            // Add categories to the Programs
            comboBoxProgram.Items.Add("Computer Engineer");
            comboBoxProgram.Items.Add("Mechanical Engineer");
            comboBoxProgram.Items.Add("Electrical Engineer");
            comboBoxProgram.Items.Add("Information Technology");
            comboBoxProgram.Items.Add("Food Technology");
            comboBoxProgram.Items.Add("Education");
            comboBoxProgram.Items.Add("Tourism Management");
            comboBoxProgram.Items.Add("Hotel Management");


            // No to civil hahahhaa  

            // if you want to addd crim ask him/her to code for it hahahha
        }




        private void Create_button_Click(object sender, EventArgs e)
        {

            bool allowed = true;

            // Retrieve input data
            string firstname = textBoxFirstName.Text.Trim();
            string lastname = textBoxLastname.Text.Trim();
            string ageInput = textBoxAge.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();
            string program = comboBoxProgram.SelectedItem?.ToString();
            string username = textbox_username.Text.Trim();
            string password = TextboxPassword.Text.Trim();

            // Validate Full Name
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("Please enter your full name.", "Input Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Please enter your full name.", "Input Error");
                return;
            }



            if (comboBoxProgram.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your program.", "Input Error");
                return;
            }

            /// must create a duplicate checker for this one

            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Please enter your username.", "Input Error");
                return;
            }




            // Validate Age (Numeric only)
            if (string.IsNullOrEmpty(ageInput))
            {
                MessageBox.Show("Please enter your age.", "Input Error");
                return;
            }

            if (!int.TryParse(ageInput, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.", "Input Error");
                return;
            }

            // Validate Gender selection
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Input Error");
                return;
            }



            // Age logic as requested - show age-related warning messages using MessageBox
            if (age >= 60)
            {
                if (age >= 150)
                {
                    MessageBox.Show($"{firstname}, INVALID", "Age Status");
                    allowed = false;
                    textBoxAge.Text = "";
                }
                else
                {
                    MessageBox.Show($"{firstname}, ARE YOU SURE???", "Age Status");
                    allowed = true;

                }
            }
            else if (age <= 0)
            {
                MessageBox.Show($"{firstname},", "Age Status");
                allowed = false;
                textBoxAge.Text = "";
            }
            else
            {

                if (age <= 18)
                {
                    MessageBox.Show($"{firstname},  ARE YOU SURE?? ", "Age Status");
                    allowed = true;
                }
                else
                {


                }
            }




            // saving mechanism

            if (allowed)
            {
                try
                {
                    string connectionString = "Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();



                        // Generating ID student
                        string getMaxIdQuery = "SELECT ISNULL(MAX(StudentID), 0) + 1 FROM Students";
                        int newStudentId;

                        using (SqlCommand getIdCmd = new SqlCommand(getMaxIdQuery, conn))
                        {
                            newStudentId = (int)getIdCmd.ExecuteScalar();
                        }



                        // INSERT into Students table (use manual StudentID)
                        string insertStudentQuery = @"INSERT INTO Students (StudentID, FirstName, LastName, Age, Gender, Program, Username, KeyPassword)
                              VALUES (@StudentID, @FirstName, @LastName, @Age, @Gender, @Program, @Username, @KeyPassword)";

                        using (SqlCommand cmd = new SqlCommand(insertStudentQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", newStudentId); // Add this line
                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@LastName", lastname);
                            cmd.Parameters.AddWithValue("@Age", int.Parse(ageInput));
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Program", program);
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@KeyPassword", password);

                            cmd.ExecuteNonQuery(); // Execute insert into Students


                                                   // Get the newly inserted user's ID


                            // Now insert into Quizzes table with default values
                            string insertScoreQuery = @"INSERT INTO Quizzes (StudentID, numquiz, Leveling, Math1, Math2, InfoTech1, InfoTech2, Biology1, Physics1)
                                                VALUES (@StudentID, -1, 1, -1, -1, -1, -1, -1, -1)";

                            using (SqlCommand quizCmd = new SqlCommand(insertScoreQuery, conn))
                            {
                                quizCmd.Parameters.AddWithValue("@StudentID", newStudentId);
                                quizCmd.ExecuteNonQuery();
                            }



                            MessageBox.Show("User and quiz record created successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }



        private void Return_button_Click(object sender, EventArgs e)
        {
            // Redirect to Login Form
            LOGINFORM loginForm = new LOGINFORM();
            loginForm.Show();
            this.Close(); // Close the Profile Form

        }

        private void TextboxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = TextboxPassword.Text;
            List<string> errors = new List<string>();

            if (password.Length < 8 || password.Length > 20)
            {
                errors.Add("• Password must be between 8 and 20 characters long.");
            }

            if (!password.Any(char.IsDigit))
            {
                errors.Add("• Password must contain at least one number.");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("• Password should include at least one uppercase letter.");
            }

            if (!password.Any(char.IsLower))
            {
                errors.Add("• Password should include at least one lowercase letter.");
            }



            if (errors.Count > 0)
            {
                labelPasswordError.Visible = true;
                labelPasswordError.Text = string.Join("\n", errors);
            }
            else
            {
                labelPasswordError.Visible = false;
            }

        }




        private void textbox_username_TextChanged(object sender, EventArgs e)
        {
            string username = textbox_username.Text;
            List<string> messages = new List<string>();

            if (username.Length < 5 || username.Length > 15)
            {
                messages.Add("• Username must be 5 to 15 characters long.");
            }

            if (!string.IsNullOrEmpty(username) && !char.IsLetter(username[0]))
            {
                messages.Add("• Username must start with a letter.");
            }

            if (!username.All(ch => char.IsLetterOrDigit(ch) || ch == '_'))
            {
                messages.Add("• Username can only contain letters, digits, and underscores.");
            }

            if (username.Contains(" "))
            {
                messages.Add("• Username should not contain spaces.");
            }

            if (messages.Count > 0)
            {
                usernamevalid.Visible = true;
                usernamevalid.Text = string.Join("\n", messages);
                usernamevalid.ForeColor = Color.Red;
            }
            else
            {
                usernamevalid.Visible = true;
                usernamevalid.Text = "✓ Username is valid";
                usernamevalid.ForeColor = Color.Green;
            }
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passworderror_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
