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
            SearchTextbox = new TextBox();
            Search_button = new Button();
            MAINPanel = new Panel();
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
            Backbutto.ForeColor = Color.White;
            Backbutto.Location = new Point(1107, 12);
            Backbutto.Name = "Backbutto";
            Backbutto.Size = new Size(94, 29);
            Backbutto.TabIndex = 0;
            Backbutto.Text = "Back";
            Backbutto.UseVisualStyleBackColor = false;
            Backbutto.Click += Backbutto_Click;
            // 
            // Profile_button
            // 
            Profile_button.BackColor = Color.Teal;
            Profile_button.ForeColor = Color.Transparent;
            Profile_button.Image = (Image)resources.GetObject("Profile_button.Image");
            Profile_button.ImageAlign = ContentAlignment.MiddleLeft;
            Profile_button.Location = new Point(3, 174);
            Profile_button.Name = "Profile_button";
            Profile_button.Size = new Size(271, 64);
            Profile_button.TabIndex = 7;
            Profile_button.Text = "Profile";
            Profile_button.UseVisualStyleBackColor = false;
            Profile_button.Click += Profile_button_Click;
            // 
            // quizbotbutton
            // 
            quizbotbutton.BackColor = Color.Teal;
            quizbotbutton.ForeColor = Color.Transparent;
            quizbotbutton.Image = (Image)resources.GetObject("quizbotbutton.Image");
            quizbotbutton.ImageAlign = ContentAlignment.MiddleLeft;
            quizbotbutton.Location = new Point(3, 314);
            quizbotbutton.Name = "quizbotbutton";
            quizbotbutton.Size = new Size(271, 73);
            quizbotbutton.TabIndex = 5;
            quizbotbutton.Text = "Quizbot";
            quizbotbutton.UseVisualStyleBackColor = false;
            quizbotbutton.Click += quizbotbutton_Click;
            // 
            // AchievementsButton
            // 
            AchievementsButton.BackColor = Color.Teal;
            AchievementsButton.ForeColor = Color.Transparent;
            AchievementsButton.Image = (Image)resources.GetObject("AchievementsButton.Image");
            AchievementsButton.ImageAlign = ContentAlignment.MiddleLeft;
            AchievementsButton.Location = new Point(3, 244);
            AchievementsButton.Name = "AchievementsButton";
            AchievementsButton.Size = new Size(271, 64);
            AchievementsButton.TabIndex = 5;
            AchievementsButton.Text = "Achievements";
            AchievementsButton.UseVisualStyleBackColor = false;
            AchievementsButton.Click += AchievementsButton_Click;
            // 
            // Rankingbutton
            // 
            Rankingbutton.BackColor = Color.Teal;
            Rankingbutton.ForeColor = Color.Transparent;
            Rankingbutton.Image = (Image)resources.GetObject("Rankingbutton.Image");
            Rankingbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Rankingbutton.Location = new Point(3, 393);
            Rankingbutton.Name = "Rankingbutton";
            Rankingbutton.Size = new Size(271, 64);
            Rankingbutton.TabIndex = 6;
            Rankingbutton.Text = "Ranking";
            Rankingbutton.UseVisualStyleBackColor = false;
            Rankingbutton.Click += Rankingbutton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.BackColor = Color.Teal;
            SearchTextbox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextbox.ForeColor = Color.White;
            SearchTextbox.Location = new Point(72, 613);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(202, 51);
            SearchTextbox.TabIndex = 5;
            // 
            // Search_button
            // 
            Search_button.BackColor = Color.Teal;
            Search_button.Image = (Image)resources.GetObject("Search_button.Image");
            Search_button.Location = new Point(3, 610);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(63, 57);
            Search_button.TabIndex = 5;
            Search_button.UseVisualStyleBackColor = false;
            // 
            // MAINPanel
            // 
            MAINPanel.BackColor = Color.Turquoise;
            MAINPanel.Location = new Point(308, 47);
            MAINPanel.Name = "MAINPanel";
            MAINPanel.Size = new Size(899, 620);
            MAINPanel.TabIndex = 0;
            // 
            // DASHBOARD_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1219, 686);
            Controls.Add(Backbutto);
            Controls.Add(Rankingbutton);
            Controls.Add(Search_button);
            Controls.Add(SearchTextbox);
            Controls.Add(Profile_button);
            Controls.Add(AchievementsButton);
            Controls.Add(quizbotbutton);
            Controls.Add(MAINPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DASHBOARD_form";
            Text = "DASHBOARD_form";
            Load += DASHBOARD_form_Load_1;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Panel MAINPanel;
        private Button Profile_button;
        private TextBox SearchTextbox;
        private Button Search_button;
        private Button quizbotbutton;
        private Button Rankingbutton;
        private Button AchievementsButton;
        private Button Backbutto;
    }
}