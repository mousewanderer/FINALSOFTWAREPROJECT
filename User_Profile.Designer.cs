namespace SOFTDEV_FINAL_PROJECT
{
    partial class User_Profile
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
            NAME_LABEL = new Label();
            Userprofilepicture = new PictureBox();
            Firstname = new Label();
            lastname = new Label();
            CourseLabel = new Label();
            LEVEL_label = new Label();
            num_quizzes = new Label();
            ((System.ComponentModel.ISupportInitialize)Userprofilepicture).BeginInit();
            SuspendLayout();
            // 
            // NAME_LABEL
            // 
            NAME_LABEL.AutoSize = true;
            NAME_LABEL.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NAME_LABEL.Location = new Point(246, 166);
            NAME_LABEL.Name = "NAME_LABEL";
            NAME_LABEL.Size = new Size(266, 54);
            NAME_LABEL.TabIndex = 3;
            NAME_LABEL.Text = "Welcome Text";
            // 
            // Userprofilepicture
            // 
            Userprofilepicture.Location = new Point(42, 30);
            Userprofilepicture.Name = "Userprofilepicture";
            Userprofilepicture.Size = new Size(125, 109);
            Userprofilepicture.TabIndex = 6;
            Userprofilepicture.TabStop = false;
            Userprofilepicture.Click += Userprofilepicture_Click;
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Firstname.Location = new Point(173, 30);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(205, 54);
            Firstname.TabIndex = 7;
            Firstname.Text = "Firstname:";
            Firstname.Click += Firstname_Click;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastname.Location = new Point(178, 85);
            lastname.Name = "lastname";
            lastname.Size = new Size(200, 54);
            lastname.TabIndex = 8;
            lastname.Text = "Lastname:";
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CourseLabel.Location = new Point(56, 166);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(155, 54);
            CourseLabel.TabIndex = 9;
            CourseLabel.Text = "Course:";
            // 
            // LEVEL_label
            // 
            LEVEL_label.AutoSize = true;
            LEVEL_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LEVEL_label.Location = new Point(67, 249);
            LEVEL_label.Name = "LEVEL_label";
            LEVEL_label.Size = new Size(144, 41);
            LEVEL_label.TabIndex = 10;
            LEVEL_label.Text = "Level:  ___";
            // 
            // num_quizzes
            // 
            num_quizzes.AutoSize = true;
            num_quizzes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_quizzes.Location = new Point(67, 330);
            num_quizzes.Name = "num_quizzes";
            num_quizzes.Size = new Size(173, 41);
            num_quizzes.TabIndex = 11;
            num_quizzes.Text = "Quizzes: ___";
            // 
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 495);
            Controls.Add(num_quizzes);
            Controls.Add(LEVEL_label);
            Controls.Add(CourseLabel);
            Controls.Add(lastname);
            Controls.Add(Firstname);
            Controls.Add(Userprofilepicture);
            Controls.Add(NAME_LABEL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_Profile";
            Text = "User_Profile";
            Load += User_Profile_Load;
            ((System.ComponentModel.ISupportInitialize)Userprofilepicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NAME_LABEL;
        private PictureBox Userprofilepicture;
        private Label Firstname;
        private Label lastname;
        private Label CourseLabel;
        private Label LEVEL_label;
        private Label num_quizzes;
    }
}