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
using DocumentFormat.OpenXml.Wordprocessing;

namespace SOFTDEV_FINAL_PROJECT
{
    public partial class update : Form
    {



        private string studentID;

        public update(string id)
        {
            InitializeComponent();
            studentID = id;
            // GENDER ComboBox

            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("LGBTQIA");
            comboBoxGender.Items.Add("Rather not say");

            // PROGRAM ComboBox

            comboBoxProgram.Items.Add("Computer Engineer");
            comboBoxProgram.Items.Add("Mechanical Engineer");
            comboBoxProgram.Items.Add("Electrical Engineer");
            comboBoxProgram.Items.Add("Civil Engineer");
            comboBoxProgram.Items.Add("Combat Engineer");
            comboBoxProgram.Items.Add("Information Technology (major in programming)");
            comboBoxProgram.Items.Add("Information Technology (major in Networking)");
            comboBoxProgram.Items.Add("Food Technology");
            comboBoxProgram.Items.Add("Education");
            comboBoxProgram.Items.Add("Tourism Management");
            comboBoxProgram.Items.Add("Hotel Management");
            comboBoxProgram.Items.Add("Political Science");
            comboBoxProgram.Items.Add("Computer Science");
        }

        private void update_Load(object sender, EventArgs e)
        {




            // LOAD USER NAME AND ALL INFO
            using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
            {
                conn.Open();


                string query2 = "SELECT FirstName, LastName, Age, Gender, Program, Username, KeyPassword FROM Students WHERE StudentID = @ID";

                using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@ID", studentID);

                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {


                            textBoxFirstName.Text = $"{reader2["FirstName"].ToString()}";
                            textBoxLastname.Text = $"{reader2["LastName"].ToString()}";
                            textBoxAge.Text = $"{reader2["Age"].ToString()}";
                            comboBoxGender.Text = $"{reader2["Gender"].ToString()}";
                            comboBoxProgram.Text = $"{reader2["Program"].ToString()}";
                            textbox_username.Text = $"{reader2["Username"].ToString()}";



                            TextboxPassword.Text = $"{reader2["KeyPassword"].ToString()}";



                            // I AM DUMB useless store

                            string previous_age = $"{reader2["Age"].ToString()}";
                            string previous_gender = $"{reader2["Gender"].ToString()}";
                            string previous_Program = $"{reader2["Program"].ToString()}";


                            string previous_password = $"{reader2["KeyPassword"].ToString()}";


                            // corrected to Username
                        }
                    }
                }



            }

        }








        private void Create_button_Click_1(object sender, EventArgs e)
        {
            // comparison
            string previous_Firstname = textBoxFirstName.Text;
            string previous_lastname = textBoxLastname.Text;
            string previous_username = textbox_username.Text;

            bool allowed = true;

            // Retrieve input data
            string firstname = textBoxFirstName.Text.Trim();
            string lastname = textBoxLastname.Text.Trim();
            string ageInput = textBoxAge.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();
            string program = comboBoxProgram.SelectedItem?.ToString();
            string username = textbox_username.Text.Trim();
            string password = TextboxPassword.Text.Trim();

            string currentstudentId = studentID;

            // Validate inputs
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

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password", "Input Error");
                return;
            }

            // Validate Age
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

            // Validate Gender
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Input Error");
                return;
            }

            // Age validation logic
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
            else if (age <= 17)
            {
                DialogResult result = MessageBox.Show($"{firstname}, ARE YOU SURE??", "Age Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                allowed = (result == DialogResult.Yes);
                if (!allowed) return;
            }

            // Check for duplicates
            using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
            {
                conn.Open();

                // 1. Check if username already exists
                string usernameQuery = "SELECT COUNT(*) FROM Students WHERE Username = @Username AND StudentID != @StudentID;";
                using (SqlCommand checkUsername = new SqlCommand(usernameQuery, conn))
                {
                    checkUsername.Parameters.AddWithValue("@Username", username);
                    checkUsername.Parameters.AddWithValue("@StudentID", currentstudentId);

                    int usernameExists = (int)checkUsername.ExecuteScalar();

                    if (usernameExists > 0)
                    {
                        MessageBox.Show("Username is already taken.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 2. Check if full name (first + last) already exists
                string nameQuery = "SELECT COUNT(*) FROM Students WHERE FirstName = @FirstName AND LastName = @LastName AND StudentID != @StudentID;";
                using (SqlCommand checkName = new SqlCommand(nameQuery, conn))
                {
                    checkName.Parameters.AddWithValue("@FirstName", firstname);
                    checkName.Parameters.AddWithValue("@LastName", lastname);
                    checkName.Parameters.AddWithValue("@StudentID", currentstudentId);

                    int nameExists = (int)checkName.ExecuteScalar();
                    if (nameExists > 0)
                    {
                        MessageBox.Show("A student with the same full name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            // Save changes
            if (allowed)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True"))
                    {
                        conn.Open();

                        // UPDATE COMMAND
                        string updateStudentQuery = @"UPDATE Students
                    SET FirstName = @FirstName, 
                        LastName = @LastName, 
                        Age = @Age, 
                        Gender = @Gender, 
                        Program = @Program, 
                        Username = @Username, 
                        KeyPassword = @KeyPassword
                    WHERE StudentID = @StudentID";

                        using (SqlCommand cmd = new SqlCommand(updateStudentQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", currentstudentId);
                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@LastName", lastname);
                            cmd.Parameters.AddWithValue("@Age", age);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@Program", program);
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@KeyPassword", password);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User details updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Update failed! Student ID not found.");
                            }
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

            }
            else
            {
                usernamevalid.Visible = true;
                usernamevalid.Text = "✓ Username is valid";

            }
        }







        private void passworderror_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                textBoxAge.Text = "";
                return;
            }

            if (age > 100)
            {

                textBoxAge.Text = "";
                return;
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {

            string[] allowedCourses = new string[]
   {
        "Computer Engineer", "Mechanical Engineer", "Electrical Engineer",
        "Civil Engineer", "Combat Engineer",
        "Information Technology (major in programming)",
        "Information Technology (major in Networking)",
        "Food Technology", "Education", "Tourism Management",
        "Hotel Management", "Political Science", "Computer Science"
   };

            // Check if user input matches any course
            if (!allowedCourses.Contains(comboBoxProgram.Text))
            {
                comboBoxProgram.Text = "";
            }



        }

        private void comboBoxProgram_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProgram_TextChanged(object sender, EventArgs e)
        {
            string[] allowedCourses = new string[]
   {
        "Computer Engineer", "Mechanical Engineer", "Electrical Engineer",
        "Civil Engineer", "Combat Engineer",
        "Information Technology (major in programming)",
        "Information Technology (major in Networking)",
        "Food Technology", "Education", "Tourism Management",
        "Hotel Management", "Political Science", "Computer Science"
   };

            // Check if user input matches any course
            if (!allowedCourses.Contains(comboBoxProgram.Text))
            {
                comboBoxProgram.Text = "";
            }
        }

        private void comboBoxGender_TextChanged(object sender, EventArgs e)
        {
            string[] allowedGenders = new string[]
    {
        "Male", "Female", "LGBTQIA", "Rather not say"
    };

            if (!allowedGenders.Contains(comboBoxGender.Text))
            {
                comboBoxGender.Text = "";
            }

        }

        private void Create_button_Click(object sender, EventArgs e)
        {


        }



        private void DELETEBUTTON_Click(object sender, EventArgs e)
        {
            // 1. Verify password first
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Please enter your password to confirm account deletion:",
                "Confirm Account Deletion",
                "");

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Deletion cancelled.");
                return;
            }

            // 2. Verify password matches
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
                {
                    conn.Open();

                    // Check password first
                    string verifyQuery = "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID AND KeyPassword = @Password";

                    using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn))
                    {
                        verifyCmd.Parameters.AddWithValue("@StudentID", studentID);
                        verifyCmd.Parameters.AddWithValue("@Password", password);

                        int match = (int)verifyCmd.ExecuteScalar();

                        if (match == 0)
                        {
                            MessageBox.Show("Incorrect password. Account deletion aborted.",
                                          "Security Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 3. Show final confirmation
                    DialogResult confirm = MessageBox.Show(
                        "WARNING: This will permanently delete your account and all quiz data.\n\n" +
                        "This action cannot be undone!\n\n" +
                        "Are you absolutely sure?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2);

                    if (confirm != DialogResult.Yes)
                    {
                        MessageBox.Show("Account deletion cancelled.");
                        return;
                    }

                    // 4. Perform deletion in transaction
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Delete quizzes first
                            string deleteQuizzes = "DELETE FROM Quizzes WHERE StudentID = @StudentID";
                            using (SqlCommand quizCmd = new SqlCommand(deleteQuizzes, conn, transaction))
                            {
                                quizCmd.Parameters.AddWithValue("@StudentID", studentID);
                                quizCmd.ExecuteNonQuery();
                            }

                            // Then delete student
                            string deleteStudent = "DELETE FROM Students WHERE StudentID = @StudentID";
                            using (SqlCommand studentCmd = new SqlCommand(deleteStudent, conn, transaction))
                            {
                                studentCmd.Parameters.AddWithValue("@StudentID", studentID);
                                studentCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            // 5. Log out and close
                            MessageBox.Show("Account deleted successfully. The application will now close.",
                                          "Account Deleted",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);

                            // Clear session and close
                            studentID = null;

                            DASHBOARD_form dashboard = Application.OpenForms.OfType<DASHBOARD_form>().FirstOrDefault();
                            if (dashboard != null)
                            {
                                dashboard.Close();
                            }





                            LOGINFORM loginForm = new LOGINFORM();
                            loginForm.Show();


                            this.Close(); // Close the Profile Form


                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Deletion failed: {ex.Message}",
                                          "Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void TextboxPassword_TextChanged_1(object sender, EventArgs e)
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

        private void textbox_username_TextChanged_1(object sender, EventArgs e)
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

            }
            else
            {
                usernamevalid.Visible = true;
                usernamevalid.Text = "✓ Username is valid";

            }
        }

        private void comboBoxGender_TextChanged_1(object sender, EventArgs e)
        {
            string[] allowedGenders = new string[]
   {
        "Male", "Female", "LGBTQIA", "Rather not say"
   };

            if (!allowedGenders.Contains(comboBoxGender.Text))
            {
                comboBoxGender.Text = "";
            }
        }

        private void usernamevalid_Click(object sender, EventArgs e)
        {

        }
    }
}
