namespace MediTurno.CapaPresentacion.Gerente
{
    partial class frmEstadisticas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ObtenerPeriodo_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerNombreCompleto_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerCantidadEspecialidades_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerMedicosSolicitados_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerCantidadObrasSociales_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.picFiltrar = new System.Windows.Forms.PictureBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerPeriodo_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombreCompleto_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerMedicosSolicitados_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerCantidadEspecialidades_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerCantidadObrasSociales_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // ObtenerPeriodo_ResultBindingSource
            // 
            this.ObtenerPeriodo_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerPeriodo_Result);
            // 
            // ObtenerNombreCompleto_ResultBindingSource
            // 
            this.ObtenerNombreCompleto_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerNombreCompleto_Result);
            // 
            // ObtenerCantidadEspecialidades_ResultBindingSource
            // 
            this.ObtenerCantidadEspecialidades_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerCantidadEspecialidades_Result);
            // 
            // ObtenerMedicosSolicitados_ResultBindingSource
            // 
            this.ObtenerMedicosSolicitados_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerMedicosSolicitados_Result);
            // 
            // ObtenerCantidadObrasSociales_ResultBindingSource
            // 
            this.ObtenerCantidadObrasSociales_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerCantidadObrasSociales_Result);
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
            this.lblTitulo.Size = new System.Drawing.Size(126, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Estadisticas";
            // 
            // rptViewer
            // 
            reportDataSource1.Name = "Periodo";
            reportDataSource1.Value = this.ObtenerPeriodo_ResultBindingSource;
            reportDataSource2.Name = "NombreCompleto";
            reportDataSource2.Value = this.ObtenerNombreCompleto_ResultBindingSource;
            reportDataSource3.Name = "CantidadEspecialidades";
            reportDataSource3.Value = this.ObtenerCantidadEspecialidades_ResultBindingSource;
            reportDataSource4.Name = "MedicosSolicitados";
            reportDataSource4.Value = this.ObtenerMedicosSolicitados_ResultBindingSource;
            reportDataSource5.Name = "CantidadObrasSociales";
            reportDataSource5.Value = this.ObtenerCantidadObrasSociales_ResultBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MediTurno.Reportes.rptEstadisticas.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(25, 75);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(550, 300);
            this.rptViewer.TabIndex = 7;
            this.rptViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
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
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.picFiltrar);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmEstadisticas";
            this.Text = "frmMedicos";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerPeriodo_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombreCompleto_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerCantidadEspecialidades_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerMedicosSolicitados_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerCantidadObrasSociales_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFiltrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource ObtenerPeriodo_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerNombreCompleto_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerCantidadEspecialidades_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerMedicosSolicitados_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerCantidadObrasSociales_ResultBindingSource;
        private System.Windows.Forms.PictureBox picFiltrar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}