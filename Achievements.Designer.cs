namespace SOFTDEV_FINAL_PROJECT
{
    partial class Achievements
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
            textBox1 = new TextBox();
            Firstblood = new PictureBox();
            label1 = new Label();
            PerfectStrike = new PictureBox();
            top100 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Firstblood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PerfectStrike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top100).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 27);
            textBox1.TabIndex = 0;
            // 
            // Firstblood
            // 
            Firstblood.BackColor = Color.Indigo;
            Firstblood.Location = new Point(108, 156);
            Firstblood.Name = "Firstblood";
            Firstblood.Size = new Size(125, 120);
            Firstblood.TabIndex = 1;
            Firstblood.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(333, 60);
            label1.TabIndex = 2;
            label1.Text = "ACHIVEMENTS";
            // 
            // PerfectStrike
            // 
            PerfectStrike.BackColor = Color.DarkKhaki;
            PerfectStrike.Location = new Point(298, 156);
            PerfectStrike.Name = "PerfectStrike";
            PerfectStrike.Size = new Size(125, 120);
            PerfectStrike.TabIndex = 3;
            PerfectStrike.TabStop = false;
            // 
            // top100
            // 
            top100.BackColor = Color.OrangeRed;
            top100.Location = new Point(485, 156);
            top100.Name = "top100";
            top100.Size = new Size(125, 120);
            top100.TabIndex = 4;
            top100.TabStop = false;
            // 
            // Achievements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(top100);
            Controls.Add(PerfectStrike);
            Controls.Add(label1);
            Controls.Add(Firstblood);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Achievements";
            Text = "Achievements";
            Load += Achievements_Load;
            ((System.ComponentModel.ISupportInitialize)Firstblood).EndInit();
            ((System.ComponentModel.ISupportInitialize)PerfectStrike).EndInit();
            ((System.ComponentModel.ISupportInitialize)top100).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox Firstblood;
        private Label label1;
        private PictureBox PerfectStrike;
        private PictureBox top100;
    }
}