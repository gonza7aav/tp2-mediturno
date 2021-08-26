using MediTurno.CapaLogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion
{
    public partial class frmTurnos : Form
    {
        private frmPrincipal Padre;

        public frmTurnos(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            Turno.CargarDataGrid(grdTurnos, Padre.Sesion);
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

        private void picFiltrar_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) < 0)
            {
                BuscarFiltrado();
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
            Padre.AbrirFormPanel(new Secretario.frmNuevoTurno(Padre));
        }

        private void grdTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                Padre.AbrirFormPanel(new Secretario.frmNuevoTurno(Padre, (int)grdTurnos.Rows[e.RowIndex].Cells["Id"].Value));
            }
        }

        private void picImprimir_Click(object sender, EventArgs e)
        {
            Padre.AbrirFormPanel(new Medico.frmTurnosDelDia(Padre));
        }

        public void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Id)
            {
                case 4:
                    // Secretario
                    picNuevo.Visible = true;
                    grdTurnos.Columns["btnEditar"].Visible = true;
                    break;

                case 3:
                    // Medico
                    grdTurnos.Columns["Medico"].Visible = false;
                    picImprimir.Visible = true;
                    break;
            }
        }

        private void Buscar()
        {
            int dni;
            if (txtBuscar.Text == "" || txtBuscar.Text == "Buscar...")
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion);
            }
            else if (Int32.TryParse(txtBuscar.Text, out dni))
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion, dni);
            }
            else
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion, txtBuscar.Text);
            }
        }

        private void BuscarFiltrado()
        {
            int dni;
            if (txtBuscar.Text == "" || txtBuscar.Text == "Buscar...")
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion, dtpDesde.Value, dtpHasta.Value);
            }
            else if (Int32.TryParse(txtBuscar.Text, out dni))
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion, dni, dtpDesde.Value, dtpHasta.Value);
            }
            else
            {
                Turno.CargarDataGrid(grdTurnos, Padre.Sesion, txtBuscar.Text, dtpDesde.Value, dtpHasta.Value);
            }
        }
    }
}
