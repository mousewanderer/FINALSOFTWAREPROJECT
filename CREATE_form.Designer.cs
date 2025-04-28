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
            textBoxFirstName = new TextBox();
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
            textBoxLastname = new TextBox();
            label2 = new Label();
            comboBoxProgram = new ComboBox();
            label3 = new Label();
            labelPasswordError = new Label();
            usernamevalid = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(311, 153);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(183, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(311, 283);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(183, 27);
            textBoxAge.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(302, 357);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(183, 28);
            comboBoxGender.TabIndex = 3;
            comboBoxGender.SelectedIndexChanged += comboBoxProgram_SelectedIndexChanged;
            // 
            // NAME_label
            // 
            NAME_label.AutoSize = true;
            NAME_label.Location = new Point(311, 130);
            NAME_label.Name = "NAME_label";
            NAME_label.Size = new Size(83, 20);
            NAME_label.TabIndex = 4;
            NAME_label.Text = "First Name:";
            // 
            // Age_label
            // 
            Age_label.AutoSize = true;
            Age_label.Location = new Point(311, 260);
            Age_label.Name = "Age_label";
            Age_label.Size = new Size(39, 20);
            Age_label.TabIndex = 5;
            Age_label.Text = "Age:";
            // 
            // Gender_label
            // 
            Gender_label.AutoSize = true;
            Gender_label.Location = new Point(311, 323);
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
            textbox_username.TextChanged += textbox_username_TextChanged;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(577, 309);
            password_label.Name = "password_label";
            password_label.Size = new Size(73, 20);
            password_label.TabIndex = 10;
            password_label.Text = "Password:";
            // 
            // TextboxPassword
            // 
            TextboxPassword.Location = new Point(577, 332);
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
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(311, 226);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(183, 27);
            textBoxLastname.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 203);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 16;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Location = new Point(302, 426);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(183, 28);
            comboBoxProgram.TabIndex = 17;
            comboBoxProgram.SelectedIndexChanged += comboBoxProgram_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 403);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 18;
            label3.Text = "Program:";
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.ForeColor = Color.Red;
            labelPasswordError.Location = new Point(577, 377);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(126, 20);
            labelPasswordError.TabIndex = 19;
            labelPasswordError.Text = "SUGGESTION PAS";
            labelPasswordError.Click += passworderror_Click;
            // 
            // usernamevalid
            // 
            usernamevalid.AutoSize = true;
            usernamevalid.ForeColor = Color.Red;
            usernamevalid.Location = new Point(582, 192);
            usernamevalid.Name = "usernamevalid";
            usernamevalid.Size = new Size(87, 20);
            usernamevalid.TabIndex = 20;
            usernamevalid.Text = "EXIST user?:";
            // 
            // CREATE_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 563);
            Controls.Add(usernamevalid);
            Controls.Add(labelPasswordError);
            Controls.Add(label3);
            Controls.Add(comboBoxProgram);
            Controls.Add(label2);
            Controls.Add(textBoxLastname);
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
            Controls.Add(textBoxFirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CREATE_form";
            Text = "CREATE_form";
            Load += CREATE_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxFirstName;
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
        private TextBox textBoxLastname;
        private Label label2;
        private ComboBox comboBoxProgram;
        private Label label3;
        private Label labelPasswordError;
        private Label usernamevalid;
    }
}