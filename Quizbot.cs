using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;





namespace SOFTDEV_FINAL_PROJECT
{
    public partial class Quizbot : Form
    {
        public Quizbot()
        {
            InitializeComponent();
        }


        // LOAD ZONE

        String CURRENT_QUIZ = "";



        bool started = false;



        // QUIZ BOT CLICK

        private void Math1button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "Math1_Quiz.xlsx";
                questionnaire question = new questionnaire(CURRENT_QUIZ);

                question.Show();
            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }

        }

        private void InfoTech1button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "InfoTech1_Quiz.xlsx";
            questionnaire question = new questionnaire(CURRENT_QUIZ);

            question.Show();
            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Math2button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "Math2_Quiz.xlsx";
            questionnaire question = new questionnaire(CURRENT_QUIZ);

            question.Show();
        }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }
        
        }

        private void InfoTech2button_Click(object sender, EventArgs e)
        {

            if (!(started))
            {
                CURRENT_QUIZ = "InfoTech2_Quiz.xlsx";
            questionnaire question = new questionnaire(CURRENT_QUIZ);

            question.Show();

            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Biology1button_Click(object sender, EventArgs e)
        {


            if (!(started))
            {
                CURRENT_QUIZ = "Biology1_Quiz.xlsx";
            questionnaire question = new questionnaire(CURRENT_QUIZ);

            question.Show();

        }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


}

        private void Physics1button_Click(object sender, EventArgs e)
        {


            if (!(started))
            {
                CURRENT_QUIZ = "Physics1_Quiz.xlsx";
            questionnaire question = new questionnaire(CURRENT_QUIZ);

            question.Show();

            }
            else
            {
                MessageBox.Show("Sorry Please Complete the current quiz");
            }


        }

        private void Quizbot_Load(object sender, EventArgs e)
        {

        }
    }
}
