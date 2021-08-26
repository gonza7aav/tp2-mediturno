using System;
using System.Windows.Forms;
using MediTurno.CapaDatos;
using MediTurno.Entidades;
using Microsoft.Reporting.WinForms;

namespace MediTurno.CapaPresentacion.Medico
{
    public partial class frmHCReporte : Form
    {
        private frmPrincipal Padre;
        private PacienteDTO Paciente;

        public frmHCReporte(frmPrincipal padre, int _paciente)
        {
            InitializeComponent();
            Padre = padre;
            Paciente = CapaLogica.Paciente.Buscar(_paciente); ;
        }

        private void frmEstadisticas_Load(object sender, System.EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                MedicoDTO med = CapaLogica.Medico.BuscarDni(Padre.Sesion.Persona.Dni);
                ObtenerNombreCompleto_ResultBindingSource.DataSource = db.ObtenerNombreCompleto(Padre.Sesion.Persona.Id);
                ObtenerFechaActual_ResultBindingSource.DataSource = db.ObtenerFechaActual();
                ObtenerHistoriasClinicas_ResultBindingSource.DataSource = db.ObtenerHistoriasClinicas(med.Id, Paciente.Id);
                ObtenerNombrePaciente_ResultBindingSource.DataSource = db.ObtenerNombreCompleto(Paciente.Persona.Id);
                this.rptViewer.RefreshReport();
            }
            rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
            rptViewer.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
