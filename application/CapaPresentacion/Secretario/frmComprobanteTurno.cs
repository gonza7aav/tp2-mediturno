using System;
using System.Windows.Forms;
using MediTurno.CapaDatos;
using MediTurno.Entidades;
using Microsoft.Reporting.WinForms;

namespace MediTurno.CapaPresentacion.Secretario
{
    public partial class frmComprobanteTurno : Form
    {
        private frmPrincipal Padre;

        public frmComprobanteTurno(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmEstadisticas_Load(object sender, System.EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                ObtenerFechaActual_ResultBindingSource.DataSource = db.ObtenerFechaActual();
                ObtenerUltimoTurno_ResultBindingSource.DataSource = db.ObtenerUltimoTurno();
                this.rptViewer.RefreshReport();
            }
            rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
            rptViewer.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
