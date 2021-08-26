using System;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmInicio : Form
    {
        private frmPrincipal Padre;

        public frmInicio(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AdministrarPermisos();
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            if (Padre.Sesion.TipoUsuario.Descripcion == "Medico")
            {
                Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoMedico(Padre, Padre.Sesion.Persona.Dni));
            }
            else
            {
                Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoEmpleado(Padre, Padre.Sesion.Persona.Dni));
            }
        }

        private void btnCoberturas_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Secretario.frmCoberturas(Padre));
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Secretario.frmEspecialidades(Padre));
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Gerente.frmEstadisticas(Padre));
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Gerente.frmEmpleados(Padre));
        }

        private void btnObraSociales_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Administrador.frmObraSociales(Padre));
        }

        public void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Id)
            {
                case 2:
                    // Gerente
                    btnEstadisticas.Visible = true;
                    btnEmpleados.Visible = true;
                    break;
                case 1:
                    // Administrador
                    btnEmpleados.Visible = true;
                    btnObraSociales.Visible = true;
                    break;
                case 0:
                    // SuperAdministrador
                    btnEmpleados.Visible = true;
                    btnObraSociales.Visible = true;
                    break;
            }
        }
    }
}