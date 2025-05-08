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
            fileSystemWatcher1 = new FileSystemWatcher();
            panel2 = new Panel();
            Backbutto = new Button();
            Profile_button = new Button();
            quizbotbutton = new Button();
            AchievementsButton = new Button();
            Rankingbutton = new Button();
            SearchTextbox = new TextBox();
            Search_button = new Button();
            MAINPanel = new Panel();
            sidepanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(Backbutto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 38);
            panel2.TabIndex = 10;
            // 
            // Backbutto
            // 
            Backbutto.Location = new Point(1248, 6);
            Backbutto.Name = "Backbutto";
            Backbutto.Size = new Size(94, 29);
            Backbutto.TabIndex = 0;
            Backbutto.Text = "Back";
            Backbutto.UseVisualStyleBackColor = true;
            Backbutto.Click += Backbutto_Click;
            // 
            // Profile_button
            // 
            Profile_button.Location = new Point(21, 107);
            Profile_button.Name = "Profile_button";
            Profile_button.Size = new Size(271, 64);
            Profile_button.TabIndex = 7;
            Profile_button.Text = "Profile";
            Profile_button.UseVisualStyleBackColor = true;
            Profile_button.Click += Profile_button_Click;
            // 
            // quizbotbutton
            // 
            quizbotbutton.Location = new Point(21, 247);
            quizbotbutton.Name = "quizbotbutton";
            quizbotbutton.Size = new Size(271, 73);
            quizbotbutton.TabIndex = 5;
            quizbotbutton.Text = "Quizbot";
            quizbotbutton.UseVisualStyleBackColor = true;
            quizbotbutton.Click += quizbotbutton_Click;
            // 
            // AchievementsButton
            // 
            AchievementsButton.Location = new Point(21, 177);
            AchievementsButton.Name = "AchievementsButton";
            AchievementsButton.Size = new Size(271, 64);
            AchievementsButton.TabIndex = 5;
            AchievementsButton.Text = "Achievements";
            AchievementsButton.UseVisualStyleBackColor = true;
            AchievementsButton.Click += AchievementsButton_Click;
            // 
            // Rankingbutton
            // 
            Rankingbutton.Location = new Point(21, 326);
            Rankingbutton.Name = "Rankingbutton";
            Rankingbutton.Size = new Size(271, 64);
            Rankingbutton.TabIndex = 6;
            Rankingbutton.Text = "Ranking";
            Rankingbutton.UseVisualStyleBackColor = true;
            Rankingbutton.Click += Rankingbutton_Click;
            // 
            // SearchTextbox
            // 
            SearchTextbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextbox.Location = new Point(90, 436);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(202, 43);
            SearchTextbox.TabIndex = 5;
            // 
            // Search_button
            // 
            Search_button.Location = new Point(12, 431);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(72, 48);
            Search_button.TabIndex = 5;
            Search_button.Text = "Search";
            Search_button.UseVisualStyleBackColor = true;
            // 
            // MAINPanel
            // 
            MAINPanel.BackColor = Color.Silver;
            MAINPanel.Location = new Point(339, 76);
            MAINPanel.Name = "MAINPanel";
            MAINPanel.Size = new Size(1003, 537);
            MAINPanel.TabIndex = 0;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.Coral;
            sidepanel.Controls.Add(Profile_button);
            sidepanel.Controls.Add(Rankingbutton);
            sidepanel.Controls.Add(AchievementsButton);
            sidepanel.Controls.Add(SearchTextbox);
            sidepanel.Controls.Add(quizbotbutton);
            sidepanel.Controls.Add(Search_button);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 38);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(309, 648);
            sidepanel.TabIndex = 11;
            // 
            // DASHBOARD_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 686);
            Controls.Add(sidepanel);
            Controls.Add(panel2);
            Controls.Add(MAINPanel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DASHBOARD_form";
            Text = "DASHBOARD_form";
            Load += DASHBOARD_form_Load_1;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            sidepanel.ResumeLayout(false);
            sidepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel2;
        private Panel MAINPanel;
        private Button Profile_button;
        private TextBox SearchTextbox;
        private Button Search_button;
        private Button quizbotbutton;
        private Button Rankingbutton;
        private Button AchievementsButton;
        private Panel sidepanel;
        private Button Backbutto;
    }
}