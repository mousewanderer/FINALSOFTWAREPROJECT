namespace SOFTDEV_FINAL_PROJECT
{
    partial class RANKING
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
            TOP5 = new Label();
            SuspendLayout();
            // 
            // TOP5
            // 
            TOP5.AutoSize = true;
            TOP5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TOP5.Location = new Point(45, 28);
            TOP5.Name = "TOP5";
            TOP5.Size = new Size(342, 46);
            TOP5.TabIndex = 0;
            TOP5.Text = "TOP 5 Highest SCORE";
            // 
            // RANKING
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(TOP5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RANKING";
            Text = "RANKING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TOP5;
    }
}