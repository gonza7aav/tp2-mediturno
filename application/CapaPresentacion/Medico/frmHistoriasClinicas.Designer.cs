namespace MediTurno.CapaPresentacion.Medico
{
    partial class frmHistoriasClinicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdTurnos = new System.Windows.Forms.DataGridView();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExisteHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picNuevo = new System.Windows.Forms.PictureBox();
            this.picFiltrar = new System.Windows.Forms.PictureBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.picImprimir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).BeginInit();
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
            this.lblTitulo.Size = new System.Drawing.Size(153, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Historia Clinica";
            // 
            // grdTurnos
            // 
            this.grdTurnos.AllowUserToAddRows = false;
            this.grdTurnos.AllowUserToDeleteRows = false;
            this.grdTurnos.AllowUserToResizeColumns = false;
            this.grdTurnos.AllowUserToResizeRows = false;
            this.grdTurnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver,
            this.Id,
            this.Medico,
            this.Paciente,
            this.Fecha,
            this.Hora,
            this.Cobertura,
            this.ExisteHC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTurnos.Location = new System.Drawing.Point(25, 75);
            this.grdTurnos.MultiSelect = false;
            this.grdTurnos.Name = "grdTurnos";
            this.grdTurnos.RowHeadersVisible = false;
            this.grdTurnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTurnos.Size = new System.Drawing.Size(550, 300);
            this.grdTurnos.TabIndex = 15;
            this.grdTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTurnos_CellClick);
            // 
            // Ver
            // 
            this.Ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ver.Frozen = true;
            this.Ver.HeaderText = "Ver";
            this.Ver.Image = global::MediTurno.Properties.Resources.blank;
            this.Ver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ver.Width = 38;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Medico
            // 
            this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Medico.Width = 86;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Paciente.Width = 95;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 58;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hora.Width = 49;
            // 
            // Cobertura
            // 
            this.Cobertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cobertura.HeaderText = "Cobertura";
            this.Cobertura.Name = "Cobertura";
            this.Cobertura.ReadOnly = true;
            this.Cobertura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cobertura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cobertura.Width = 84;
            // 
            // ExisteHC
            // 
            this.ExisteHC.HeaderText = "ExisteHC";
            this.ExisteHC.Name = "ExisteHC";
            this.ExisteHC.ReadOnly = true;
            this.ExisteHC.Visible = false;
            // 
            // picNuevo
            // 
            this.picNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picNuevo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picNuevo.Image = global::MediTurno.Properties.Resources.feather_plus;
            this.picNuevo.InitialImage = null;
            this.picNuevo.Location = new System.Drawing.Point(549, 25);
            this.picNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.picNuevo.Name = "picNuevo";
            this.picNuevo.Size = new System.Drawing.Size(26, 26);
            this.picNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNuevo.TabIndex = 16;
            this.picNuevo.TabStop = false;
            this.picNuevo.Click += new System.EventHandler(this.picNuevoIcono_Click);
            this.picNuevo.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picNuevo.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // picFiltrar
            // 
            this.picFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picFiltrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picFiltrar.Image = global::MediTurno.Properties.Resources.feather_filter;
            this.picFiltrar.InitialImage = null;
            this.picFiltrar.Location = new System.Drawing.Point(549, 400);
            this.picFiltrar.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.picFiltrar.Name = "picFiltrar";
            this.picFiltrar.Size = new System.Drawing.Size(26, 26);
            this.picFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFiltrar.TabIndex = 23;
            this.picFiltrar.TabStop = false;
            this.picFiltrar.Click += new System.EventHandler(this.picFiltrar_Click);
            this.picFiltrar.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picFiltrar.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHasta.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(315, 400);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(72, 25);
            this.lblHasta.TabIndex = 27;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarForeColor = System.Drawing.Color.White;
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtpHasta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.dtpHasta.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dtpHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.dtpHasta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpHasta.CustomFormat = "dd\' / \'MM\' / \'yy";
            this.dtpHasta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(396, 399);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(125, 27);
            this.dtpHasta.TabIndex = 26;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesde.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(81, 401);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(76, 25);
            this.lblDesde.TabIndex = 25;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarForeColor = System.Drawing.Color.White;
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dtpDesde.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.dtpDesde.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dtpDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.dtpDesde.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDesde.CustomFormat = "dd\' / \'MM\' / \'yy";
            this.dtpDesde.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(162, 400);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(125, 27);
            this.dtpDesde.TabIndex = 24;
            // 
            // picImprimir
            // 
            this.picImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.picImprimir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picImprimir.Image = global::MediTurno.Properties.Resources.feather_printer;
            this.picImprimir.InitialImage = null;
            this.picImprimir.Location = new System.Drawing.Point(495, 24);
            this.picImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.picImprimir.Name = "picImprimir";
            this.picImprimir.Size = new System.Drawing.Size(26, 26);
            this.picImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImprimir.TabIndex = 28;
            this.picImprimir.TabStop = false;
            this.picImprimir.Click += new System.EventHandler(this.picImprimir_Click);
            this.picImprimir.MouseEnter += new System.EventHandler(this.picButton_MouseEnter);
            this.picImprimir.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            // 
            // frmHistoriasClinicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.picImprimir);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.picFiltrar);
            this.Controls.Add(this.picNuevo);
            this.Controls.Add(this.grdTurnos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmHistoriasClinicas";
            this.Text = "frmMedicos";
            this.Load += new System.EventHandler(this.frmHistoriasClinicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImprimir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdTurnos;
        private System.Windows.Forms.PictureBox picNuevo;
        private System.Windows.Forms.PictureBox picFiltrar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.PictureBox picImprimir;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExisteHC;
    }
}