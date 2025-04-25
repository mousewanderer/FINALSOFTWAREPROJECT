namespace SOFTDEV_FINAL_PROJECT
{
    partial class DASHBOARD_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Quizbot = new Label();
            scoreofquizzes = new Label();
            Achievementslabel = new Label();
            NAME_LABEL = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            LEVEL_label = new Label();
            num_quizzes = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Quizbot);
            panel1.Controls.Add(scoreofquizzes);
            panel1.Controls.Add(Achievementslabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 450);
            panel1.TabIndex = 0;
            // 
            // Quizbot
            // 
            Quizbot.AutoSize = true;
            Quizbot.Location = new Point(27, 194);
            Quizbot.Name = "Quizbot";
            Quizbot.Size = new Size(62, 20);
            Quizbot.TabIndex = 5;
            Quizbot.Text = "Quizbot";
            // 
            // scoreofquizzes
            // 
            scoreofquizzes.AutoSize = true;
            scoreofquizzes.Location = new Point(27, 127);
            scoreofquizzes.Name = "scoreofquizzes";
            scoreofquizzes.Size = new Size(125, 20);
            scoreofquizzes.TabIndex = 4;
            scoreofquizzes.Text = "Scores of Quizzes";
            // 
            // Achievementslabel
            // 
            Achievementslabel.AutoSize = true;
            Achievementslabel.Location = new Point(27, 69);
            Achievementslabel.Name = "Achievementslabel";
            Achievementslabel.Size = new Size(101, 20);
            Achievementslabel.TabIndex = 3;
            Achievementslabel.Text = "Achievements";
            // 
            // NAME_LABEL
            // 
            NAME_LABEL.AutoSize = true;
            NAME_LABEL.Location = new Point(312, 26);
            NAME_LABEL.Name = "NAME_LABEL";
            NAME_LABEL.Size = new Size(51, 20);
            NAME_LABEL.TabIndex = 2;
            NAME_LABEL.Text = "ddfdff";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LEVEL_label
            // 
            LEVEL_label.AutoSize = true;
            LEVEL_label.Location = new Point(303, 79);
            LEVEL_label.Name = "LEVEL_label";
            LEVEL_label.Size = new Size(133, 20);
            LEVEL_label.TabIndex = 3;
            LEVEL_label.Text = "YOU ARE LEVEL ___";
            // 
            // num_quizzes
            // 
            num_quizzes.AutoSize = true;
            num_quizzes.Location = new Point(312, 160);
            num_quizzes.Name = "num_quizzes";
            num_quizzes.Size = new Size(163, 20);
            num_quizzes.TabIndex = 4;
            num_quizzes.Text = "YOU HAVE QUIZZES ___";
            // 
            // DASHBOARD_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 450);
            Controls.Add(num_quizzes);
            Controls.Add(LEVEL_label);
            Controls.Add(NAME_LABEL);
            Controls.Add(panel1);
            Name = "DASHBOARD_form";
            Text = "DASHBOARD_form";
            Load += DASHBOARD_form_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Quizbot;
        private Label scoreofquizzes;
        private Label Achievementslabel;
        private Label NAME_LABEL;
        private FileSystemWatcher fileSystemWatcher1;
        private Label LEVEL_label;
        private Label num_quizzes;
    }
}