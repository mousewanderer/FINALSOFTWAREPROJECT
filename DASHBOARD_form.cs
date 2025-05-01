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



        }



        public void LoadForm(Form form)
        {
            if (this.MAINPanel.Controls.Count > 0)
                this.MAINPanel.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MAINPanel.Controls.Add(form);
            this.MAINPanel.Tag = form;
            form.Show();
        }








        //  SWAPPING MECHANISM
        private void Profile_button_Click(object sender, EventArgs e)
        {
            LoadForm(new User_Profile(studentName, studentID));

        }

        private void AchievementsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Achievements());

        }

        private void quizbotbutton_Click(object sender, EventArgs e)
        {
            LoadForm(new Quizbot());

        }

        private void Backbutto_Click(object sender, EventArgs e)
        {
            // Redirect to Login Form
            // Redirect to Login Form
            LOGINFORM loginForm = new LOGINFORM();
            loginForm.Show();
            this.Close(); // Close the Profile Form
        }
    }
}
