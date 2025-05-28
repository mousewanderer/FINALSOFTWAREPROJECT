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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREATE_form));
            textBoxFirstName = new TextBox();
            textBoxAge = new TextBox();
            comboBoxGender = new ComboBox();
            Create_button = new Button();
            textbox_username = new TextBox();
            TextboxPassword = new TextBox();
            Return_button = new Button();
            textBoxLastname = new TextBox();
            comboBoxProgram = new ComboBox();
            labelPasswordError = new Label();
            usernamevalid = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(193, 219, 217);
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxFirstName.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxFirstName.Location = new Point(309, 263);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(183, 30);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxAge
            // 
            textBoxAge.BackColor = Color.FromArgb(193, 219, 217);
            textBoxAge.BorderStyle = BorderStyle.FixedSingle;
            textBoxAge.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxAge.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxAge.Location = new Point(309, 342);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(183, 30);
            textBoxAge.TabIndex = 2;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(193, 219, 217);
            comboBoxGender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            comboBoxGender.ForeColor = Color.FromArgb(40, 122, 116);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(309, 383);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(183, 31);
            comboBoxGender.TabIndex = 3;
            comboBoxGender.SelectedIndexChanged += comboBoxProgram_SelectedIndexChanged;
            comboBoxGender.TextChanged += comboBoxGender_TextChanged;
            comboBoxGender.Leave += comboBoxGender_Leave;
            // 
            // Create_button
            // 
            Create_button.BackColor = Color.FromArgb(193, 219, 217);
            Create_button.FlatStyle = FlatStyle.Popup;
            Create_button.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold);
            Create_button.ForeColor = Color.FromArgb(40, 122, 116);
            Create_button.Location = new Point(628, 464);
            Create_button.Name = "Create_button";
            Create_button.Size = new Size(100, 34);
            Create_button.TabIndex = 7;
            Create_button.Text = "CREATE";
            Create_button.UseVisualStyleBackColor = false;
            Create_button.Click += Create_button_Click;
            // 
            // textbox_username
            // 
            textbox_username.BackColor = Color.FromArgb(193, 219, 217);
            textbox_username.BorderStyle = BorderStyle.FixedSingle;
            textbox_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textbox_username.ForeColor = Color.FromArgb(40, 122, 116);
            textbox_username.Location = new Point(628, 263);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(233, 30);
            textbox_username.TabIndex = 9;
            textbox_username.TextChanged += textbox_username_TextChanged;
            // 
            // TextboxPassword
            // 
            TextboxPassword.BackColor = Color.FromArgb(193, 219, 217);
            TextboxPassword.BorderStyle = BorderStyle.FixedSingle;
            TextboxPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            TextboxPassword.ForeColor = Color.FromArgb(40, 122, 116);
            TextboxPassword.Location = new Point(628, 350);
            TextboxPassword.Name = "TextboxPassword";
            TextboxPassword.Size = new Size(233, 30);
            TextboxPassword.TabIndex = 11;
            TextboxPassword.TextChanged += TextboxPassword_TextChanged;
            // 
            // Return_button
            // 
            Return_button.BackColor = Color.FromArgb(193, 219, 217);
            Return_button.FlatStyle = FlatStyle.Popup;
            Return_button.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold);
            Return_button.ForeColor = Color.FromArgb(40, 122, 116);
            Return_button.Location = new Point(752, 464);
            Return_button.Name = "Return_button";
            Return_button.Size = new Size(102, 34);
            Return_button.TabIndex = 13;
            Return_button.Text = "RETURN";
            Return_button.UseVisualStyleBackColor = false;
            Return_button.Click += Return_button_Click;
            // 
            // textBoxLastname
            // 
            textBoxLastname.BackColor = Color.FromArgb(193, 219, 217);
            textBoxLastname.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxLastname.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxLastname.Location = new Point(309, 306);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(183, 30);
            textBoxLastname.TabIndex = 15;
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.BackColor = Color.FromArgb(193, 219, 217);
            comboBoxProgram.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            comboBoxProgram.ForeColor = Color.FromArgb(40, 122, 116);
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Location = new Point(309, 427);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(183, 31);
            comboBoxProgram.TabIndex = 17;
            comboBoxProgram.SelectedIndexChanged += comboBoxProgram_SelectedIndexChanged;
            comboBoxProgram.TextChanged += comboBoxProgram_TextChanged;
            comboBoxProgram.Click += comboBoxProgram_Click;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.BackColor = Color.Transparent;
            labelPasswordError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPasswordError.ForeColor = Color.Red;
            labelPasswordError.Location = new Point(515, 388);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(143, 17);
            labelPasswordError.TabIndex = 19;
            labelPasswordError.Text = "Please enter password.";
            labelPasswordError.Click += passworderror_Click;
            // 
            // usernamevalid
            // 
            usernamevalid.AutoSize = true;
            usernamevalid.BackColor = Color.Transparent;
            usernamevalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamevalid.ForeColor = Color.Red;
            usernamevalid.Location = new Point(515, 293);
            usernamevalid.Name = "usernamevalid";
            usernamevalid.Size = new Size(143, 17);
            usernamevalid.TabIndex = 20;
            usernamevalid.Text = "Please enter username.";
            // 
            // CREATE_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1005, 563);
            Controls.Add(usernamevalid);
            Controls.Add(labelPasswordError);
            Controls.Add(comboBoxProgram);
            Controls.Add(textBoxLastname);
            Controls.Add(Return_button);
            Controls.Add(TextboxPassword);
            Controls.Add(textbox_username);
            Controls.Add(Create_button);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFirstName);
            DoubleBuffered = true;
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
        private Button Create_button;
        private TextBox textbox_username;
        private TextBox TextboxPassword;
        private Button Return_button;
        private TextBox textBoxLastname;
        private ComboBox comboBoxProgram;
        private Label labelPasswordError;
        private Label usernamevalid;
    }
}