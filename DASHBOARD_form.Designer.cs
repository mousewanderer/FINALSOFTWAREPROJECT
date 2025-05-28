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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD_form));
            fileSystemWatcher1 = new FileSystemWatcher();
            Backbutto = new Button();
            Profile_button = new Button();
            quizbotbutton = new Button();
            AchievementsButton = new Button();
            Rankingbutton = new Button();
            MAINPanel = new Panel();
            UPDATEBUTTON = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Backbutto
            // 
            Backbutto.BackColor = Color.Teal;
            Backbutto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Backbutto.ForeColor = Color.White;
            Backbutto.Location = new Point(23, 550);
            Backbutto.Name = "Backbutto";
            Backbutto.Size = new Size(200, 58);
            Backbutto.TabIndex = 0;
            Backbutto.Text = "Back";
            Backbutto.UseVisualStyleBackColor = false;
            Backbutto.Click += Backbutto_Click;
            // 
            // Profile_button
            // 
            Profile_button.BackColor = Color.Teal;
            Profile_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Profile_button.ForeColor = Color.Transparent;
            Profile_button.Image = (Image)resources.GetObject("Profile_button.Image");
            Profile_button.ImageAlign = ContentAlignment.MiddleLeft;
            Profile_button.Location = new Point(36, 165);
            Profile_button.Name = "Profile_button";
            Profile_button.Size = new Size(172, 64);
            Profile_button.TabIndex = 7;
            Profile_button.Text = "Profile";
            Profile_button.UseVisualStyleBackColor = false;
            Profile_button.Click += Profile_button_Click;
            // 
            // quizbotbutton
            // 
            quizbotbutton.BackColor = Color.Teal;
            quizbotbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            quizbotbutton.ForeColor = Color.Transparent;
            quizbotbutton.Image = (Image)resources.GetObject("quizbotbutton.Image");
            quizbotbutton.ImageAlign = ContentAlignment.MiddleLeft;
            quizbotbutton.Location = new Point(36, 305);
            quizbotbutton.Name = "quizbotbutton";
            quizbotbutton.Size = new Size(172, 73);
            quizbotbutton.TabIndex = 5;
            quizbotbutton.Text = "Quizbot";
            quizbotbutton.UseVisualStyleBackColor = false;
            quizbotbutton.Click += quizbotbutton_Click;
            // 
            // AchievementsButton
            // 
            AchievementsButton.BackColor = Color.Teal;
            AchievementsButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AchievementsButton.ForeColor = Color.Transparent;
            AchievementsButton.Image = (Image)resources.GetObject("AchievementsButton.Image");
            AchievementsButton.ImageAlign = ContentAlignment.MiddleLeft;
            AchievementsButton.Location = new Point(36, 235);
            AchievementsButton.Name = "AchievementsButton";
            AchievementsButton.Size = new Size(172, 64);
            AchievementsButton.TabIndex = 5;
            AchievementsButton.Text = "        Achievements";
            AchievementsButton.UseVisualStyleBackColor = false;
            AchievementsButton.Click += AchievementsButton_Click;
            // 
            // Rankingbutton
            // 
            Rankingbutton.BackColor = Color.Teal;
            Rankingbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Rankingbutton.ForeColor = Color.Transparent;
            Rankingbutton.Image = (Image)resources.GetObject("Rankingbutton.Image");
            Rankingbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Rankingbutton.Location = new Point(36, 384);
            Rankingbutton.Name = "Rankingbutton";
            Rankingbutton.Size = new Size(172, 64);
            Rankingbutton.TabIndex = 6;
            Rankingbutton.Text = "Ranking";
            Rankingbutton.UseVisualStyleBackColor = false;
            Rankingbutton.Click += Rankingbutton_Click;
            // 
            // MAINPanel
            // 
            MAINPanel.BackColor = Color.Turquoise;
            MAINPanel.Location = new Point(267, 12);
            MAINPanel.Name = "MAINPanel";
            MAINPanel.Size = new Size(820, 600);
            MAINPanel.TabIndex = 0;
            // 
            // UPDATEBUTTON
            // 
            UPDATEBUTTON.BackColor = Color.Teal;
            UPDATEBUTTON.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            UPDATEBUTTON.ForeColor = Color.White;
            UPDATEBUTTON.Location = new Point(36, 465);
            UPDATEBUTTON.Name = "UPDATEBUTTON";
            UPDATEBUTTON.Size = new Size(172, 64);
            UPDATEBUTTON.TabIndex = 8;
            UPDATEBUTTON.Text = "Update Profile";
            UPDATEBUTTON.UseVisualStyleBackColor = false;
            UPDATEBUTTON.Click += UPDATEBUTTON_Click;
            // 
            // DASHBOARD_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1100, 620);
            Controls.Add(UPDATEBUTTON);
            Controls.Add(Backbutto);
            Controls.Add(Rankingbutton);
            Controls.Add(Profile_button);
            Controls.Add(AchievementsButton);
            Controls.Add(quizbotbutton);
            Controls.Add(MAINPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DASHBOARD_form";
            Text = "DASHBOARD_form";
            Load += DASHBOARD_form_Load_1;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Panel MAINPanel;
        private Button Profile_button;
        private Button quizbotbutton;
        private Button Rankingbutton;
        private Button AchievementsButton;
        private Button Backbutto;
        private Button UPDATEBUTTON;
    }
}