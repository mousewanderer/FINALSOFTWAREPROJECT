namespace SOFTDEV_FINAL_PROJECT
{
    partial class Quizbot
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
            label1 = new Label();
            Math1button = new Button();
            mathpanel1 = new Panel();
            MATH1SCORE = new Label();
            Math1 = new Label();
            Math2 = new Label();
            Math2button = new Button();
            InfoTech1 = new Label();
            InfoTech1button = new Button();
            mathpanel2 = new Panel();
            MATH2SCORE = new Label();
            Infotechpanel1 = new Panel();
            INFO1SCORE = new Label();
            InfoTech2panel = new Panel();
            INFO2SCORE = new Label();
            InfoTech2button = new Button();
            InfoTech2 = new Label();
            Biology1panel = new Panel();
            BIO1SCORE = new Label();
            Biology1button = new Button();
            Biology1 = new Label();
            Physics1panel = new Panel();
            PHY1SCORE = new Label();
            Physics1 = new Label();
            Physics1button = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mathpanel1.SuspendLayout();
            mathpanel2.SuspendLayout();
            Infotechpanel1.SuspendLayout();
            InfoTech2panel.SuspendLayout();
            Biology1panel.SuspendLayout();
            Physics1panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 40);
            label1.TabIndex = 0;
            label1.Text = "QUIZBOT";
            // 
            // Math1button
            // 
            Math1button.Location = new Point(19, 106);
            Math1button.Name = "Math1button";
            Math1button.Size = new Size(94, 29);
            Math1button.TabIndex = 1;
            Math1button.Text = "Ready";
            Math1button.UseVisualStyleBackColor = true;
            Math1button.Click += Math1button_Click;
            // 
            // mathpanel1
            // 
            mathpanel1.BackColor = Color.LightSalmon;
            mathpanel1.Controls.Add(MATH1SCORE);
            mathpanel1.Controls.Add(Math1);
            mathpanel1.Controls.Add(Math1button);
            mathpanel1.Location = new Point(62, 77);
            mathpanel1.Name = "mathpanel1";
            mathpanel1.Size = new Size(128, 138);
            mathpanel1.TabIndex = 2;
            // 
            // MATH1SCORE
            // 
            MATH1SCORE.AutoSize = true;
            MATH1SCORE.Font = new Font("Segoe UI", 12F);
            MATH1SCORE.Location = new Point(19, 75);
            MATH1SCORE.Name = "MATH1SCORE";
            MATH1SCORE.Size = new Size(53, 28);
            MATH1SCORE.TabIndex = 9;
            MATH1SCORE.Text = "1/15";
            MATH1SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Math1
            // 
            Math1.AutoSize = true;
            Math1.Font = new Font("Segoe UI", 12F);
            Math1.Location = new Point(19, 47);
            Math1.Name = "Math1";
            Math1.Size = new Size(69, 28);
            Math1.TabIndex = 3;
            Math1.Text = "Math1";
            // 
            // Math2
            // 
            Math2.AutoSize = true;
            Math2.Font = new Font("Segoe UI", 12F);
            Math2.Location = new Point(20, 47);
            Math2.Name = "Math2";
            Math2.Size = new Size(69, 28);
            Math2.TabIndex = 3;
            Math2.Text = "Math2";
            // 
            // Math2button
            // 
            Math2button.Location = new Point(20, 106);
            Math2button.Name = "Math2button";
            Math2button.Size = new Size(94, 29);
            Math2button.TabIndex = 1;
            Math2button.Text = "Ready";
            Math2button.UseVisualStyleBackColor = true;
            Math2button.Click += Math2button_Click;
            // 
            // InfoTech1
            // 
            InfoTech1.AutoSize = true;
            InfoTech1.Font = new Font("Segoe UI", 12F);
            InfoTech1.Location = new Point(19, 47);
            InfoTech1.Name = "InfoTech1";
            InfoTech1.Size = new Size(95, 28);
            InfoTech1.TabIndex = 3;
            InfoTech1.Text = "InfoTech1";
            // 
            // InfoTech1button
            // 
            InfoTech1button.Location = new Point(20, 106);
            InfoTech1button.Name = "InfoTech1button";
            InfoTech1button.Size = new Size(94, 29);
            InfoTech1button.TabIndex = 1;
            InfoTech1button.Text = "Ready";
            InfoTech1button.UseVisualStyleBackColor = true;
            InfoTech1button.Click += InfoTech1button_Click;
            // 
            // mathpanel2
            // 
            mathpanel2.BackColor = Color.LightSalmon;
            mathpanel2.Controls.Add(MATH2SCORE);
            mathpanel2.Controls.Add(Math2);
            mathpanel2.Controls.Add(Math2button);
            mathpanel2.Location = new Point(229, 77);
            mathpanel2.Name = "mathpanel2";
            mathpanel2.Size = new Size(128, 138);
            mathpanel2.TabIndex = 4;
            // 
            // MATH2SCORE
            // 
            MATH2SCORE.AutoSize = true;
            MATH2SCORE.Font = new Font("Segoe UI", 12F);
            MATH2SCORE.Location = new Point(20, 75);
            MATH2SCORE.Name = "MATH2SCORE";
            MATH2SCORE.Size = new Size(53, 28);
            MATH2SCORE.TabIndex = 10;
            MATH2SCORE.Text = "1/15";
            MATH2SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Infotechpanel1
            // 
            Infotechpanel1.BackColor = Color.FromArgb(128, 255, 255);
            Infotechpanel1.Controls.Add(InfoTech1button);
            Infotechpanel1.Controls.Add(INFO1SCORE);
            Infotechpanel1.Controls.Add(InfoTech1);
            Infotechpanel1.Location = new Point(406, 77);
            Infotechpanel1.Name = "Infotechpanel1";
            Infotechpanel1.Size = new Size(128, 138);
            Infotechpanel1.TabIndex = 5;
            // 
            // INFO1SCORE
            // 
            INFO1SCORE.AutoSize = true;
            INFO1SCORE.Font = new Font("Segoe UI", 12F);
            INFO1SCORE.Location = new Point(19, 75);
            INFO1SCORE.Name = "INFO1SCORE";
            INFO1SCORE.Size = new Size(53, 28);
            INFO1SCORE.TabIndex = 11;
            INFO1SCORE.Text = "1/15";
            INFO1SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InfoTech2panel
            // 
            InfoTech2panel.BackColor = Color.FromArgb(128, 255, 255);
            InfoTech2panel.Controls.Add(INFO2SCORE);
            InfoTech2panel.Controls.Add(InfoTech2button);
            InfoTech2panel.Controls.Add(InfoTech2);
            InfoTech2panel.Location = new Point(62, 256);
            InfoTech2panel.Name = "InfoTech2panel";
            InfoTech2panel.Size = new Size(128, 138);
            InfoTech2panel.TabIndex = 6;
            // 
            // INFO2SCORE
            // 
            INFO2SCORE.AutoSize = true;
            INFO2SCORE.Font = new Font("Segoe UI", 12F);
            INFO2SCORE.Location = new Point(19, 75);
            INFO2SCORE.Name = "INFO2SCORE";
            INFO2SCORE.Size = new Size(53, 28);
            INFO2SCORE.TabIndex = 12;
            INFO2SCORE.Text = "1/15";
            INFO2SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InfoTech2button
            // 
            InfoTech2button.Location = new Point(19, 106);
            InfoTech2button.Name = "InfoTech2button";
            InfoTech2button.Size = new Size(94, 29);
            InfoTech2button.TabIndex = 1;
            InfoTech2button.Text = "Ready";
            InfoTech2button.UseVisualStyleBackColor = true;
            InfoTech2button.Click += InfoTech2button_Click;
            // 
            // InfoTech2
            // 
            InfoTech2.AutoSize = true;
            InfoTech2.Font = new Font("Segoe UI", 12F);
            InfoTech2.Location = new Point(19, 47);
            InfoTech2.Name = "InfoTech2";
            InfoTech2.Size = new Size(95, 28);
            InfoTech2.TabIndex = 3;
            InfoTech2.Text = "InfoTech2";
            // 
            // Biology1panel
            // 
            Biology1panel.BackColor = Color.Lime;
            Biology1panel.Controls.Add(BIO1SCORE);
            Biology1panel.Controls.Add(Biology1button);
            Biology1panel.Controls.Add(Biology1);
            Biology1panel.Location = new Point(229, 256);
            Biology1panel.Name = "Biology1panel";
            Biology1panel.Size = new Size(128, 138);
            Biology1panel.TabIndex = 7;
            // 
            // BIO1SCORE
            // 
            BIO1SCORE.AutoSize = true;
            BIO1SCORE.Font = new Font("Segoe UI", 12F);
            BIO1SCORE.Location = new Point(20, 75);
            BIO1SCORE.Name = "BIO1SCORE";
            BIO1SCORE.Size = new Size(53, 28);
            BIO1SCORE.TabIndex = 13;
            BIO1SCORE.Text = "1/15";
            BIO1SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Biology1button
            // 
            Biology1button.Location = new Point(20, 106);
            Biology1button.Name = "Biology1button";
            Biology1button.Size = new Size(94, 29);
            Biology1button.TabIndex = 1;
            Biology1button.Text = "Ready";
            Biology1button.UseVisualStyleBackColor = true;
            Biology1button.Click += Biology1button_Click;
            // 
            // Biology1
            // 
            Biology1.AutoSize = true;
            Biology1.Font = new Font("Segoe UI", 12F);
            Biology1.Location = new Point(20, 47);
            Biology1.Name = "Biology1";
            Biology1.Size = new Size(90, 28);
            Biology1.TabIndex = 3;
            Biology1.Text = "Biology1";
            // 
            // Physics1panel
            // 
            Physics1panel.BackColor = Color.Yellow;
            Physics1panel.Controls.Add(PHY1SCORE);
            Physics1panel.Controls.Add(Physics1);
            Physics1panel.Controls.Add(Physics1button);
            Physics1panel.Location = new Point(406, 256);
            Physics1panel.Name = "Physics1panel";
            Physics1panel.Size = new Size(128, 138);
            Physics1panel.TabIndex = 8;
            // 
            // PHY1SCORE
            // 
            PHY1SCORE.AutoSize = true;
            PHY1SCORE.Font = new Font("Segoe UI", 12F);
            PHY1SCORE.Location = new Point(20, 75);
            PHY1SCORE.Name = "PHY1SCORE";
            PHY1SCORE.Size = new Size(53, 28);
            PHY1SCORE.TabIndex = 14;
            PHY1SCORE.Text = "1/15";
            PHY1SCORE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Physics1
            // 
            Physics1.AutoSize = true;
            Physics1.Font = new Font("Segoe UI", 12F);
            Physics1.Location = new Point(20, 47);
            Physics1.Name = "Physics1";
            Physics1.Size = new Size(85, 28);
            Physics1.TabIndex = 3;
            Physics1.Text = "Physics1";
            // 
            // Physics1button
            // 
            Physics1button.Location = new Point(20, 106);
            Physics1button.Name = "Physics1button";
            Physics1button.Size = new Size(94, 29);
            Physics1button.TabIndex = 1;
            Physics1button.Text = "Ready";
            Physics1button.UseVisualStyleBackColor = true;
            Physics1button.Click += Physics1button_Click;
            // 
            // Quizbot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(Physics1panel);
            Controls.Add(Biology1panel);
            Controls.Add(InfoTech2panel);
            Controls.Add(Infotechpanel1);
            Controls.Add(mathpanel2);
            Controls.Add(mathpanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Quizbot";
            Text = "Quizbot";
            Load += Quizbot_Load;
            mathpanel1.ResumeLayout(false);
            mathpanel1.PerformLayout();
            mathpanel2.ResumeLayout(false);
            mathpanel2.PerformLayout();
            Infotechpanel1.ResumeLayout(false);
            Infotechpanel1.PerformLayout();
            InfoTech2panel.ResumeLayout(false);
            InfoTech2panel.PerformLayout();
            Biology1panel.ResumeLayout(false);
            Biology1panel.PerformLayout();
            Physics1panel.ResumeLayout(false);
            Physics1panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Math1button;
        private Panel mathpanel1;
        private Label Math1;
        private Label Math2;
        private Button Math2button;
        private Label InfoTech1;
        private Button InfoTech1button;
        private Panel mathpanel2;
        private Panel Infotechpanel1;
        private Panel InfoTech2panel;
        private Label InfoTech2;
        private Button InfoTech2button;
        private Panel Biology1panel;
        private Label Biology1;
        private Button Biology1button;
        private Panel Physics1panel;
        private Label Physics1;
        private Button Physics1button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label MATH1SCORE;
        private Label MATH2SCORE;
        private Label INFO1SCORE;
        private Label INFO2SCORE;
        private Label BIO1SCORE;
        private Label PHY1SCORE;
    }
}