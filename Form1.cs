using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using SOFTDEV_FINAL_PROJECT;




namespace SOFTDEV_FINAL_PROJECT
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
         
            InitializeComponent();
        }


        private string loggedInUsername;



        private void buttonCREATE_Click(object sender, EventArgs e)
        {
     
            CREATE_form createform = new CREATE_form();
            createform.Show();
            this.Hide();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxUsername.Text.Trim();
            string enteredPassword = textBoxPassword.Text;

            using (SqlConnection conn = new SqlConnection("Server=ASUS_2023;Database=Final_ProjectDB;Trusted_Connection=True;"))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Students WHERE Username = @username AND KeyPassword = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", enteredUsername);
                        cmd.Parameters.AddWithValue("@password", enteredPassword);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            string query2 = "SELECT FirstName, StudentID FROM Students WHERE Username = @username AND KeyPassword = @password";

                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                cmd2.Parameters.AddWithValue("@username", enteredUsername);
                                cmd2.Parameters.AddWithValue("@password", enteredPassword);

                                using (SqlDataReader reader = cmd2.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string nameFromDB = reader["FirstName"].ToString();
                                        string studentIdFromDB = reader["StudentID"].ToString();

                                        MessageBox.Show($"Login Successful! Welcome, {nameFromDB} (ID: {studentIdFromDB})", "Success");

                                        // You must modify your userform  constructor to accept two arguments
                                        User_Profile userform = new User_Profile(nameFromDB, studentIdFromDB);

                                        DASHBOARD_form dashForm = new DASHBOARD_form(nameFromDB, studentIdFromDB);


                                        dashForm.Show();


                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error fetching student details.", "Error");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database:\n" + ex.Message, "Database Error");
                }
            }


        }

    }
}
