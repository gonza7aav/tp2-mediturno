using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.Secretario
{
    public partial class frmNuevoPaciente : Form
    {
        private frmPrincipal Padre;
        private int Id;

        public frmNuevoPaciente(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            Id = -1;
        }

        public frmNuevoPaciente(frmPrincipal padre, int id)
        {
            InitializeComponent();
            Padre = padre;
            Id = id;
        }

        private void frmNuevoPaciente_Load(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                PacienteDTO pac = Paciente.Buscar(Id);

                lblTitulo.Text = "Editar Paciente";
                txtApellidos.Text = pac.Persona.Apellidos;
                txtNombres.Text = pac.Persona.Nombres;
                txtDni.Text = pac.Persona.Dni;
                txtDni.Enabled = false;
                dtpFechaNacimiento.Value = pac.Persona.FechaNacimiento;
                dtpFechaNacimiento.Enabled = false;
                txtCorreoElectronico.Text = pac.Persona.CorreoElectronico;
                txtTelefono.Text = pac.Persona.Telefono;
                if (pac.Persona.Sexo == "M")
                {
                    rdbMasculino.Checked = true;
                    rdbFemenino.Checked = false;
                }
                else
                {
                    rdbFemenino.Checked = true;
                    rdbMasculino.Checked = false;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                   (Id == -1) ? "¿Desea registrar un Paciente?" : "¿Desea guardar los cambios?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    if (Id == -1)
                    {
                        Paciente.Guardar(
                            txtDni.Text, txtApellidos.Text, txtNombres.Text,
                            dtpFechaNacimiento.Value, (rdbMasculino.Checked) ? "M" : "F",
                            txtCorreoElectronico.Text, txtTelefono.Text);
                    }
                    else
                    {
                        Paciente.Editar(
                            Id, txtDni.Text, txtApellidos.Text, txtNombres.Text,
                            dtpFechaNacimiento.Value, (rdbMasculino.Checked) ? "M" : "F",
                            txtCorreoElectronico.Text, txtTelefono.Text);
                    }
                    Padre.AbrirFormPanel(new frmPacientes(Padre));
                }
            }
        }

        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            txtApellidos.Text = PonerMayuculas(txtApellidos.Text);
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            txtNombres.Text = PonerMayuculas(txtNombres.Text);
        }

        private string PonerMayuculas(string str)
        {
            string resultado = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || str[i - 1] == ' ')
                {
                    resultado += str[i].ToString().ToUpper();
                }
                else
                {
                    resultado += str[i];
                }
            }
            return resultado;
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;
            Regex rgx = new Regex(@"[^\s]+@[^\s]+\.[a-zA-Z]+");
            errNuevoPaciente.Clear();

            if (String.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errNuevoPaciente.SetError(txtApellidos, "Debe ingresar un Apellido");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errNuevoPaciente.SetError(txtNombres, "Debe ingresar un Nombre");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtDni.Text))
            {
                errNuevoPaciente.SetError(txtDni, "Debe ingresar el DNI");
                camposValidos = false;
            }
            if (DateTime.Compare(dtpFechaNacimiento.Value, DateTime.Now) > 0)
            {
                errNuevoPaciente.SetError(dtpFechaNacimiento, "Debe ingresar una Fecha de Nacimiento válida");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errNuevoPaciente.SetError(txtTelefono, "Debe ingresar un Telefono");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtCorreoElectronico.Text) || !rgx.IsMatch(txtCorreoElectronico.Text))
            {
                errNuevoPaciente.SetError(txtCorreoElectronico, "Debe ingresar un Correo Electronico válido");
                camposValidos = false;
            }

            return camposValidos;
        }
    }
}
