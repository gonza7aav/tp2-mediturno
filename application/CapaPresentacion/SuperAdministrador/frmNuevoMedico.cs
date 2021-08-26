using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.SuperAdministrador
{
    public partial class frmNuevoMedico : Form
    {
        private frmPrincipal Padre;
        private int Id;

        public frmNuevoMedico(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            Id = -1;
        }

        public frmNuevoMedico(frmPrincipal padre, string dni)
        {
            InitializeComponent();
            Padre = padre;
            Id = 0;
            txtDni.Text = dni;
        }

        private void frmNuevoMedico_Load(object sender, EventArgs e)
        {
            Especialidad.CargarComboBox(cboEspecialidad);
            if (Id != -1)
            {
                lblTitulo.Text = "Editar Medico";
                lblTitulo0.Text = "Editar Medico";

                MedicoDTO med = CapaLogica.Medico.BuscarDni(txtDni.Text);
                Id = med.Id;

                txtApellidos.Text = med.Empleado.Persona.Apellidos;
                txtNombres.Text = med.Empleado.Persona.Nombres;
                dtpFechaNacimiento.Value = med.Empleado.Persona.FechaNacimiento;
                txtCorreoElectronico.Text = med.Empleado.Persona.CorreoElectronico;
                txtTelefono.Text = med.Empleado.Persona.Telefono;
                if (med.Empleado.Persona.Sexo == "M")
                {
                    rdbMasculino.Checked = true;
                    rdbFemenino.Checked = false;
                }
                else
                {
                    rdbFemenino.Checked = true;
                    rdbMasculino.Checked = false;
                }
                txtCuil.Text = med.Empleado.Cuil;
                txtUsuario.Text = med.Empleado.Usuario;
                txtContraseña.Text = med.Empleado.Contraseña;
                txtMatricula.Text = med.Matricula;
                cboEspecialidad.SelectedIndex = cboEspecialidad.FindStringExact(med.Especialidad.Descripcion);
                chkActivo.Checked = med.Empleado.Activo;
                dtpFechaIngreso.Value = med.Empleado.FechaIngreso;
            }
            pnlPagina0.Location = new Point(0, 0);
            AdministrarPermisos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                   (Id == -1) ? "¿Desea registrar un Medico?" : "¿Desea guardar los cambios?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    KeyValuePair<int, string> seleccionEspecialidad = (KeyValuePair<int, string>)cboEspecialidad.Items[cboEspecialidad.SelectedIndex];
                    if (Id == -1)
                    {
                        CapaLogica.Medico.Guardar(
                            txtDni.Text, txtApellidos.Text, txtNombres.Text,
                            dtpFechaNacimiento.Value, (rdbMasculino.Checked) ? "M" : "F",
                            txtCorreoElectronico.Text, txtTelefono.Text, txtCuil.Text,
                            txtUsuario.Text, txtContraseña.Text, dtpFechaIngreso.Value,
                            chkActivo.Checked, txtMatricula.Text, seleccionEspecialidad.Key);
                    }
                    else
                    {
                        CapaLogica.Medico.Editar(
                            Id, txtDni.Text, txtApellidos.Text, txtNombres.Text,
                            dtpFechaNacimiento.Value, (rdbMasculino.Checked) ? "M" : "F",
                            txtCorreoElectronico.Text, txtTelefono.Text, txtCuil.Text,
                            txtUsuario.Text, txtContraseña.Text, dtpFechaIngreso.Value,
                            chkActivo.Checked, txtMatricula.Text, seleccionEspecialidad.Key);
                        if (Padre.Sesion.Persona.Dni == txtDni.Text)
                        {
                            Padre.Sesion = Empleado.BuscarDni(txtDni.Text);
                            Padre.AdministrarPermisos();
                        }
                    }
                    if (Padre.Sesion.TipoUsuario.Id <= 2)
                    {
                        Padre.AbrirFormPanel(new frmMedicos(Padre));
                    }
                    else
                    {
                        Padre.AbrirFormPanel(new frmInicio(Padre));
                    }
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

        private void txtApellidos0_Leave(object sender, EventArgs e)
        {
            txtApellidos.Text = PonerMayuculas(txtApellidos.Text);
        }

        private void txtNombres0_Leave(object sender, EventArgs e)
        {
            txtNombres.Text = PonerMayuculas(txtNombres.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pnlPagina0.Visible = false;

            txtUsuario.Visible = true;
            txtContraseña.Visible = true;
            txtMatricula.Visible = true;
            cboEspecialidad.Visible = true;
            dtpFechaIngreso.Visible = true;
            btnAnterior.Visible = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pnlPagina0.Visible = true;

            txtUsuario.Visible = false;
            txtContraseña.Visible = false;
            txtMatricula.Visible = false;
            cboEspecialidad.Visible = false;
            dtpFechaIngreso.Visible = false;
            btnAnterior.Visible = false;
        }

        private void AdministrarPermisos()
        {
            switch (Padre.Sesion.TipoUsuario.Descripcion)
            {
                case "SuperAdministrador":
                    // si es nuevo Id == -1 entonces puede poner contraseña
                    // si el SuperAdministrador quiere editar no podra cambiar
                    // la contraseña
                    txtDni.Enabled = Id == -1;
                    dtpFechaNacimiento.Enabled = Id == -1;
                    txtCuil.Enabled = Id == -1;
                    txtContraseña.Enabled = Id == -1;

                    txtUsuario.Enabled = true;
                    txtMatricula.Enabled = true;
                    chkActivo.Visible = true;
                    dtpFechaIngreso.Enabled = true;
                    break;
            }
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
            bool paginaAnterior = false;
            Regex rgx = new Regex(@"[^\s]+@[^\s]+\.[a-zA-Z]+");
            errNuevoMedico.Clear();

            if (String.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errNuevoMedico.SetError(txtApellidos, "Debe ingresar un Apellido");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (String.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errNuevoMedico.SetError(txtNombres, "Debe ingresar un Nombre");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (String.IsNullOrWhiteSpace(txtDni.Text))
            {
                errNuevoMedico.SetError(txtDni, "Debe ingresar el DNI");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (DateTime.Compare(dtpFechaNacimiento.Value, DateTime.Now.AddDays(-1)) > 0)
            {
                errNuevoMedico.SetError(dtpFechaNacimiento, "Debe ingresar una Fecha de Nacimiento válida");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (String.IsNullOrWhiteSpace(txtCorreoElectronico.Text) || !rgx.IsMatch(txtCorreoElectronico.Text))
            {
                errNuevoMedico.SetError(txtCorreoElectronico, "Debe ingresar un Correo Electronico válido");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errNuevoMedico.SetError(txtTelefono, "Debe ingresar un Telefono");
                camposValidos = false;
                paginaAnterior = true;
            }
            if (String.IsNullOrWhiteSpace(txtCuil.Text))
            {
                errNuevoMedico.SetError(txtCuil, "Debe ingresar un CUIL");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errNuevoMedico.SetError(txtUsuario, "Debe ingresar un Usuario");
                camposValidos = false;
            }
            if (txtContraseña.Text.Length < 8)
            {
                errNuevoMedico.SetError(txtContraseña, "Debe ingresar una Contraseña de al menos 8 caracteres");
                camposValidos = false;
            }
            if (String.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                errNuevoMedico.SetError(txtMatricula, "Debe ingresar una Matricula");
                camposValidos = false;
            }
            if (cboEspecialidad.SelectedIndex == -1)
            {
                errNuevoMedico.SetError(cboEspecialidad, "Debe ingresar una Especialidad");
                camposValidos = false;
            }

            if (paginaAnterior)
            {
                errNuevoMedico.SetError(btnAnterior, "Errores en la pagina anterior.");
            }

            return camposValidos;
        }
    }
}
