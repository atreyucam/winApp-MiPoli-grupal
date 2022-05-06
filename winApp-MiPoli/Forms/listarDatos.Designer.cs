namespace winApp_MiPoli
{
    partial class listarDatos
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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCerrarList = new System.Windows.Forms.Button();
            this.buttonListDocEliminados = new System.Windows.Forms.Button();
            this.buttonListCarreras = new System.Windows.Forms.Button();
            this.buttonListAsigEliminadas = new System.Windows.Forms.Button();
            this.buttonListDocentes = new System.Windows.Forms.Button();
            this.buttonListAsignaturas = new System.Windows.Forms.Button();
            this.contentMain = new System.Windows.Forms.Panel();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contentMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.panelOptions.Controls.Add(this.pictureBox1);
            this.panelOptions.Controls.Add(this.buttonCerrarList);
            this.panelOptions.Controls.Add(this.buttonListDocEliminados);
            this.panelOptions.Controls.Add(this.buttonListCarreras);
            this.panelOptions.Controls.Add(this.buttonListAsigEliminadas);
            this.panelOptions.Controls.Add(this.buttonListDocentes);
            this.panelOptions.Controls.Add(this.buttonListAsignaturas);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(438, 997);
            this.panelOptions.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winApp_MiPoli.Properties.Resources.list;
            this.pictureBox1.Location = new System.Drawing.Point(62, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(111, 880);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 0;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // buttonListDocEliminados
            // 
            this.buttonListDocEliminados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListDocEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonListDocEliminados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDocEliminados.FlatAppearance.BorderSize = 0;
            this.buttonListDocEliminados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDocEliminados.ForeColor = System.Drawing.Color.White;
            this.buttonListDocEliminados.Location = new System.Drawing.Point(62, 695);
            this.buttonListDocEliminados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListDocEliminados.Name = "buttonListDocEliminados";
            this.buttonListDocEliminados.Size = new System.Drawing.Size(290, 80);
            this.buttonListDocEliminados.TabIndex = 4;
            this.buttonListDocEliminados.Text = "Docentes eliminados";
            this.buttonListDocEliminados.UseVisualStyleBackColor = false;
            this.buttonListDocEliminados.Click += new System.EventHandler(this.buttonListDocEliminados_Click);
            // 
            // buttonListCarreras
            // 
            this.buttonListCarreras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonListCarreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListCarreras.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonListCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListCarreras.ForeColor = System.Drawing.Color.White;
            this.buttonListCarreras.Location = new System.Drawing.Point(62, 272);
            this.buttonListCarreras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListCarreras.Name = "buttonListCarreras";
            this.buttonListCarreras.Size = new System.Drawing.Size(290, 80);
            this.buttonListCarreras.TabIndex = 0;
            this.buttonListCarreras.Text = "Carreras";
            this.buttonListCarreras.UseVisualStyleBackColor = false;
            this.buttonListCarreras.Click += new System.EventHandler(this.buttonListCarreras_Click);
            // 
            // buttonListAsigEliminadas
            // 
            this.buttonListAsigEliminadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListAsigEliminadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonListAsigEliminadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListAsigEliminadas.FlatAppearance.BorderSize = 0;
            this.buttonListAsigEliminadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAsigEliminadas.ForeColor = System.Drawing.Color.White;
            this.buttonListAsigEliminadas.Location = new System.Drawing.Point(62, 594);
            this.buttonListAsigEliminadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListAsigEliminadas.Name = "buttonListAsigEliminadas";
            this.buttonListAsigEliminadas.Size = new System.Drawing.Size(290, 80);
            this.buttonListAsigEliminadas.TabIndex = 1;
            this.buttonListAsigEliminadas.Text = "Asignaturas eliminadas";
            this.buttonListAsigEliminadas.UseVisualStyleBackColor = false;
            this.buttonListAsigEliminadas.Click += new System.EventHandler(this.buttonListAsigEliminadas_Click);
            // 
            // buttonListDocentes
            // 
            this.buttonListDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonListDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDocentes.FlatAppearance.BorderSize = 0;
            this.buttonListDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDocentes.ForeColor = System.Drawing.Color.White;
            this.buttonListDocentes.Location = new System.Drawing.Point(62, 492);
            this.buttonListDocentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListDocentes.Name = "buttonListDocentes";
            this.buttonListDocentes.Size = new System.Drawing.Size(290, 80);
            this.buttonListDocentes.TabIndex = 3;
            this.buttonListDocentes.Text = "Docentes";
            this.buttonListDocentes.UseVisualStyleBackColor = false;
            this.buttonListDocentes.Click += new System.EventHandler(this.buttonListDocentes_Click);
            // 
            // buttonListAsignaturas
            // 
            this.buttonListAsignaturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonListAsignaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListAsignaturas.FlatAppearance.BorderSize = 0;
            this.buttonListAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListAsignaturas.ForeColor = System.Drawing.Color.White;
            this.buttonListAsignaturas.Location = new System.Drawing.Point(62, 385);
            this.buttonListAsignaturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListAsignaturas.Name = "buttonListAsignaturas";
            this.buttonListAsignaturas.Size = new System.Drawing.Size(290, 80);
            this.buttonListAsignaturas.TabIndex = 2;
            this.buttonListAsignaturas.Text = "Asignaturas";
            this.buttonListAsignaturas.UseVisualStyleBackColor = false;
            this.buttonListAsignaturas.Click += new System.EventHandler(this.buttonListAsignaturas_Click);
            // 
            // contentMain
            // 
            this.contentMain.BackColor = System.Drawing.Color.White;
            this.contentMain.Controls.Add(this.dt1);
            this.contentMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentMain.Location = new System.Drawing.Point(438, 0);
            this.contentMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentMain.Name = "contentMain";
            this.contentMain.Size = new System.Drawing.Size(1028, 997);
            this.contentMain.TabIndex = 2;
            this.contentMain.Paint += new System.Windows.Forms.PaintEventHandler(this.contentMain_Paint);
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(15, 46);
            this.dt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt1.Name = "dt1";
            this.dt1.RowHeadersWidth = 62;
            this.dt1.Size = new System.Drawing.Size(1000, 795);
            this.dt1.TabIndex = 2;
            // 
            // listarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 997);
            this.Controls.Add(this.contentMain);
            this.Controls.Add(this.panelOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "listarDatos";
            this.Text = "Listar datos";
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contentMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel contentMain;
        private System.Windows.Forms.Button buttonListDocEliminados;
        private System.Windows.Forms.Button buttonListCarreras;
        private System.Windows.Forms.Button buttonListAsigEliminadas;
        private System.Windows.Forms.Button buttonListDocentes;
        private System.Windows.Forms.Button buttonListAsignaturas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCerrarList;
        private System.Windows.Forms.DataGridView dt1;
    }
}