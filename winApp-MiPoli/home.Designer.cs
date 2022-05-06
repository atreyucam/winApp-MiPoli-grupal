namespace winApp_MiPoli
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.siderBarTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAyudaYSoporteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siderBarContainer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonListarDatos_Link = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonEliminarDatos_Link = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIngresoDatos_Link = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menubutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuExt = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonBusqueda_Link = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonEditarDatos_Link = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.siderBarContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // siderBarTimer
            // 
            this.siderBarTimer.Interval = 10;
            this.siderBarTimer.Tick += new System.EventHandler(this.siderBarTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edirToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1869, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // edirToolStripMenuItem
            // 
            this.edirToolStripMenuItem.Name = "edirToolStripMenuItem";
            this.edirToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.edirToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAyudaYSoporteMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abrirAyudaYSoporteMenuItem
            // 
            this.abrirAyudaYSoporteMenuItem.Name = "abrirAyudaYSoporteMenuItem";
            this.abrirAyudaYSoporteMenuItem.Size = new System.Drawing.Size(287, 34);
            this.abrirAyudaYSoporteMenuItem.Text = "Abrir ayuda y soporte";
            this.abrirAyudaYSoporteMenuItem.Click += new System.EventHandler(this.abrirAyudaYSoporteMenuItem_Click);
            // 
            // siderBarContainer
            // 
            this.siderBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.siderBarContainer.Controls.Add(this.panel6);
            this.siderBarContainer.Controls.Add(this.panel5);
            this.siderBarContainer.Controls.Add(this.panel4);
            this.siderBarContainer.Controls.Add(this.panel3);
            this.siderBarContainer.Controls.Add(this.panel1);
            this.siderBarContainer.Controls.Add(this.pictureBox1);
            this.siderBarContainer.Controls.Add(this.Menubutton);
            this.siderBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.siderBarContainer.Location = new System.Drawing.Point(0, 35);
            this.siderBarContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siderBarContainer.MaximumSize = new System.Drawing.Size(382, 0);
            this.siderBarContainer.Name = "siderBarContainer";
            this.siderBarContainer.Size = new System.Drawing.Size(382, 1114);
            this.siderBarContainer.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonListarDatos_Link);
            this.panel5.Location = new System.Drawing.Point(4, 674);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 71);
            this.panel5.TabIndex = 13;
            // 
            // buttonListarDatos_Link
            // 
            this.buttonListarDatos_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListarDatos_Link.FlatAppearance.BorderSize = 0;
            this.buttonListarDatos_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListarDatos_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarDatos_Link.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonListarDatos_Link.Location = new System.Drawing.Point(4, 3);
            this.buttonListarDatos_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListarDatos_Link.Name = "buttonListarDatos_Link";
            this.buttonListarDatos_Link.Size = new System.Drawing.Size(374, 63);
            this.buttonListarDatos_Link.TabIndex = 11;
            this.buttonListarDatos_Link.Text = ">> Listar datos";
            this.buttonListarDatos_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListarDatos_Link.UseVisualStyleBackColor = true;
            this.buttonListarDatos_Link.Click += new System.EventHandler(this.buttonListarDatos_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonEliminarDatos_Link);
            this.panel4.Location = new System.Drawing.Point(4, 520);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 71);
            this.panel4.TabIndex = 13;
            // 
            // buttonEliminarDatos_Link
            // 
            this.buttonEliminarDatos_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarDatos_Link.FlatAppearance.BorderSize = 0;
            this.buttonEliminarDatos_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarDatos_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarDatos_Link.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarDatos_Link.Location = new System.Drawing.Point(4, 5);
            this.buttonEliminarDatos_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEliminarDatos_Link.Name = "buttonEliminarDatos_Link";
            this.buttonEliminarDatos_Link.Size = new System.Drawing.Size(369, 63);
            this.buttonEliminarDatos_Link.TabIndex = 11;
            this.buttonEliminarDatos_Link.Text = ">> Eliminar datos";
            this.buttonEliminarDatos_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarDatos_Link.UseVisualStyleBackColor = true;
            this.buttonEliminarDatos_Link.Click += new System.EventHandler(this.buttonEliminarDatos_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonBusqueda_Link);
            this.panel3.Location = new System.Drawing.Point(4, 443);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 71);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonIngresoDatos_Link);
            this.panel1.Location = new System.Drawing.Point(4, 345);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 88);
            this.panel1.TabIndex = 12;
            // 
            // buttonIngresoDatos_Link
            // 
            this.buttonIngresoDatos_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresoDatos_Link.FlatAppearance.BorderSize = 0;
            this.buttonIngresoDatos_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresoDatos_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresoDatos_Link.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonIngresoDatos_Link.Location = new System.Drawing.Point(4, 5);
            this.buttonIngresoDatos_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIngresoDatos_Link.Name = "buttonIngresoDatos_Link";
            this.buttonIngresoDatos_Link.Size = new System.Drawing.Size(369, 83);
            this.buttonIngresoDatos_Link.TabIndex = 11;
            this.buttonIngresoDatos_Link.Text = ">> Ingreso de asignaturas y docentes";
            this.buttonIngresoDatos_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIngresoDatos_Link.UseVisualStyleBackColor = true;
            this.buttonIngresoDatos_Link.Click += new System.EventHandler(this.buttonIngresoDatos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winApp_MiPoli.Properties.Resources.escudo;
            this.pictureBox1.Location = new System.Drawing.Point(82, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menubutton
            // 
            this.Menubutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menubutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Menubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menubutton.Image = ((System.Drawing.Image)(resources.GetObject("Menubutton.Image")));
            this.Menubutton.Location = new System.Drawing.Point(330, 9);
            this.Menubutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(44, 63);
            this.Menubutton.TabIndex = 3;
            this.Menubutton.UseVisualStyleBackColor = false;
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.menuExt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(382, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1487, 91);
            this.panel2.TabIndex = 6;
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1385, 12);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 43);
            this.homeButton.TabIndex = 6;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(510, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Página de inicio";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuExt
            // 
            this.menuExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuExt.FlatAppearance.BorderSize = 0;
            this.menuExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuExt.Image = ((System.Drawing.Image)(resources.GetObject("menuExt.Image")));
            this.menuExt.Location = new System.Drawing.Point(9, 9);
            this.menuExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuExt.Name = "menuExt";
            this.menuExt.Size = new System.Drawing.Size(46, 52);
            this.menuExt.TabIndex = 2;
            this.menuExt.UseVisualStyleBackColor = true;
            this.menuExt.Click += new System.EventHandler(this.menuExt_Click);
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(382, 126);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1487, 1023);
            this.panelHome.TabIndex = 7;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // buttonBusqueda_Link
            // 
            this.buttonBusqueda_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBusqueda_Link.FlatAppearance.BorderSize = 0;
            this.buttonBusqueda_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusqueda_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusqueda_Link.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBusqueda_Link.Location = new System.Drawing.Point(4, 5);
            this.buttonBusqueda_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBusqueda_Link.Name = "buttonBusqueda_Link";
            this.buttonBusqueda_Link.Size = new System.Drawing.Size(364, 62);
            this.buttonBusqueda_Link.TabIndex = 11;
            this.buttonBusqueda_Link.Text = ">> Busqueda de asignatura";
            this.buttonBusqueda_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBusqueda_Link.UseVisualStyleBackColor = true;
            this.buttonBusqueda_Link.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonEditarDatos_Link);
            this.panel6.Location = new System.Drawing.Point(4, 598);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 71);
            this.panel6.TabIndex = 14;
            // 
            // buttonEditarDatos_Link
            // 
            this.buttonEditarDatos_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarDatos_Link.FlatAppearance.BorderSize = 0;
            this.buttonEditarDatos_Link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarDatos_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarDatos_Link.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditarDatos_Link.Location = new System.Drawing.Point(4, 3);
            this.buttonEditarDatos_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditarDatos_Link.Name = "buttonEditarDatos_Link";
            this.buttonEditarDatos_Link.Size = new System.Drawing.Size(374, 63);
            this.buttonEditarDatos_Link.TabIndex = 11;
            this.buttonEditarDatos_Link.Text = ">> Editar datos";
            this.buttonEditarDatos_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarDatos_Link.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 1149);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.siderBarContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home";
            this.Text = " Mi poli";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.siderBarContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer siderBarTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel siderBarContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Menubutton;
        private System.Windows.Forms.Button menuExt;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonIngresoDatos_Link;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonListarDatos_Link;
        private System.Windows.Forms.Button buttonEliminarDatos_Link;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirAyudaYSoporteMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonEditarDatos_Link;
        private System.Windows.Forms.Button buttonBusqueda_Link;
    }
}

