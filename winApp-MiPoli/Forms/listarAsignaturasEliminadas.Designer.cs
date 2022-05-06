namespace winApp_MiPoli
{
    partial class listarAsignaturasEliminadas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrarList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE ASIGNATURAS ELIMINADAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Carrera,
            this.Facultad,
            this.Nivel,
            this.Estudiantes});
            this.dataGridView1.Location = new System.Drawing.Point(13, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(968, 692);
            this.dataGridView1.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "CARRERA";
            this.Carrera.MinimumWidth = 8;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 150;
            // 
            // Facultad
            // 
            this.Facultad.HeaderText = "FACULTAD";
            this.Facultad.MinimumWidth = 8;
            this.Facultad.Name = "Facultad";
            this.Facultad.Width = 150;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "NIVEL";
            this.Nivel.MinimumWidth = 8;
            this.Nivel.Name = "Nivel";
            this.Nivel.Width = 150;
            // 
            // Estudiantes
            // 
            this.Estudiantes.HeaderText = "N° DE ESTUDIANTES";
            this.Estudiantes.MinimumWidth = 8;
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Width = 150;
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(398, 822);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 5;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // listarAsignaturasEliminadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 941);
            this.Controls.Add(this.buttonCerrarList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarAsignaturasEliminadas";
            this.Text = "listarAsignaturasEliminadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiantes;
        private System.Windows.Forms.Button buttonCerrarList;
    }
}