namespace winApp_MiPoli
{
    partial class listarDocentesEliminados
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
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrarList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE DOCENTES ELIMINADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Direccion,
            this.Genero,
            this.Carrera,
            this.Asignatura});
            this.dataGridView1.Location = new System.Drawing.Point(8, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(968, 663);
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
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "CEDULA";
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "DIRECCION";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 150;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "GENERO";
            this.Genero.MinimumWidth = 8;
            this.Genero.Name = "Genero";
            this.Genero.Width = 150;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "CARRERA";
            this.Carrera.MinimumWidth = 8;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 150;
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "ASIGNATURA";
            this.Asignatura.MinimumWidth = 8;
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Width = 150;
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(372, 785);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 5;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // listarDocentesEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 885);
            this.Controls.Add(this.buttonCerrarList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarDocentesEliminados";
            this.Text = "listarDocentesEliminados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.Button buttonCerrarList;
    }
}