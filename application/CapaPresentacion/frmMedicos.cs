using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmMedicos : Form
    {
        private frmPrincipal Padre;

        public frmMedicos(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            AdministrarPermisos();
            CapaLogica.Medico.CargarDataGrid(grdMedicos);
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
            Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoMedico(Padre));
        }

        private void grdMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                Padre.AbrirFormPanel(new SuperAdministrador.frmNuevoMedico(Padre, grdMedicos.Rows[e.RowIndex].Cells["Dni"].Value.ToString()));
            }
        }

        private void picImprimir_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Gerente.frmCartillaMedica(Padre));
        }

        private void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Id)
            {
                case 0:
                    // SuperAdministrador
                    grdMedicos.Columns["Editar"].Visible = true;
                    picNuevo.Visible = true;
                    break;

                case 2:
                    // Gerente
                    picImprimir.Visible = true;
                    break;
                case 4:
                    // Secretario
                    picImprimir.Visible = true;
                    break;
            }
        }

        private void Buscar()
        {
            if (txtBuscar.Text == "Buscar...") return;

            int dni;
            if (txtBuscar.Text == "")
            {
                CapaLogica.Medico.CargarDataGrid(grdMedicos);
            }
            else if (Int32.TryParse(txtBuscar.Text, out dni))
            {
                CapaLogica.Medico.CargarDataGrid(grdMedicos, dni);
            }
            else
            {
                CapaLogica.Medico.CargarDataGrid(grdMedicos, txtBuscar.Text);
            }
        }
    }
}
