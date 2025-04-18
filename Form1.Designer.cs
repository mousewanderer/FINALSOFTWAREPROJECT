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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBoxUsername = new TextBox();
            LABELUSERNAME = new Label();
            PASSWORDLABEL = new Label();
            textBoxPassword = new TextBox();
            buttonCREATE = new Button();
            buttonLogin = new Button();
            forgotpassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 66);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.Location = new Point(285, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(671, 413);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Location = new Point(313, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(617, 359);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(534, 197);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(203, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // LABELUSERNAME
            // 
            LABELUSERNAME.AutoSize = true;
            LABELUSERNAME.Location = new Point(571, 158);
            LABELUSERNAME.Name = "LABELUSERNAME";
            LABELUSERNAME.Size = new Size(134, 20);
            LABELUSERNAME.TabIndex = 4;
            LABELUSERNAME.Text = "ENTER USERNAME";
            // 
            // PASSWORDLABEL
            // 
            PASSWORDLABEL.AutoSize = true;
            PASSWORDLABEL.Location = new Point(571, 253);
            PASSWORDLABEL.Name = "PASSWORDLABEL";
            PASSWORDLABEL.Size = new Size(135, 20);
            PASSWORDLABEL.TabIndex = 5;
            PASSWORDLABEL.Text = "ENTER PASSWORD";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(534, 300);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(203, 27);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCREATE
            // 
            buttonCREATE.Location = new Point(482, 353);
            buttonCREATE.Name = "buttonCREATE";
            buttonCREATE.Size = new Size(94, 29);
            buttonCREATE.TabIndex = 7;
            buttonCREATE.Text = "CREATE";
            buttonCREATE.UseVisualStyleBackColor = true;
            buttonCREATE.Click += buttonCREATE_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(663, 353);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // forgotpassword
            // 
            forgotpassword.AutoSize = true;
            forgotpassword.Location = new Point(571, 397);
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
            ClientSize = new Size(1202, 533);
            Controls.Add(forgotpassword);
            Controls.Add(buttonLogin);
            Controls.Add(buttonCREATE);
            Controls.Add(textBoxPassword);
            Controls.Add(PASSWORDLABEL);
            Controls.Add(LABELUSERNAME);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LOGINFORM";
            Text = "LOGINFORM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBoxUsername;
        private Label LABELUSERNAME;
        private Label PASSWORDLABEL;
        private TextBox textBoxPassword;
        private Button buttonCREATE;
        private Button buttonLogin;
        private LinkLabel forgotpassword;
    }
}
