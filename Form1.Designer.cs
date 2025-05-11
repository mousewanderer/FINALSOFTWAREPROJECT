namespace SOFTDEV_FINAL_PROJECT
{
    partial class LOGINFORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            LABELUSERNAME = new Label();
            PASSWORDLABEL = new Label();
            textBoxPassword = new TextBox();
            buttonCREATE = new Button();
            buttonLogin = new Button();
            buttonexit = new Button();
            forgotpassword = new LinkLabel();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(575, 256);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // LABELUSERNAME
            // 
            LABELUSERNAME.AutoSize = true;
            LABELUSERNAME.BackColor = Color.Transparent;
            LABELUSERNAME.Font = new Font("Segoe UI", 12F);
            LABELUSERNAME.Location = new Point(450, 252);
            LABELUSERNAME.Name = "LABELUSERNAME";
            LABELUSERNAME.Size = new Size(108, 28);
            LABELUSERNAME.TabIndex = 4;
            LABELUSERNAME.Text = "Username :";
            // 
            // PASSWORDLABEL
            // 
            PASSWORDLABEL.AutoSize = true;
            PASSWORDLABEL.BackColor = Color.Transparent;
            PASSWORDLABEL.Font = new Font("Segoe UI", 12F);
            PASSWORDLABEL.Location = new Point(456, 307);
            PASSWORDLABEL.Name = "PASSWORDLABEL";
            PASSWORDLABEL.Size = new Size(102, 28);
            PASSWORDLABEL.TabIndex = 5;
            PASSWORDLABEL.Text = "Password :";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(575, 311);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(203, 27);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonCREATE
            // 
            buttonCREATE.Location = new Point(591, 364);
            buttonCREATE.Name = "buttonCREATE";
            buttonCREATE.Size = new Size(94, 29);
            buttonCREATE.TabIndex = 7;
            buttonCREATE.Text = "CREATE";
            buttonCREATE.UseVisualStyleBackColor = true;
            buttonCREATE.Click += buttonCREATE_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(464, 364);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonexit
            // 
            buttonexit.BackColor = Color.Red;
            buttonexit.FlatStyle = FlatStyle.Flat;
            buttonexit.ForeColor = SystemColors.ButtonHighlight;
            buttonexit.Location = new Point(1149, 12);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(41, 29);
            buttonexit.TabIndex = 10;
            buttonexit.Text = "X";
            buttonexit.UseVisualStyleBackColor = false;
            buttonexit.Click += buttonexit_Click;
            // 
            // forgotpassword
            // 
            forgotpassword.AutoSize = true;
            forgotpassword.Location = new Point(515, 409);
            forgotpassword.Name = "forgotpassword";
            forgotpassword.Size = new Size(120, 20);
            forgotpassword.TabIndex = 9;
            forgotpassword.TabStop = true;
            forgotpassword.Text = "Forgot password";
            // 
            // LOGINFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Green_Modern_Business_Opportunity_Presentation;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1202, 576);
            Controls.Add(buttonexit);
            Controls.Add(forgotpassword);
            Controls.Add(buttonLogin);
            Controls.Add(buttonCREATE);
            Controls.Add(textBoxPassword);
            Controls.Add(PASSWORDLABEL);
            Controls.Add(LABELUSERNAME);
            Controls.Add(textBoxUsername);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGINFORM";
            Text = "LOGINFORM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUsername;
        private Label LABELUSERNAME;
        private Label PASSWORDLABEL;
        private TextBox textBoxPassword;
        private Button buttonCREATE;
        private Button buttonLogin;
        private Button buttonexit;
        private LinkLabel forgotpassword;
    }
}
