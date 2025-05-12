namespace SOFTDEV_FINAL_PROJECT
{
    partial class questionnaire
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
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbD = new RadioButton();
            NEXTbutton = new Button();
            QUESTION_Label = new Label();
            SCORELABEL = new Label();
            lblFeedback = new Label();
            SuspendLayout();
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Font = new Font("Segoe UI", 12F);
            rbA.ForeColor = Color.FromArgb(40, 122, 116);
            rbA.Location = new Point(36, 133);
            rbA.Margin = new Padding(4);
            rbA.Name = "rbA";
            rbA.Size = new Size(70, 32);
            rbA.TabIndex = 0;
            rbA.TabStop = true;
            rbA.Text = " rbA";
            rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Font = new Font("Segoe UI", 12F);
            rbB.ForeColor = Color.FromArgb(40, 122, 116);
            rbB.Location = new Point(36, 175);
            rbB.Margin = new Padding(4);
            rbB.Name = "rbB";
            rbB.Size = new Size(149, 32);
            rbB.TabIndex = 1;
            rbB.TabStop = true;
            rbB.Text = "radioButton2";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Font = new Font("Segoe UI", 12F);
            rbC.ForeColor = Color.FromArgb(40, 122, 116);
            rbC.Location = new Point(36, 217);
            rbC.Margin = new Padding(4);
            rbC.Name = "rbC";
            rbC.Size = new Size(149, 32);
            rbC.TabIndex = 2;
            rbC.TabStop = true;
            rbC.Text = "radioButton3";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Font = new Font("Segoe UI", 12F);
            rbD.ForeColor = Color.FromArgb(40, 122, 116);
            rbD.Location = new Point(36, 259);
            rbD.Margin = new Padding(4);
            rbD.Name = "rbD";
            rbD.Size = new Size(149, 32);
            rbD.TabIndex = 3;
            rbD.TabStop = true;
            rbD.Text = "radioButton4";
            rbD.UseVisualStyleBackColor = true;
            // 
            // NEXTbutton
            // 
            NEXTbutton.ForeColor = Color.FromArgb(40, 122, 116);
            NEXTbutton.Location = new Point(25, 328);
            NEXTbutton.Margin = new Padding(4);
            NEXTbutton.Name = "NEXTbutton";
            NEXTbutton.Size = new Size(129, 41);
            NEXTbutton.TabIndex = 4;
            NEXTbutton.Text = "NEXT";
            NEXTbutton.UseVisualStyleBackColor = true;
            NEXTbutton.Click += NEXTbutton_Click;
            // 
            // QUESTION_Label
            // 
            QUESTION_Label.AutoSize = true;
            QUESTION_Label.ForeColor = Color.FromArgb(40, 122, 116);
            QUESTION_Label.Location = new Point(36, 37);
            QUESTION_Label.Margin = new Padding(4, 0, 4, 0);
            QUESTION_Label.Name = "QUESTION_Label";
            QUESTION_Label.Size = new Size(118, 28);
            QUESTION_Label.TabIndex = 5;
            QUESTION_Label.Text = "QUESTIONS";
            // 
            // SCORELABEL
            // 
            SCORELABEL.AutoSize = true;
            SCORELABEL.ForeColor = Color.FromArgb(40, 122, 116);
            SCORELABEL.Location = new Point(749, 9);
            SCORELABEL.Name = "SCORELABEL";
            SCORELABEL.Size = new Size(71, 28);
            SCORELABEL.TabIndex = 6;
            SCORELABEL.Text = "SCORE";
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.ForeColor = Color.FromArgb(40, 122, 116);
            lblFeedback.Location = new Point(731, 357);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(117, 28);
            lblFeedback.TabIndex = 7;
            lblFeedback.Text = "lblFeedback";
            // 
            // questionnaire
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 216, 246);
            ClientSize = new Size(901, 404);
            Controls.Add(lblFeedback);
            Controls.Add(SCORELABEL);
            Controls.Add(QUESTION_Label);
            Controls.Add(NEXTbutton);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            Name = "questionnaire";
            Text = "questionnaire";
            Load += questionnaire_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbD;
        private Button NEXTbutton;
        private Label QUESTION_Label;
        private Label SCORELABEL;
        private Label lblFeedback;
    }
}