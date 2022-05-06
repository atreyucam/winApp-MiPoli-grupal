namespace winApp_MiPoli
{
    partial class listarCarreras
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
            this.buttonCerrarList = new System.Windows.Forms.Button();
            this.dataGridViewcarrera = new System.Windows.Forms.DataGridView();
            this.carreraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultadC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcarrera)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE CARRERAS";
            // 
            // buttonCerrarList
            // 
            this.buttonCerrarList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCerrarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(96)))));
            this.buttonCerrarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarList.ForeColor = System.Drawing.Color.White;
            this.buttonCerrarList.Location = new System.Drawing.Point(419, 17);
            this.buttonCerrarList.Name = "buttonCerrarList";
            this.buttonCerrarList.Size = new System.Drawing.Size(194, 71);
            this.buttonCerrarList.TabIndex = 4;
            this.buttonCerrarList.Text = "Cerrar";
            this.buttonCerrarList.UseVisualStyleBackColor = false;
            this.buttonCerrarList.Click += new System.EventHandler(this.buttonCerrarList_Click);
            // 
            // dataGridViewcarrera
            // 
            this.dataGridViewcarrera.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carreraCo,
            this.FacultadC});
            this.dataGridViewcarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewcarrera.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewcarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewcarrera.Name = "dataGridViewcarrera";
            this.dataGridViewcarrera.RowHeadersWidth = 62;
            this.dataGridViewcarrera.Size = new System.Drawing.Size(1006, 742);
            this.dataGridViewcarrera.TabIndex = 5;
            // 
            // carreraCo
            // 
            this.carreraCo.HeaderText = "Carrera";
            this.carreraCo.MinimumWidth = 8;
            this.carreraCo.Name = "carreraCo";
            this.carreraCo.Width = 150;
            // 
            // FacultadC
            // 
            this.FacultadC.HeaderText = "Facultad";
            this.FacultadC.MinimumWidth = 8;
            this.FacultadC.Name = "FacultadC";
            this.FacultadC.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCerrarList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 842);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewcarrera);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 742);
            this.panel3.TabIndex = 8;
            // 
            // listarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 942);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listarCarreras";
            this.Text = "listarCarreras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcarrera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCerrarList;
        private System.Windows.Forms.DataGridView dataGridViewcarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultadC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}