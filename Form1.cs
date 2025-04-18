using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SOFTDEV_FINAL_PROJECT
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void buttonCREATE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CREATE ACCOUNT", "Success");

            // Open the Personal Information Profile Form
            CREATE_form createform = new CREATE_form();
            createform.Show();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Hardcoded username
            string correctUsername = "admin";
            string password = "Fish";

            // Get user input
            string enteredUsername = textBoxUsername.Text.Trim();
            string enteredPassword = textBoxPassword.Text;

            // Validate input
            if (enteredUsername == correctUsername && enteredPassword == password)
            {
                MessageBox.Show("Login Successful!", "Success");

                // Dashboard Form
               
                DASHBOARD_form DashForm = new DASHBOARD_form();
                DashForm.Show();


                this.Hide(); // Hide the Login Form
            }

        }
    }
}
