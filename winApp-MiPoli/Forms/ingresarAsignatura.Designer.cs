namespace winApp_MiPoli
{
    partial class Asignaturas
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
            this.comboBoxNiveles = new System.Windows.Forms.ComboBox();
            this.labelNivelAsignatura = new System.Windows.Forms.Label();
            this.textNumEstudiantes = new System.Windows.Forms.TextBox();
            this.textFacultad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textCarrera = new System.Windows.Forms.TextBox();
            this.labelNunEstudiantes = new System.Windows.Forms.Label();
            this.labelFacultad = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelCodigoAsignatura = new System.Windows.Forms.Label();
            this.labelNombreAsignatura = new System.Windows.Forms.Label();
            this.buttonGuardarAsignatura = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dtgvAsignatura = new System.Windows.Forms.DataGridView();
            this.panelFormularioAsignatura = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textApellidoDocente = new System.Windows.Forms.TextBox();
            this.labelCodigoDocente = new System.Windows.Forms.Label();
            this.labelNombreADocente = new System.Windows.Forms.Label();
            this.textNombreDocente = new System.Windows.Forms.TextBox();
            this.textCodigoDocente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignatura)).BeginInit();
            this.panelFormularioAsignatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNiveles
            // 
            this.comboBoxNiveles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNiveles.FormattingEnabled = true;
            this.comboBoxNiveles.Location = new System.Drawing.Point(44, 354);
            this.comboBoxNiveles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNiveles.Name = "comboBoxNiveles";
            this.comboBoxNiveles.Size = new System.Drawing.Size(87, 28);
            this.comboBoxNiveles.TabIndex = 27;
            this.comboBoxNiveles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // labelNivelAsignatura
            // 
            this.labelNivelAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNivelAsignatura.AutoSize = true;
            this.labelNivelAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivelAsignatura.Location = new System.Drawing.Point(41, 333);
            this.labelNivelAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNivelAsignatura.Name = "labelNivelAsignatura";
            this.labelNivelAsignatura.Size = new System.Drawing.Size(52, 20);
            this.labelNivelAsignatura.TabIndex = 27;
            this.labelNivelAsignatura.Text = "Nivel:";
            // 
            // textNumEstudiantes
            // 
            this.textNumEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNumEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumEstudiantes.Location = new System.Drawing.Point(145, 354);
            this.textNumEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumEstudiantes.Name = "textNumEstudiantes";
            this.textNumEstudiantes.Size = new System.Drawing.Size(158, 26);
            this.textNumEstudiantes.TabIndex = 28;
            this.textNumEstudiantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // textFacultad
            // 
            this.textFacultad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFacultad.Location = new System.Drawing.Point(42, 300);
            this.textFacultad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFacultad.Name = "textFacultad";
            this.textFacultad.Size = new System.Drawing.Size(261, 26);
            this.textFacultad.TabIndex = 26;
            this.textFacultad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // textNombre
            // 
            this.textNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(42, 188);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(261, 26);
            this.textNombre.TabIndex = 24;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // textCodigo
            // 
            this.textCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(42, 127);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(261, 26);
            this.textCodigo.TabIndex = 23;
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // textCarrera
            // 
            this.textCarrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCarrera.Location = new System.Drawing.Point(44, 243);
            this.textCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCarrera.Name = "textCarrera";
            this.textCarrera.Size = new System.Drawing.Size(261, 26);
            this.textCarrera.TabIndex = 25;
            this.textCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_keyPress);
            // 
            // labelNunEstudiantes
            // 
            this.labelNunEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNunEstudiantes.AutoSize = true;
            this.labelNunEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNunEstudiantes.Location = new System.Drawing.Point(142, 333);
            this.labelNunEstudiantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNunEstudiantes.Name = "labelNunEstudiantes";
            this.labelNunEstudiantes.Size = new System.Drawing.Size(156, 20);
            this.labelNunEstudiantes.TabIndex = 21;
            this.labelNunEstudiantes.Text = "N° de estudiantes:";
            // 
            // labelFacultad
            // 
            this.labelFacultad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFacultad.AutoSize = true;
            this.labelFacultad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultad.Location = new System.Drawing.Point(41, 280);
            this.labelFacultad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFacultad.Name = "labelFacultad";
            this.labelFacultad.Size = new System.Drawing.Size(84, 20);
            this.labelFacultad.TabIndex = 20;
            this.labelFacultad.Text = "Facultad:";
            // 
            // labelCarrera
            // 
            this.labelCarrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrera.Location = new System.Drawing.Point(41, 222);
            this.labelCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(74, 20);
            this.labelCarrera.TabIndex = 19;
            this.labelCarrera.Text = "Carrera:";
            // 
            // labelCodigoAsignatura
            // 
            this.labelCodigoAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCodigoAsignatura.AutoSize = true;
            this.labelCodigoAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelCodigoAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoAsignatura.Location = new System.Drawing.Point(39, 101);
            this.labelCodigoAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoAsignatura.Name = "labelCodigoAsignatura";
            this.labelCodigoAsignatura.Size = new System.Drawing.Size(160, 20);
            this.labelCodigoAsignatura.TabIndex = 18;
            this.labelCodigoAsignatura.Text = "Codigo asignatura:";
            // 
            // labelNombreAsignatura
            // 
            this.labelNombreAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreAsignatura.AutoSize = true;
            this.labelNombreAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelNombreAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAsignatura.Location = new System.Drawing.Point(41, 162);
            this.labelNombreAsignatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreAsignatura.Name = "labelNombreAsignatura";
            this.labelNombreAsignatura.Size = new System.Drawing.Size(210, 20);
            this.labelNombreAsignatura.TabIndex = 17;
            this.labelNombreAsignatura.Text = "Nombre de la asignatura:";
            // 
            // buttonGuardarAsignatura
            // 
            this.buttonGuardarAsignatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGuardarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(172)))));
            this.buttonGuardarAsignatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarAsignatura.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarAsignatura.Location = new System.Drawing.Point(180, 584);
            this.buttonGuardarAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGuardarAsignatura.Name = "buttonGuardarAsignatura";
            this.buttonGuardarAsignatura.Size = new System.Drawing.Size(122, 37);
            this.buttonGuardarAsignatura.TabIndex = 30;
            this.buttonGuardarAsignatura.Text = "GUARDAR";
            this.buttonGuardarAsignatura.UseVisualStyleBackColor = false;
            this.buttonGuardarAsignatura.Click += new System.EventHandler(this.buttonGuardarAsignatura_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(172)))));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(44, 584);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(122, 37);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dtgvAsignatura
            // 
            this.dtgvAsignatura.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAsignatura.Location = new System.Drawing.Point(11, 12);
            this.dtgvAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvAsignatura.Name = "dtgvAsignatura";
            this.dtgvAsignatura.RowHeadersWidth = 51;
            this.dtgvAsignatura.RowTemplate.Height = 24;
            this.dtgvAsignatura.Size = new System.Drawing.Size(613, 641);
            this.dtgvAsignatura.TabIndex = 31;
            // 
            // panelFormularioAsignatura
            // 
            this.panelFormularioAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelFormularioAsignatura.Controls.Add(this.pictureBox2);
            this.panelFormularioAsignatura.Controls.Add(this.label1);
            this.panelFormularioAsignatura.Controls.Add(this.pictureBox1);
            this.panelFormularioAsignatura.Controls.Add(this.textApellidoDocente);
            this.panelFormularioAsignatura.Controls.Add(this.buttonCancelar);
            this.panelFormularioAsignatura.Controls.Add(this.labelCodigoDocente);
            this.panelFormularioAsignatura.Controls.Add(this.buttonGuardarAsignatura);
            this.panelFormularioAsignatura.Controls.Add(this.labelNombreADocente);
            this.panelFormularioAsignatura.Controls.Add(this.textFacultad);
            this.panelFormularioAsignatura.Controls.Add(this.textNombreDocente);
            this.panelFormularioAsignatura.Controls.Add(this.labelFacultad);
            this.panelFormularioAsignatura.Controls.Add(this.textCodigoDocente);
            this.panelFormularioAsignatura.Controls.Add(this.labelCarrera);
            this.panelFormularioAsignatura.Controls.Add(this.textNumEstudiantes);
            this.panelFormularioAsignatura.Controls.Add(this.comboBoxNiveles);
            this.panelFormularioAsignatura.Controls.Add(this.labelNunEstudiantes);
            this.panelFormularioAsignatura.Controls.Add(this.textNombre);
            this.panelFormularioAsignatura.Controls.Add(this.labelNivelAsignatura);
            this.panelFormularioAsignatura.Controls.Add(this.labelNombreAsignatura);
            this.panelFormularioAsignatura.Controls.Add(this.textCodigo);
            this.panelFormularioAsignatura.Controls.Add(this.textCarrera);
            this.panelFormularioAsignatura.Controls.Add(this.labelCodigoAsignatura);
            this.panelFormularioAsignatura.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFormularioAsignatura.Location = new System.Drawing.Point(0, 0);
            this.panelFormularioAsignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFormularioAsignatura.Name = "panelFormularioAsignatura";
            this.panelFormularioAsignatura.Size = new System.Drawing.Size(356, 665);
            this.panelFormularioAsignatura.TabIndex = 32;
            this.panelFormularioAsignatura.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularioAsignatura_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::winApp_MiPoli.Properties.Resources.professor;
            this.pictureBox2.Location = new System.Drawing.Point(128, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 504);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Apellido del docente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::winApp_MiPoli.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(43, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textApellidoDocente
            // 
            this.textApellidoDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textApellidoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoDocente.Location = new System.Drawing.Point(42, 525);
            this.textApellidoDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textApellidoDocente.Name = "textApellidoDocente";
            this.textApellidoDocente.Size = new System.Drawing.Size(261, 26);
            this.textApellidoDocente.TabIndex = 31;
            // 
            // labelCodigoDocente
            // 
            this.labelCodigoDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCodigoDocente.AutoSize = true;
            this.labelCodigoDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelCodigoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDocente.Location = new System.Drawing.Point(41, 387);
            this.labelCodigoDocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoDocente.Name = "labelCodigoDocente";
            this.labelCodigoDocente.Size = new System.Drawing.Size(140, 20);
            this.labelCodigoDocente.TabIndex = 33;
            this.labelCodigoDocente.Text = "Codigo docente:";
            // 
            // labelNombreADocente
            // 
            this.labelNombreADocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreADocente.AutoSize = true;
            this.labelNombreADocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.labelNombreADocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreADocente.Location = new System.Drawing.Point(39, 447);
            this.labelNombreADocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreADocente.Name = "labelNombreADocente";
            this.labelNombreADocente.Size = new System.Drawing.Size(175, 20);
            this.labelNombreADocente.TabIndex = 32;
            this.labelNombreADocente.Text = "Nombre del docente:";
            // 
            // textNombreDocente
            // 
            this.textNombreDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreDocente.Location = new System.Drawing.Point(44, 467);
            this.textNombreDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombreDocente.Name = "textNombreDocente";
            this.textNombreDocente.Size = new System.Drawing.Size(259, 26);
            this.textNombreDocente.TabIndex = 30;
            // 
            // textCodigoDocente
            // 
            this.textCodigoDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCodigoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoDocente.Location = new System.Drawing.Point(42, 408);
            this.textCodigoDocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCodigoDocente.Name = "textCodigoDocente";
            this.textCodigoDocente.Size = new System.Drawing.Size(261, 26);
            this.textCodigoDocente.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.dtgvAsignatura);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(356, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel2.Size = new System.Drawing.Size(635, 665);
            this.panel2.TabIndex = 34;
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFormularioAsignatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Asignaturas";
            this.Text = "Ingreso de asignatura y docente";
            this.Load += new System.EventHandler(this.nivelesDisponibles);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignatura)).EndInit();
            this.panelFormularioAsignatura.ResumeLayout(false);
            this.panelFormularioAsignatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNiveles;
        private System.Windows.Forms.Label labelNivelAsignatura;
        private System.Windows.Forms.TextBox textNumEstudiantes;
        private System.Windows.Forms.TextBox textFacultad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textCarrera;
        private System.Windows.Forms.Label labelNunEstudiantes;
        private System.Windows.Forms.Label labelFacultad;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelCodigoAsignatura;
        private System.Windows.Forms.Label labelNombreAsignatura;
        private System.Windows.Forms.Button buttonGuardarAsignatura;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dtgvAsignatura;
        private System.Windows.Forms.Panel panelFormularioAsignatura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textApellidoDocente;
        private System.Windows.Forms.Label labelCodigoDocente;
        private System.Windows.Forms.Label labelNombreADocente;
        private System.Windows.Forms.TextBox textNombreDocente;
        private System.Windows.Forms.TextBox textCodigoDocente;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}