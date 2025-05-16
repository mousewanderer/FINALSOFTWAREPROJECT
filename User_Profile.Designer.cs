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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Profile));
            NAME_LABEL = new Label();
            Userprofilepicture = new PictureBox();
            Firstname = new Label();
            lastname = new Label();
            CourseLabel = new Label();
            LEVEL_label = new Label();
            num_quizzes = new Label();
            Agelabel = new Label();
            Gender = new Label();
            Usernamelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Userprofilepicture).BeginInit();
            SuspendLayout();
            // 
            // NAME_LABEL
            // 
            NAME_LABEL.AutoSize = true;
            NAME_LABEL.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NAME_LABEL.ForeColor = Color.FromArgb(40, 122, 116);
            NAME_LABEL.Location = new Point(15, 16);
            NAME_LABEL.Name = "NAME_LABEL";
            NAME_LABEL.Size = new Size(230, 46);
            NAME_LABEL.TabIndex = 3;
            NAME_LABEL.Text = "Welcome Text";
            // 
            // Userprofilepicture
            // 
            Userprofilepicture.BackColor = Color.FromArgb(209, 216, 246);
            Userprofilepicture.Location = new Point(94, 144);
            Userprofilepicture.Name = "Userprofilepicture";
            Userprofilepicture.Size = new Size(89, 89);
            Userprofilepicture.TabIndex = 6;
            Userprofilepicture.TabStop = false;
            Userprofilepicture.Click += Userprofilepicture_Click;
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.BackColor = Color.FromArgb(40, 122, 116);
            Firstname.Font = new Font("Segoe UI", 12F);
            Firstname.ForeColor = SystemColors.ButtonFace;
            Firstname.Location = new Point(338, 144);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(101, 28);
            Firstname.TabIndex = 7;
            Firstname.Text = "Firstname:";
            Firstname.Click += Firstname_Click;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.BackColor = Color.FromArgb(40, 122, 116);
            lastname.Font = new Font("Segoe UI", 12F);
            lastname.ForeColor = SystemColors.ButtonFace;
            lastname.Location = new Point(338, 205);
            lastname.Name = "lastname";
            lastname.Size = new Size(98, 28);
            lastname.TabIndex = 8;
            lastname.Text = "Lastname:";
            // 
            // CourseLabel
            // 
            CourseLabel.AutoSize = true;
            CourseLabel.BackColor = Color.FromArgb(40, 122, 116);
            CourseLabel.Font = new Font("Segoe UI", 12F);
            CourseLabel.ForeColor = SystemColors.ButtonFace;
            CourseLabel.Location = new Point(194, 432);
            CourseLabel.Name = "CourseLabel";
            CourseLabel.Size = new Size(76, 28);
            CourseLabel.TabIndex = 9;
            CourseLabel.Text = "Course:";
            // 
            // LEVEL_label
            // 
            LEVEL_label.AutoSize = true;
            LEVEL_label.BackColor = Color.FromArgb(40, 122, 116);
            LEVEL_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LEVEL_label.ForeColor = SystemColors.ButtonFace;
            LEVEL_label.Location = new Point(594, 239);
            LEVEL_label.Name = "LEVEL_label";
            LEVEL_label.Size = new Size(94, 28);
            LEVEL_label.TabIndex = 10;
            LEVEL_label.Text = "Level:  ___";
            // 
            // num_quizzes
            // 
            num_quizzes.AutoSize = true;
            num_quizzes.BackColor = Color.FromArgb(40, 122, 116);
            num_quizzes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_quizzes.ForeColor = SystemColors.ButtonFace;
            num_quizzes.Location = new Point(576, 310);
            num_quizzes.Name = "num_quizzes";
            num_quizzes.Size = new Size(112, 28);
            num_quizzes.TabIndex = 11;
            num_quizzes.Text = "Quizzes: ___";
            // 
            // Agelabel
            // 
            Agelabel.AutoSize = true;
            Agelabel.BackColor = Color.FromArgb(40, 122, 116);
            Agelabel.Font = new Font("Segoe UI", 12F);
            Agelabel.ForeColor = SystemColors.ButtonFace;
            Agelabel.Location = new Point(194, 389);
            Agelabel.Name = "Agelabel";
            Agelabel.Size = new Size(51, 28);
            Agelabel.TabIndex = 12;
            Agelabel.Text = "Age:";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.BackColor = Color.FromArgb(40, 122, 116);
            Gender.Font = new Font("Segoe UI", 12F);
            Gender.ForeColor = SystemColors.ButtonFace;
            Gender.Location = new Point(190, 480);
            Gender.Name = "Gender";
            Gender.Size = new Size(80, 28);
            Gender.TabIndex = 13;
            Gender.Text = "Gender:";
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.BackColor = Color.FromArgb(40, 122, 116);
            Usernamelabel.Font = new Font("Segoe UI", 12F);
            Usernamelabel.ForeColor = SystemColors.ButtonFace;
            Usernamelabel.Location = new Point(194, 343);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(103, 28);
            Usernamelabel.TabIndex = 14;
            Usernamelabel.Text = "Username:";
            Usernamelabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // User_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 219, 217);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(820, 600);
            Controls.Add(lastname);
            Controls.Add(Usernamelabel);
            Controls.Add(Firstname);
            Controls.Add(Gender);
            Controls.Add(Userprofilepicture);
            Controls.Add(Agelabel);
            Controls.Add(num_quizzes);
            Controls.Add(LEVEL_label);
            Controls.Add(CourseLabel);
            Controls.Add(NAME_LABEL);
            DoubleBuffered = true;
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
        private Label Agelabel;
        private Label Gender;
        private Label Usernamelabel;
    }
}