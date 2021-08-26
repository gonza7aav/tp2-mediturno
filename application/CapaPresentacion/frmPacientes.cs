using MediTurno.CapaLogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmPacientes : Form
    {
        private frmPrincipal Padre;

        public frmPacientes(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            Paciente.CargarDataGrid(grdPacientes, Padre.Sesion);
            AdministrarPermisos();
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
            this.Padre.AbrirFormPanel(new Secretario.frmNuevoPaciente(Padre));
        }

        private void grdPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    Padre.AbrirFormPanel(new Secretario.frmNuevoPaciente(Padre, (int)grdPacientes.Rows[e.RowIndex].Cells["Id"].Value));
                }
                else if (e.ColumnIndex == 1)
                {
                    Padre.AbrirFormPanel(new Medico.frmHistoriasClinicas(Padre, (int)grdPacientes.Rows[e.RowIndex].Cells["Id"].Value));
                }
            }
        }

        private void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Id)
            {
                case 3:
                    // Medico
                    grdPacientes.Columns["HC"].Visible = true;
                    break;

                case 4:
                    // Secretario
                    grdPacientes.Columns["Editar"].Visible = true;
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
                Paciente.CargarDataGrid(grdPacientes, Padre.Sesion);
            }
            else if (Int32.TryParse(txtBuscar.Text, out dni))
            {
                Paciente.CargarDataGrid(grdPacientes, Padre.Sesion, dni);
            }
            else
            {
                Paciente.CargarDataGrid(grdPacientes, Padre.Sesion, txtBuscar.Text);
            }
        }
    }
}
