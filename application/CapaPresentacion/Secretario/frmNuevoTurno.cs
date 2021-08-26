using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.Secretario
{
    public partial class frmNuevoTurno : Form
    {
        private frmPrincipal Padre;
        private int id;
        private MedicoDTO med;
        private PacienteDTO pac;
        private CoberturaDTO cob;
        private DateTime dia;
        private Busqueda bus;

        private enum Busqueda
        {
            Medico,
            Paciente
        }

        public frmNuevoTurno(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            id = -1;
            med = null;
            pac = null;
            cob = null;
            dia = DateTime.Now.AddDays(-1);
        }

        public frmNuevoTurno(frmPrincipal padre, int pId)
        {
            InitializeComponent();
            Padre = padre;
            id = pId;
            med = null;
            pac = null;
            cob = null;
            dia = DateTime.Now.AddDays(-1);
        }

        private void frmNuevoTurno_Load(object sender, EventArgs e)
        {
            //Cobertura.CargarComboBox(cboCobertura);
            if (id != -1)
            {
                lblTitulo.Text = "Editar Turno";
                TurnoDTO aux = Turno.Buscar(id);
                med = aux.Medico;
                txtMedico.Text = med.Empleado.Persona.Apellidos + " " + med.Empleado.Persona.Nombres;
                pac = aux.Paciente;
                txtPaciente.Text = pac.Persona.Apellidos + " " + pac.Persona.Nombres;
                cob = aux.Cobertura;
                txtCobertura.Text = (aux.Cobertura.Id == 10)? "Ninguna" : cob.Descripcion + " - " + cob.ObraSocial.Nombre;
                dia = aux.FechaHora;
                dtpDia.Value = aux.FechaHora;
                //cboCobertura.SelectedIndex = cboCobertura.FindStringExact(aux.Cobertura.ObraSocial.Nombre + " - " + aux.Cobertura.Descripcion);

                Turno.CargarAgenda(grdAgenda, med, dtpDia.Value);
                grdAgenda.CurrentCell = grdAgenda[3, Turno.HoraAPeriodo(aux.FechaHora)];

                lblTurnoEstado.Visible = true;
                cboTurnoEstado.Visible = true;
                TurnoEstado.CargarComboBox(cboTurnoEstado);
                cboTurnoEstado.SelectedIndex = cboTurnoEstado.FindStringExact(aux.Estado.Descripcion);
            }
            pnlBusqueda.Location = new Point(0, 125);
            pnlBusqueda2.Location = new Point(0, 125);
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

        private void picBuscarMedico_Click(object sender, EventArgs e)
        {
            BuscarMedico();
        }

        private void txtMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarMedico();
            }
        }

        private void picBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente();
        }

        private void txtPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPaciente();
            }
        }

        private void picBuscarCobertura_Click(object sender, EventArgs e)
        {
            BuscarCobertura();
        }

        private void txtCobertura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCobertura();
            }
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            if (med != null)
            {
                CapaLogica.Turno.CargarAgenda(grdAgenda, med, dtpDia.Value);
            }
        }

        private void grdBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)grdBusqueda.Rows[e.RowIndex].Cells["IdB"].Value;

            // Si esta buscando Medico
            if (bus == Busqueda.Medico)
            {
                med = CapaLogica.Medico.Buscar(id);
                txtMedico.Text = med.Empleado.Persona.Apellidos + " " + med.Empleado.Persona.Nombres;
                dtpDia_ValueChanged(sender, e);
            }
            else
            {
                pac = CapaLogica.Paciente.Buscar(id);
                txtPaciente.Text = pac.Persona.Apellidos + " " + pac.Persona.Nombres;
            }

            pnlBusqueda.Visible = false;
        }

        private void grdBusqueda2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)grdBusqueda2.Rows[e.RowIndex].Cells["IdC"].Value;
            cob = CapaLogica.Cobertura.Buscar(id);
            txtCobertura.Text = (cob.Id == 10) ? "Ninguna" : cob.Descripcion + " - " + cob.ObraSocial.Nombre;
            pnlBusqueda2.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                   (id == -1) ? "¿Desea registrar un Turno?" : "¿Desea guardar los cambios?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    // -1 para nuevos turnos
                    if (id == -1)
                    {
                        Turno.Guardar(med, pac, dia, (cob == null)? 10 : cob.Id);
                    }
                    else
                    {
                        KeyValuePair<int, string> seleccionTurnoEstado = (KeyValuePair<int, string>)cboTurnoEstado.Items[cboTurnoEstado.SelectedIndex];
                        Turno.Editar(id, med, pac, dia, (cob == null) ? 10 : cob.Id, seleccionTurnoEstado.Key);

                    }
                    Padre.AbrirFormPanel(new Secretario.frmComprobanteTurno(this.Padre));
                }
            }
        }

        private void grdAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (grdAgenda.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Ocupado")
                {
                    dia = DateTime.Now.AddDays(-1);
                    MessageBox.Show(
                        "El turno seleccionado no se encuentra libre.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (grdAgenda.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Libre")
                {
                    DateTime hora = Turno.PerdiodoAHora(e.RowIndex);

                    dia = new DateTime(
                        dtpDia.Value.AddDays(e.ColumnIndex - 3).Year,
                        dtpDia.Value.AddDays(e.ColumnIndex - 3).Month,
                        dtpDia.Value.AddDays(e.ColumnIndex - 3).Day,
                        hora.Hour,
                        hora.Minute,
                        0);
                }
                else
                {
                    dia = DateTime.Now.AddDays(-1);
                }
            }
        }

        private void txtMedico_TextChanged(object sender, EventArgs e)
        {
            if (med != null && txtMedico.Text != med.Empleado.Persona.Apellidos + " " + med.Empleado.Persona.Nombres)
            {
                med = null;
            }
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {
            if (pac != null && txtPaciente.Text != pac.Persona.Apellidos + " " + pac.Persona.Nombres)
            {
                pac = null;
            }
        }

        private void txtCobertura_TextChanged(object sender, EventArgs e)
        {
            if (cob != null && txtCobertura.Text != cob.Descripcion + " - " + cob.ObraSocial.Nombre)
            {
                cob = null;
            }
        }

        private void pnlBusqueda2_Click(object sender, EventArgs e)
        {
            pnlBusqueda.Visible = false;
            pnlBusqueda2.Visible = false;
            
            if (med == null) txtMedico.Clear();
            if (pac == null) txtPaciente.Clear();
            if (cob == null) txtCobertura.Clear();
        }

        private void pnlBusqueda_Click(object sender, EventArgs e)
        {
            pnlBusqueda.Visible = false;
            pnlBusqueda2.Visible = false;

            if (med == null) txtMedico.Clear();
            if (pac == null) txtPaciente.Clear();
            if (cob == null) txtCobertura.Clear();
        }

        private void frmNuevoTurno_Click(object sender, EventArgs e)
        {
            pnlBusqueda.Visible = false;
            pnlBusqueda2.Visible = false;

            if (med == null) txtMedico.Clear();
            if (pac == null) txtPaciente.Clear();
            if (cob == null) txtCobertura.Clear();
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;
            errNuevoTurno.Clear();

            if (med == null)
            {
                errNuevoTurno.SetError(picBuscarMedico, "Debe seleccionar un Medico");
                camposValidos = false;
            }
            if (pac == null)
            {
                errNuevoTurno.SetError(picBuscarPaciente, "Debe seleccionar un Paciente");
                camposValidos = false;
            }
            if (DateTime.Compare(dia, DateTime.Now) < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un Turno",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                camposValidos = false;
            }
            /*if (cboCobertura.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una Cobertura",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                camposValidos = false;
            }*/

            return camposValidos;
        }

        private void BuscarMedico()
        {
            int dni;
            if (Int32.TryParse(txtMedico.Text, out dni))
            {
                CapaLogica.Medico.CargarDataGridBusqueda(grdBusqueda, dni);
            }
            else
            {
                CapaLogica.Medico.CargarDataGridBusqueda(grdBusqueda, txtMedico.Text);
            }

            pnlBusqueda.Visible = true;
            grdBusqueda.Columns["Especialidad"].Visible = true;
            grdBusqueda.Columns["Matricula"].Visible = true;
            bus = Busqueda.Medico;
        }

        private void BuscarPaciente()
        {
            int dni;
            if (Int32.TryParse(txtPaciente.Text, out dni))
            {
                CapaLogica.Paciente.CargarDataGridBusqueda(grdBusqueda, dni);
            }
            else
            {
                CapaLogica.Paciente.CargarDataGridBusqueda(grdBusqueda, txtPaciente.Text);
            }

            pnlBusqueda.Visible = true;
            grdBusqueda.Columns["Especialidad"].Visible = false;
            grdBusqueda.Columns["Matricula"].Visible = false;
            bus = Busqueda.Paciente;
        }

        private void BuscarCobertura()
        {
            CapaLogica.Cobertura.CargarDataGridBusqueda(grdBusqueda2, txtCobertura.Text);
            pnlBusqueda2.Visible = true;
        }
    }
}
