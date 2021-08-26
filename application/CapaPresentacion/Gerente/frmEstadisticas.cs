using System;
using System.Windows.Forms;
using MediTurno.CapaDatos;
using Microsoft.Reporting.WinForms;

namespace MediTurno.CapaPresentacion.Gerente
{
    public partial class frmEstadisticas : Form
    {
        private frmPrincipal Padre;

        public frmEstadisticas(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;
        }

        private void frmEstadisticas_Load(object sender, System.EventArgs e)
        {
            CargarReporte();
        }

        private void picFiltrar_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) < 0)
            {
                CargarReporte();
            }
            else
            {
                MessageBox.Show(
                    "El intervalo elegido es invalido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CargarReporte()
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                ObtenerPeriodo_ResultBindingSource.DataSource = db.ObtenerPeriodo(desde, hasta);
                ObtenerNombreCompleto_ResultBindingSource.DataSource = db.ObtenerNombreCompleto(Padre.Sesion.Persona.Id);
                ObtenerCantidadEspecialidades_ResultBindingSource.DataSource = db.ObtenerCantidadEspecialidades(desde, hasta);
                ObtenerMedicosSolicitados_ResultBindingSource.DataSource = db.ObtenerMedicosSolicitados(desde, hasta, 5);
                ObtenerCantidadObrasSociales_ResultBindingSource.DataSource = db.ObtenerCantidadObrasSociales(desde, hasta);
                this.rptViewer.RefreshReport();
            }
            rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
            rptViewer.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
