using MediTurno.Entidades;
using System;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public EmpleadoDTO Sesion;

        public enum Menus
        {
            Inicio,
            Turnos,
            Pacientes,
            Medicos,
            Backup,
            Ninguno
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AdministrarPermisos();
            // Siempre que inicio, debe iniciar sesion
            AbrirFormPanel(new frmAcceso(this));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivarIndicador(Menus.Inicio);
            AbrirFormPanel(new frmInicio(this));
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            ActivarIndicador(Menus.Turnos);
            AbrirFormPanel(new frmTurnos(this));
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ActivarIndicador(Menus.Pacientes);
            AbrirFormPanel(new frmPacientes(this));
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            ActivarIndicador(Menus.Medicos);
            AbrirFormPanel(new frmMedicos(this));
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            ActivarIndicador(Menus.Backup);
            AbrirFormPanel(new SuperAdministrador.frmBackup(this));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                   "¿Desea cerrar sesión?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                ActivarIndicador(Menus.Ninguno);
                Sesion = null;
                AdministrarPermisos();
                AbrirFormPanel(new frmAcceso(this));
            }
        }

        public void AdministrarPermisos()
        {
            if (this.Sesion == null)
            {
                habilitarBarraLateral(false);
                lblUsuario.Text = "MediTurno";
                lblTipoUsuario.Text = "";
                btnBackup.Visible = false;
            }
            else
            {
                habilitarBarraLateral(true);
                lblUsuario.Text = Sesion.Persona.Apellidos + " " + Sesion.Persona.Nombres;
                lblTipoUsuario.Text = Sesion.TipoUsuario.Descripcion;

                if (this.Sesion.TipoUsuario.Id == 0)
                {
                    btnBackup.Visible = true;
                }
            }
        }

        public void ActivarIndicador(Menus menu)
        {
            pnlIndicadorInicio.Visible = false;
            pnlIndicadorTurnos.Visible = false;
            pnlIndicadorPacientes.Visible = false;
            pnlIndicadorMedicos.Visible = false;
            pnlIndicadorBackup.Visible = false;

            switch (menu)
            {
                case Menus.Inicio:
                    pnlIndicadorInicio.Visible = true;
                    break;
                case Menus.Turnos:
                    pnlIndicadorTurnos.Visible = true;
                    break;
                case Menus.Pacientes:
                    pnlIndicadorPacientes.Visible = true;
                    break;
                case Menus.Medicos:
                    pnlIndicadorMedicos.Visible = true;
                    break;
                case Menus.Backup:
                    pnlIndicadorBackup.Visible = true;
                    break;
            }
        }

        public void AbrirFormPanel(object frmHijo)
        {
            // Si hay algo abierto, cerrarlo
            if (this.pnlFormActual.Controls.Count > 0)
            {
                this.pnlFormActual.Controls[0].Dispose();
                //this.pnlFormActual.Controls.RemoveAt(0);
            }

            Form frmNuevo = frmHijo as Form;
            frmNuevo.TopLevel = false;
            frmNuevo.Dock = DockStyle.Fill;
            this.pnlFormActual.Controls.Add(frmNuevo);
            this.pnlFormActual.Tag = frmNuevo;
            frmNuevo.Show();
        }

        private void habilitarBarraLateral(bool habilitacion)
        {
            foreach (Control ctrl in pnlBarraLateral.Controls)
            {
                ctrl.Enabled = habilitacion;
            }
        }
    }
}
