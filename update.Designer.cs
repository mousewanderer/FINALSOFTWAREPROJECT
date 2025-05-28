namespace SOFTDEV_FINAL_PROJECT
{
    partial class update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            usernamevalid = new Label();
            labelPasswordError = new Label();
            comboBoxProgram = new ComboBox();
            textBoxLastname = new TextBox();
            TextboxPassword = new TextBox();
            textbox_username = new TextBox();
            Create_button = new Button();
            comboBoxGender = new ComboBox();
            textBoxAge = new TextBox();
            textBoxFirstName = new TextBox();
            DELETEBUTTON = new Button();
            SuspendLayout();
            // 
            // usernamevalid
            // 
            usernamevalid.AutoSize = true;
            usernamevalid.BackColor = Color.Transparent;
            usernamevalid.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamevalid.ForeColor = Color.Red;
            usernamevalid.Location = new Point(434, 253);
            usernamevalid.Name = "usernamevalid";
            usernamevalid.Size = new Size(143, 17);
            usernamevalid.TabIndex = 31;
            usernamevalid.Text = "Please enter username.";
            usernamevalid.Click += usernamevalid_Click;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.BackColor = Color.Transparent;
            labelPasswordError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPasswordError.ForeColor = Color.Red;
            labelPasswordError.Location = new Point(434, 367);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(143, 17);
            labelPasswordError.TabIndex = 30;
            labelPasswordError.Text = "Please enter password.";
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.BackColor = Color.FromArgb(193, 219, 217);
            comboBoxProgram.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            comboBoxProgram.ForeColor = Color.FromArgb(40, 122, 116);
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Location = new Point(149, 425);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(183, 31);
            comboBoxProgram.TabIndex = 29;
            // 
            // textBoxLastname
            // 
            textBoxLastname.BackColor = Color.FromArgb(193, 219, 217);
            textBoxLastname.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxLastname.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxLastname.Location = new Point(149, 237);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(183, 30);
            textBoxLastname.TabIndex = 28;
            // 
            // TextboxPassword
            // 
            TextboxPassword.BackColor = Color.FromArgb(193, 219, 217);
            TextboxPassword.BorderStyle = BorderStyle.FixedSingle;
            TextboxPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            TextboxPassword.ForeColor = Color.FromArgb(40, 122, 116);
            TextboxPassword.Location = new Point(434, 334);
            TextboxPassword.Name = "TextboxPassword";
            TextboxPassword.Size = new Size(233, 30);
            TextboxPassword.TabIndex = 26;
            TextboxPassword.TextChanged += TextboxPassword_TextChanged_1;
            // 
            // textbox_username
            // 
            textbox_username.BackColor = Color.FromArgb(193, 219, 217);
            textbox_username.BorderStyle = BorderStyle.FixedSingle;
            textbox_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textbox_username.ForeColor = Color.FromArgb(40, 122, 116);
            textbox_username.Location = new Point(434, 220);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(233, 30);
            textbox_username.TabIndex = 25;
            textbox_username.TextChanged += textbox_username_TextChanged_1;
            // 
            // Create_button
            // 
            Create_button.BackColor = Color.FromArgb(193, 219, 217);
            Create_button.FlatStyle = FlatStyle.Popup;
            Create_button.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold);
            Create_button.ForeColor = Color.FromArgb(40, 122, 116);
            Create_button.Location = new Point(518, 464);
            Create_button.Name = "Create_button";
            Create_button.Size = new Size(100, 34);
            Create_button.TabIndex = 24;
            Create_button.Text = "UPDATE";
            Create_button.UseVisualStyleBackColor = false;
            Create_button.Click += Create_button_Click_1;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(193, 219, 217);
            comboBoxGender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            comboBoxGender.ForeColor = Color.FromArgb(40, 122, 116);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(149, 360);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(183, 31);
            comboBoxGender.TabIndex = 23;
            comboBoxGender.TextChanged += comboBoxGender_TextChanged_1;
            // 
            // textBoxAge
            // 
            textBoxAge.BackColor = Color.FromArgb(193, 219, 217);
            textBoxAge.BorderStyle = BorderStyle.FixedSingle;
            textBoxAge.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxAge.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxAge.Location = new Point(149, 295);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(183, 30);
            textBoxAge.TabIndex = 22;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(193, 219, 217);
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBoxFirstName.ForeColor = Color.FromArgb(40, 122, 116);
            textBoxFirstName.Location = new Point(149, 175);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(183, 30);
            textBoxFirstName.TabIndex = 21;
            // 
            // DELETEBUTTON
            // 
            DELETEBUTTON.BackColor = Color.FromArgb(193, 219, 217);
            DELETEBUTTON.FlatStyle = FlatStyle.Popup;
            DELETEBUTTON.Font = new Font("Perpetua Titling MT", 7.8F, FontStyle.Bold);
            DELETEBUTTON.ForeColor = Color.FromArgb(40, 122, 116);
            DELETEBUTTON.Location = new Point(638, 464);
            DELETEBUTTON.Name = "DELETEBUTTON";
            DELETEBUTTON.Size = new Size(100, 34);
            DELETEBUTTON.TabIndex = 32;
            DELETEBUTTON.Text = "DELETE";
            DELETEBUTTON.UseVisualStyleBackColor = false;
            DELETEBUTTON.Click += DELETEBUTTON_Click;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(820, 600);
            Controls.Add(DELETEBUTTON);
            Controls.Add(usernamevalid);
            Controls.Add(labelPasswordError);
            Controls.Add(comboBoxProgram);
            Controls.Add(textBoxLastname);
            Controls.Add(TextboxPassword);
            Controls.Add(textbox_username);
            Controls.Add(Create_button);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFirstName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "update";
            Text = "update";
            Load += update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernamevalid;
        private Label labelPasswordError;
        private ComboBox comboBoxProgram;
        private TextBox textBoxLastname;
        private TextBox TextboxPassword;
        private TextBox textbox_username;
        private Button Create_button;
        private ComboBox comboBoxGender;
        private TextBox textBoxAge;
        private TextBox textBoxFirstName;
        private Button DELETEBUTTON;
    }
}