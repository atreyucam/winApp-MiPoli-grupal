namespace winApp_MiPoli
{
    partial class menuHome
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTitle3 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Controls.Add(this.labelTitle3);
            this.panelHome.Controls.Add(this.labelTitle2);
            this.panelHome.Controls.Add(this.labelTitle1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(965, 625);
            this.panelHome.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::winApp_MiPoli.Properties.Resources.graduation;
            this.pictureBox2.Location = new System.Drawing.Point(379, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // labelTitle3
            // 
            this.labelTitle3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle3.AutoSize = true;
            this.labelTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle3.Location = new System.Drawing.Point(184, 193);
            this.labelTitle3.Name = "labelTitle3";
            this.labelTitle3.Size = new System.Drawing.Size(771, 40);
            this.labelTitle3.TabIndex = 5;
            this.labelTitle3.Text = "Escuela Superior Politecnica de Chimborazo";
            this.labelTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle2
            // 
            this.labelTitle2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.Location = new System.Drawing.Point(285, 134);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(473, 55);
            this.labelTitle2.TabIndex = 4;
            this.labelTitle2.Text = "Sistema de carreras";
            this.labelTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle1
            // 
            this.labelTitle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.Location = new System.Drawing.Point(369, 75);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(272, 55);
            this.labelTitle1.TabIndex = 3;
            this.labelTitle1.Text = "Bienvenido\r\n";
            this.labelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 625);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuHome";
            this.Text = "menuHome";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitle3;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.Label labelTitle1;
    }
}