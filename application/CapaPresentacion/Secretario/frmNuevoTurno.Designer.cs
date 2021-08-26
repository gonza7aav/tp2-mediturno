namespace MediTurno.CapaPresentacion.Secretario
{
    partial class frmNuevoTurno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errNuevoTurno = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBuscarMedico = new System.Windows.Forms.PictureBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.picBuscarPaciente = new System.Windows.Forms.PictureBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.grdBusqueda = new System.Windows.Forms.DataGridView();
            this.IdB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTurnoEstado = new System.Windows.Forms.ComboBox();
            this.lblTurnoEstado = new System.Windows.Forms.Label();
            this.pnlBusqueda2 = new System.Windows.Forms.Panel();
            this.grdBusqueda2 = new System.Windows.Forms.DataGridView();
            this.IdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBuscarCobertura = new System.Windows.Forms.PictureBox();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errNuevoTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarPaciente)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            this.pnlBusqueda2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusqueda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarCobertura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Nuevo Turno";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedico.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.White;
            this.lblMedico.Location = new System.Drawing.Point(50, 50);
            this.lblMedico.Margin = new System.Windows.Forms.Padding(5);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(81, 25);
            this.lblMedico.TabIndex = 9;
            this.lblMedico.Text = "Medico";
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedico.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.ForeColor = System.Drawing.Color.White;
            this.txtMedico.Location = new System.Drawing.Point(55, 80);
            this.txtMedico.Margin = new System.Windows.Forms.Padding(0);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(174, 26);
            this.txtMedico.TabIndex = 8;
            this.txtMedico.TextChanged += new System.EventHandler(this.txtMedico_TextChanged);
            this.txtMedico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedico_KeyDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(466, 18);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 40);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errNuevoTurno
            // 
            this.errNuevoTurno.BlinkRate = 0;
            this.errNuevoTurno.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errNuevoTurno.ContainerControl = this;
            // 
            // picBuscarMedico
            // 
            this.picBuscarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picBuscarMedico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBuscarMedico.Image = global::MediTurno.Properties.Resources.feather_search;
            this.picBuscarMedico.InitialImage = null;
            this.picBuscarMedico.Location = new System.Drawing.Point(229, 80);
            this.picBuscarMedico.Margin = new System.Windows.Forms.Padding(0);
            this.picBuscarMedico.Name = "picBuscarMedico";
            this.picBuscarMedico.Size = new System.Drawing.Size(26, 26);
            this.picBuscarMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscarMedico.TabIndex = 33;
            this.picBuscarMedico.TabStop = false;
            this.picBuscarMedico.Click += new System.EventHandler(this.picBuscarMedico_Click);
            this.picBuscarMedico.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picBuscarMedico.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPaciente.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.White;
            this.lblPaciente.Location = new System.Drawing.Point(320, 50);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(5);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(93, 25);
            this.lblPaciente.TabIndex = 34;
            this.lblPaciente.Text = "Paciente";
            // 
            // picBuscarPaciente
            // 
            this.picBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBuscarPaciente.Image = global::MediTurno.Properties.Resources.feather_search;
            this.picBuscarPaciente.InitialImage = null;
            this.picBuscarPaciente.Location = new System.Drawing.Point(499, 80);
            this.picBuscarPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.picBuscarPaciente.Name = "picBuscarPaciente";
            this.picBuscarPaciente.Size = new System.Drawing.Size(26, 26);
            this.picBuscarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscarPaciente.TabIndex = 36;
            this.picBuscarPaciente.TabStop = false;
            this.picBuscarPaciente.Click += new System.EventHandler(this.picBuscarPaciente_Click);
            this.picBuscarPaciente.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picBuscarPaciente.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaciente.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.ForeColor = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(325, 80);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(174, 26);
            this.txtPaciente.TabIndex = 35;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            this.txtPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaciente_KeyDown);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.grdBusqueda);
            this.pnlBusqueda.Location = new System.Drawing.Point(466, 371);
            this.pnlBusqueda.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(600, 325);
            this.pnlBusqueda.TabIndex = 37;
            this.pnlBusqueda.Visible = false;
            this.pnlBusqueda.Click += new System.EventHandler(this.pnlBusqueda_Click);
            // 
            // grdBusqueda
            // 
            this.grdBusqueda.AllowUserToAddRows = false;
            this.grdBusqueda.AllowUserToDeleteRows = false;
            this.grdBusqueda.AllowUserToResizeColumns = false;
            this.grdBusqueda.AllowUserToResizeRows = false;
            this.grdBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdB,
            this.Dni,
            this.Apellidos,
            this.Nombres,
            this.Especialidad,
            this.Matricula});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBusqueda.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdBusqueda.Location = new System.Drawing.Point(25, 25);
            this.grdBusqueda.MultiSelect = false;
            this.grdBusqueda.Name = "grdBusqueda";
            this.grdBusqueda.RowHeadersVisible = false;
            this.grdBusqueda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBusqueda.Size = new System.Drawing.Size(550, 275);
            this.grdBusqueda.TabIndex = 16;
            this.grdBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBusqueda_CellDoubleClick);
            // 
            // IdB
            // 
            this.IdB.HeaderText = "IdB";
            this.IdB.Name = "IdB";
            this.IdB.ReadOnly = true;
            this.IdB.Visible = false;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Dni.Width = 41;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Especialidad.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Matricula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Matricula.Visible = false;
            // 
            // dtpDia
            // 
            this.dtpDia.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDia.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtpDia.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.dtpDia.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dtpDia.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.dtpDia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDia.CustomFormat = "dd\' / \'MM\' / \'yy";
            this.dtpDia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDia.Location = new System.Drawing.Point(466, 150);
            this.dtpDia.MinDate = new System.DateTime(2020, 10, 5, 0, 0, 0, 0);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(125, 27);
            this.dtpDia.TabIndex = 39;
            this.dtpDia.ValueChanged += new System.EventHandler(this.dtpDia_ValueChanged);
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCobertura.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobertura.ForeColor = System.Drawing.Color.White;
            this.lblCobertura.Location = new System.Drawing.Point(461, 200);
            this.lblCobertura.Margin = new System.Windows.Forms.Padding(5);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(106, 25);
            this.lblCobertura.TabIndex = 40;
            this.lblCobertura.Text = "Cobertura";
            // 
            // grdAgenda
            // 
            this.grdAgenda.AllowUserToAddRows = false;
            this.grdAgenda.AllowUserToDeleteRows = false;
            this.grdAgenda.AllowUserToResizeColumns = false;
            this.grdAgenda.AllowUserToResizeRows = false;
            this.grdAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horario,
            this.D1,
            this.D2,
            this.D3,
            this.D4,
            this.D5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAgenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdAgenda.Location = new System.Drawing.Point(25, 150);
            this.grdAgenda.MultiSelect = false;
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.RowHeadersVisible = false;
            this.grdAgenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdAgenda.Size = new System.Drawing.Size(428, 275);
            this.grdAgenda.TabIndex = 42;
            this.grdAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgenda_CellClick);
            // 
            // Horario
            // 
            this.Horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Horario.Frozen = true;
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Horario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Horario.Width = 67;
            // 
            // D1
            // 
            this.D1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.D1.HeaderText = "";
            this.D1.Name = "D1";
            this.D1.ReadOnly = true;
            this.D1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D1.Width = 5;
            // 
            // D2
            // 
            this.D2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.D2.HeaderText = "";
            this.D2.Name = "D2";
            this.D2.ReadOnly = true;
            this.D2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D2.Width = 5;
            // 
            // D3
            // 
            this.D3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.D3.HeaderText = "";
            this.D3.Name = "D3";
            this.D3.ReadOnly = true;
            this.D3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D3.Width = 5;
            // 
            // D4
            // 
            this.D4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.D4.HeaderText = "";
            this.D4.Name = "D4";
            this.D4.ReadOnly = true;
            this.D4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D4.Width = 5;
            // 
            // D5
            // 
            this.D5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.D5.HeaderText = "";
            this.D5.Name = "D5";
            this.D5.ReadOnly = true;
            this.D5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D5.Width = 5;
            // 
            // cboTurnoEstado
            // 
            this.cboTurnoEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cboTurnoEstado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurnoEstado.ForeColor = System.Drawing.Color.White;
            this.cboTurnoEstado.FormattingEnabled = true;
            this.cboTurnoEstado.Location = new System.Drawing.Point(466, 316);
            this.cboTurnoEstado.Name = "cboTurnoEstado";
            this.cboTurnoEstado.Size = new System.Drawing.Size(125, 27);
            this.cboTurnoEstado.TabIndex = 44;
            this.cboTurnoEstado.Visible = false;
            // 
            // lblTurnoEstado
            // 
            this.lblTurnoEstado.AutoSize = true;
            this.lblTurnoEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTurnoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurnoEstado.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoEstado.ForeColor = System.Drawing.Color.White;
            this.lblTurnoEstado.Location = new System.Drawing.Point(461, 283);
            this.lblTurnoEstado.Margin = new System.Windows.Forms.Padding(5);
            this.lblTurnoEstado.Name = "lblTurnoEstado";
            this.lblTurnoEstado.Size = new System.Drawing.Size(77, 25);
            this.lblTurnoEstado.TabIndex = 43;
            this.lblTurnoEstado.Text = "Estado";
            this.lblTurnoEstado.Visible = false;
            // 
            // pnlBusqueda2
            // 
            this.pnlBusqueda2.Controls.Add(this.grdBusqueda2);
            this.pnlBusqueda2.Location = new System.Drawing.Point(12, 368);
            this.pnlBusqueda2.Name = "pnlBusqueda2";
            this.pnlBusqueda2.Size = new System.Drawing.Size(453, 325);
            this.pnlBusqueda2.TabIndex = 45;
            this.pnlBusqueda2.Visible = false;
            this.pnlBusqueda2.Click += new System.EventHandler(this.pnlBusqueda2_Click);
            // 
            // grdBusqueda2
            // 
            this.grdBusqueda2.AllowUserToAddRows = false;
            this.grdBusqueda2.AllowUserToDeleteRows = false;
            this.grdBusqueda2.AllowUserToResizeColumns = false;
            this.grdBusqueda2.AllowUserToResizeRows = false;
            this.grdBusqueda2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusqueda2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBusqueda2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusqueda2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdC,
            this.Cobertura,
            this.ObraSocial});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBusqueda2.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBusqueda2.Location = new System.Drawing.Point(25, 25);
            this.grdBusqueda2.MultiSelect = false;
            this.grdBusqueda2.Name = "grdBusqueda2";
            this.grdBusqueda2.RowHeadersVisible = false;
            this.grdBusqueda2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBusqueda2.Size = new System.Drawing.Size(400, 275);
            this.grdBusqueda2.TabIndex = 17;
            this.grdBusqueda2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBusqueda2_CellDoubleClick);
            // 
            // IdC
            // 
            this.IdC.HeaderText = "Id";
            this.IdC.Name = "IdC";
            this.IdC.ReadOnly = true;
            this.IdC.Visible = false;
            // 
            // Cobertura
            // 
            this.Cobertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cobertura.HeaderText = "Cobertura";
            this.Cobertura.Name = "Cobertura";
            this.Cobertura.ReadOnly = true;
            this.Cobertura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ObraSocial
            // 
            this.ObraSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObraSocial.HeaderText = "Obra Social";
            this.ObraSocial.Name = "ObraSocial";
            this.ObraSocial.ReadOnly = true;
            this.ObraSocial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // picBuscarCobertura
            // 
            this.picBuscarCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picBuscarCobertura.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picBuscarCobertura.Image = global::MediTurno.Properties.Resources.feather_search;
            this.picBuscarCobertura.InitialImage = null;
            this.picBuscarCobertura.Location = new System.Drawing.Point(565, 230);
            this.picBuscarCobertura.Margin = new System.Windows.Forms.Padding(0);
            this.picBuscarCobertura.Name = "picBuscarCobertura";
            this.picBuscarCobertura.Size = new System.Drawing.Size(26, 26);
            this.picBuscarCobertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscarCobertura.TabIndex = 46;
            this.picBuscarCobertura.TabStop = false;
            this.picBuscarCobertura.Click += new System.EventHandler(this.picBuscarCobertura_Click);
            this.picBuscarCobertura.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picBuscarCobertura.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // txtCobertura
            // 
            this.txtCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCobertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCobertura.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobertura.ForeColor = System.Drawing.Color.White;
            this.txtCobertura.Location = new System.Drawing.Point(466, 230);
            this.txtCobertura.Margin = new System.Windows.Forms.Padding(0);
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Size = new System.Drawing.Size(99, 26);
            this.txtCobertura.TabIndex = 47;
            this.txtCobertura.TextChanged += new System.EventHandler(this.txtCobertura_TextChanged);
            this.txtCobertura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCobertura_KeyDown);
            // 
            // frmNuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBusqueda2);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.grdAgenda);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.picBuscarPaciente);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.picBuscarMedico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboTurnoEstado);
            this.Controls.Add(this.lblTurnoEstado);
            this.Controls.Add(this.txtCobertura);
            this.Controls.Add(this.picBuscarCobertura);
            this.Controls.Add(this.lblCobertura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoTurno";
            this.Load += new System.EventHandler(this.frmNuevoTurno_Load);
            this.Click += new System.EventHandler(this.frmNuevoTurno_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errNuevoTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarPaciente)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            this.pnlBusqueda2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusqueda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarCobertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errNuevoTurno;
        private System.Windows.Forms.PictureBox picBuscarMedico;
        private System.Windows.Forms.PictureBox picBuscarPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.DataGridView grdAgenda;
        private System.Windows.Forms.DataGridView grdBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D3;
        private System.Windows.Forms.DataGridViewTextBoxColumn D4;
        private System.Windows.Forms.DataGridViewTextBoxColumn D5;
        private System.Windows.Forms.ComboBox cboTurnoEstado;
        private System.Windows.Forms.Label lblTurnoEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.Panel pnlBusqueda2;
        private System.Windows.Forms.DataGridView grdBusqueda2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObraSocial;
        private System.Windows.Forms.TextBox txtCobertura;
        private System.Windows.Forms.PictureBox picBuscarCobertura;
    }
}