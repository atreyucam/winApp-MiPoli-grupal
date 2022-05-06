namespace winApp_MiPoli
{
    partial class listarDocentes
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
            this.dataGridViewDocente = new System.Windows.Forms.DataGridView();
            this.CodigoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignaturaDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrarList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE DOCENTES";
            // 
            // dataGridViewDocente
            // 
            this.dataGridViewDocente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDocente,
            this.Nombre,
            this.Apellido,
            this.CarreraDocente,
            this.AsignaturaDocente});
            this.dataGridViewDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocente.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDocente.Name = "dataGridViewDocente";
            this.dataGridViewDocente.RowHeadersWidth = 62;
            this.dataGridViewDocente.Size = new System.Drawing.Size(1006, 741);
            this.dataGridViewDocente.TabIndex = 2;
            // 
            // CodigoDocente
            // 
            this.CodigoDocente.HeaderText = "Codigo docente";
            this.CodigoDocente.MinimumWidth = 8;
            this.CodigoDocente.Name = "CodigoDocente";
            this.CodigoDocente.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // CarreraDocente
            // 
            this.CarreraDocente.HeaderText = "Carrera";
            this.CarreraDocente.MinimumWidth = 8;
            this.CarreraDocente.Name = "CarreraDocente";
            this.CarreraDocente.Width = 150;
            // 
            // AsignaturaDocente
            // 
            this.AsignaturaDocente.HeaderText = "Asignatura";
            this.AsignaturaDocente.MinimumWidth = 8;
            this.AsignaturaDocente.Name = "AsignaturaDocente";
            this.AsignaturaDocente.Width = 150;
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(420, 8);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 5;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonCerrarList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 841);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewDocente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 741);
            this.panel3.TabIndex = 8;
            // 
            // listarDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 941);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarDocentes";
            this.Text = "listarDocentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDocente;
        private System.Windows.Forms.Button buttonCerrarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignaturaDocente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}