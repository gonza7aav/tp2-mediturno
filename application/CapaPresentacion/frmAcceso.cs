using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmAcceso : Form
    {
        private frmPrincipal Padre;

        public frmAcceso(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                   "¿Desea salir de MediTurno?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                Padre.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();
            }
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;
            errAcceso.Clear();

            if (String.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errAcceso.SetError(txtUsuario, "Debe ingresar un usuario");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                errAcceso.SetError(txtContraseña, "Debe ingresar una contraseña");
                camposValidos = false;
            }

            return camposValidos;
        }

        private void Ingresar()
        {
            if (!ValidarCampos()) return;

            EmpleadoDTO sesion = Empleado.Ingresar(txtUsuario.Text, txtContraseña.Text);
            if (sesion != null)
            {
                Padre.Sesion = sesion;
                Padre.AdministrarPermisos();
                Padre.ActivarIndicador(frmPrincipal.Menus.Inicio);
                Padre.AbrirFormPanel(new frmInicio(Padre));
            }
            else
            {
                MessageBox.Show(
                    "El nombre de usuario y/o contraseña es incorrecto.\nPor favor intente nuevamente.",
                    "Error al iniciar sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
