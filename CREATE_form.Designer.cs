namespace SOFTDEV_FINAL_PROJECT
{
    partial class CREATE_form
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
            pictureBox1 = new PictureBox();
            textBoxFullName = new TextBox();
            textBoxAge = new TextBox();
            comboBoxGender = new ComboBox();
            NAME_label = new Label();
            Age_label = new Label();
            Gender_label = new Label();
            Create_button = new Button();
            Username_label = new Label();
            textbox_username = new TextBox();
            password_label = new Label();
            TextboxPassword = new TextBox();
            Return_button = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(228, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(748, 390);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(311, 153);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(183, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(311, 226);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(183, 27);
            textBoxAge.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(311, 294);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(183, 28);
            comboBoxGender.TabIndex = 3;
            // 
            // NAME_label
            // 
            NAME_label.AutoSize = true;
            NAME_label.Location = new Point(311, 130);
            NAME_label.Name = "NAME_label";
            NAME_label.Size = new Size(52, 20);
            NAME_label.TabIndex = 4;
            NAME_label.Text = "Name:";
            // 
            // Age_label
            // 
            Age_label.AutoSize = true;
            Age_label.Location = new Point(311, 192);
            Age_label.Name = "Age_label";
            Age_label.Size = new Size(39, 20);
            Age_label.TabIndex = 5;
            Age_label.Text = "Age:";
            // 
            // Gender_label
            // 
            Gender_label.AutoSize = true;
            Gender_label.Location = new Point(311, 271);
            Gender_label.Name = "Gender_label";
            Gender_label.Size = new Size(60, 20);
            Gender_label.TabIndex = 6;
            Gender_label.Text = "Gender:";
            // 
            // Create_button
            // 
            Create_button.Location = new Point(833, 153);
            Create_button.Name = "Create_button";
            Create_button.Size = new Size(94, 29);
            Create_button.TabIndex = 7;
            Create_button.Text = "CREATE";
            Create_button.UseVisualStyleBackColor = true;
            Create_button.Click += Create_button_Click;
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Location = new Point(577, 130);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(78, 20);
            Username_label.TabIndex = 8;
            Username_label.Text = "Username:";
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(577, 153);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(183, 27);
            textbox_username.TabIndex = 9;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(577, 192);
            password_label.Name = "password_label";
            password_label.Size = new Size(73, 20);
            password_label.TabIndex = 10;
            password_label.Text = "Password:";
            // 
            // TextboxPassword
            // 
            TextboxPassword.Location = new Point(577, 226);
            TextboxPassword.Name = "TextboxPassword";
            TextboxPassword.Size = new Size(183, 27);
            TextboxPassword.TabIndex = 11;
            TextboxPassword.TextChanged += TextboxPassword_TextChanged;
            // 
            // Return_button
            // 
            Return_button.Location = new Point(833, 224);
            Return_button.Name = "Return_button";
            Return_button.Size = new Size(94, 29);
            Return_button.TabIndex = 13;
            Return_button.Text = "RETURN";
            Return_button.UseVisualStyleBackColor = true;
            Return_button.Click += Return_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 55);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 14;
            label1.Text = "CREATE USER";
            // 
            // CREATE_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 563);
            Controls.Add(label1);
            Controls.Add(Return_button);
            Controls.Add(TextboxPassword);
            Controls.Add(password_label);
            Controls.Add(textbox_username);
            Controls.Add(Username_label);
            Controls.Add(Create_button);
            Controls.Add(Gender_label);
            Controls.Add(Age_label);
            Controls.Add(NAME_label);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFullName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CREATE_form";
            Text = "CREATE_form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxFullName;
        private TextBox textBoxAge;
        private ComboBox comboBoxGender;
        private Label NAME_label;
        private Label Age_label;
        private Label Gender_label;
        private Button Create_button;
        private Label Username_label;
        private TextBox textbox_username;
        private Label password_label;
        private TextBox TextboxPassword;
        private Button Return_button;
        private Label label1;
    }
}