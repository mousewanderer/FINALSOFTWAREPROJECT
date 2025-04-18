using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        private void CREATE_form_load(object sender, EventArgs e)

        {
            // Add categories to the ComboBox
            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.Items.Add("LGBTQIA");
            comboBoxGender.Items.Add("Rather not say");
        }



        private void Create_button_Click(object sender, EventArgs e)
        {

            bool allowed = true;

            // Retrieve input data
            string fullName = textBoxFullName.Text.Trim();
            string ageInput = textBoxAge.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();
            string username = textbox_username.Text.Trim();
            string password = TextboxPassword.Text.Trim();

            // Validate Full Name
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter your full name.", "Input Error");
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
                    MessageBox.Show($"{fullName}, INVALID", "Age Status");
                    allowed = false;
                    textBoxAge.Text = "";
                }
                else
                {
                    MessageBox.Show($"{fullName}, ARE YOU SURE???", "Age Status");
                    allowed = true;

                }
            }
            else if (age <= 0)
            {
                MessageBox.Show($"{fullName},", "Age Status");
                allowed = false;
                textBoxAge.Text = "";
            }
            else
            {

                if (age <= 18)
                {
                    MessageBox.Show($"{fullName},  ARE YOU SURE?? ", "Age Status");
                    allowed = true;
                }
                else
                {


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

        }
    }
}
