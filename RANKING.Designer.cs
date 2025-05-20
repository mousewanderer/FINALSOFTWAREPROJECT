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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RANKING));
            listViewOverall = new ListView();
            listViewMath = new ListView();
            SuspendLayout();
            // 
            // listViewOverall
            // 
            listViewOverall.Location = new Point(425, 170);
            listViewOverall.Name = "listViewOverall";
            listViewOverall.Size = new Size(350, 345);
            listViewOverall.TabIndex = 1;
            listViewOverall.UseCompatibleStateImageBehavior = false;
            // 
            // listViewMath
            // 
            listViewMath.Location = new Point(33, 170);
            listViewMath.Name = "listViewMath";
            listViewMath.Size = new Size(350, 345);
            listViewMath.TabIndex = 2;
            listViewMath.UseCompatibleStateImageBehavior = false;
            // 
            // RANKING
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 219, 217);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(820, 600);
            Controls.Add(listViewMath);
            Controls.Add(listViewOverall);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RANKING";
            Text = "RANKING";
            Load += RANKING_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewOverall;
        private ListView listViewMath;
    }
}