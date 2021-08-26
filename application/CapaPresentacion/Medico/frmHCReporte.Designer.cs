namespace MediTurno.CapaPresentacion.Medico
{
    partial class frmHCReporte
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
            this.ObtenerNombreCompleto_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerFechaActual_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerHistoriasClinicas_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerNombrePaciente_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombreCompleto_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerFechaActual_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerHistoriasClinicas_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombrePaciente_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ObtenerNombreCompleto_ResultBindingSource
            // 
            this.ObtenerNombreCompleto_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerNombreCompleto_Result);
            // 
            // ObtenerFechaActual_ResultBindingSource
            // 
            this.ObtenerFechaActual_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerFechaActual_Result);
            // 
            // ObtenerHistoriasClinicas_ResultBindingSource
            // 
            this.ObtenerHistoriasClinicas_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerHistoriasClinicas_Result);
            // 
            // ObtenerNombrePaciente_ResultBindingSource
            // 
            this.ObtenerNombrePaciente_ResultBindingSource.DataSource = typeof(MediTurno.CapaDatos.ObtenerNombreCompleto_Result);
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
            // rptViewer
            // 
            reportDataSource1.Name = "NombreCompleto";
            reportDataSource1.Value = this.ObtenerNombreCompleto_ResultBindingSource;
            reportDataSource2.Name = "FechaActual";
            reportDataSource2.Value = this.ObtenerFechaActual_ResultBindingSource;
            reportDataSource3.Name = "HistoriasClinicas";
            reportDataSource3.Value = this.ObtenerHistoriasClinicas_ResultBindingSource;
            reportDataSource4.Name = "NombrePaciente";
            reportDataSource4.Value = this.ObtenerNombrePaciente_ResultBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MediTurno.Reportes.rptHistoriaClinica.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(25, 75);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(550, 350);
            this.rptViewer.TabIndex = 7;
            this.rptViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmHCReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmHCReporte";
            this.Text = "frmMedicos";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombreCompleto_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerFechaActual_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerHistoriasClinicas_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerNombrePaciente_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource ObtenerNombreCompleto_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerFechaActual_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerHistoriasClinicas_ResultBindingSource;
        private System.Windows.Forms.BindingSource ObtenerNombrePaciente_ResultBindingSource;
    }
}