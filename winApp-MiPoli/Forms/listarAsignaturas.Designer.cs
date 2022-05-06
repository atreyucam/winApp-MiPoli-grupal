namespace winApp_MiPoli
{
    partial class listarAsignaturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListAsignatura = new System.Windows.Forms.DataGridView();
            this.CodigoAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEstudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrarList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAsignatura)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE ASIGNATURAS";
            // 
            // dataGridViewListAsignatura
            // 
            this.dataGridViewListAsignatura.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAsignatura,
            this.NombreAsignatura,
            this.Carrera,
            this.Facultad,
            this.Nivel,
            this.NumEstudiantes,
            this.codDocente,
            this.nombreDocente,
            this.apellidoDocente});
            this.dataGridViewListAsignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListAsignatura.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridViewListAsignatura.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewListAsignatura.Name = "dataGridViewListAsignatura";
            this.dataGridViewListAsignatura.RowHeadersWidth = 62;
            this.dataGridViewListAsignatura.Size = new System.Drawing.Size(984, 685);
            this.dataGridViewListAsignatura.TabIndex = 2;
            // 
            // CodigoAsignatura
            // 
            this.CodigoAsignatura.HeaderText = "Codigo Asignatura";
            this.CodigoAsignatura.MinimumWidth = 8;
            this.CodigoAsignatura.Name = "CodigoAsignatura";
            this.CodigoAsignatura.Width = 150;
            // 
            // NombreAsignatura
            // 
            this.NombreAsignatura.HeaderText = "NombreAsignatura";
            this.NombreAsignatura.MinimumWidth = 8;
            this.NombreAsignatura.Name = "NombreAsignatura";
            this.NombreAsignatura.Width = 150;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 8;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 150;
            // 
            // Facultad
            // 
            this.Facultad.HeaderText = "Facultad";
            this.Facultad.MinimumWidth = 8;
            this.Facultad.Name = "Facultad";
            this.Facultad.Width = 150;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 8;
            this.Nivel.Name = "Nivel";
            this.Nivel.Width = 150;
            // 
            // NumEstudiantes
            // 
            this.NumEstudiantes.HeaderText = "N° de estudiantes";
            this.NumEstudiantes.MinimumWidth = 8;
            this.NumEstudiantes.Name = "NumEstudiantes";
            this.NumEstudiantes.Width = 150;
            // 
            // codDocente
            // 
            this.codDocente.HeaderText = "Codigo docente";
            this.codDocente.MinimumWidth = 8;
            this.codDocente.Name = "codDocente";
            this.codDocente.Width = 150;
            // 
            // nombreDocente
            // 
            this.nombreDocente.HeaderText = "nombre docente";
            this.nombreDocente.MinimumWidth = 8;
            this.nombreDocente.Name = "nombreDocente";
            this.nombreDocente.Width = 150;
            // 
            // apellidoDocente
            // 
            this.apellidoDocente.HeaderText = "Apellido docente";
            this.apellidoDocente.MinimumWidth = 8;
            this.apellidoDocente.Name = "apellidoDocente";
            this.apellidoDocente.Width = 150;
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(409, 17);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 5;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCerrarList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 785);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewListAsignatura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 685);
            this.panel3.TabIndex = 8;
            // 
            // listarAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 885);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarAsignaturas";
            this.Text = "listarAsignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAsignatura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListAsignatura;
        private System.Windows.Forms.Button buttonCerrarList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDocente;
    }
}