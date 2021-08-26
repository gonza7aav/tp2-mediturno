using MediTurno.CapaLogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.Gerente
{
    public partial class frmEmpleados : Form
    {
        private frmPrincipal Padre;

        public frmEmpleados(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            AdministrarPermisos();
            Empleado.CargarDataGrid(grdEmpleados);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.FromArgb(62, 62, 64);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void picBuscarIcono_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void picButton_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picSender = sender as PictureBox;
            picSender.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void picButton_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picSender = sender as PictureBox;
            picSender.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void picNuevoIcono_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoEmpleado(Padre));
        }

        private void grdGerentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0 && grdEmpleados.Rows[e.RowIndex].Cells["TipoUsuario"].Value.ToString() != "SuperAdministrador")
            {
                if (grdEmpleados.Rows[e.RowIndex].Cells["TipoUsuario"].Value.ToString() != "Medico")
                {
                    Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoEmpleado(Padre, grdEmpleados.Rows[e.RowIndex].Cells["Dni"].Value.ToString()));
                }
                else
                {
                    Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoMedico(Padre, grdEmpleados.Rows[e.RowIndex].Cells["Dni"].Value.ToString()));
                }
            }
        }

        private void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Id)
            {
                case 0:
                    // SuperAdministrador
                    grdEmpleados.Columns["Editar"].Visible = true;
                    picNuevo.Visible = true;
                    break;
            }
        }

        private void Buscar()
        {
            if (txtBuscar.Text == "Buscar...") return;

            int dni;
            if (txtBuscar.Text == "")
            {
                Empleado.CargarDataGrid(grdEmpleados);
            }
            else if (Int32.TryParse(txtBuscar.Text, out dni))
            {
                Empleado.CargarDataGrid(grdEmpleados, dni);
            }
            else
            {
                Empleado.CargarDataGrid(grdEmpleados, txtBuscar.Text);
            }
        }
    }
}
