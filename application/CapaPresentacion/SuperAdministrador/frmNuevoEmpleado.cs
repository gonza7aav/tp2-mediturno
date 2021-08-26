using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.SuperAdministrador
{
    public partial class frmNuevoEmpleado : Form
    {
        private frmPrincipal Padre;
        private int Id;

        public frmNuevoEmpleado(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            Id = -1;
        }

        public frmNuevoEmpleado(frmPrincipal padre, string dni)
        {
            InitializeComponent();
            Padre = padre;
            Id = 0;
            txtDni.Text = dni;
        }

        private void frmNuevoMedico_Load(object sender, EventArgs e)
        {
            TipoUsuario.CargarComboBox(cboTipoUsuario);
            if (Id != -1)
            {
                lblTitulo.Text = "Editar Empleado";
                lblTitulo0.Text = "Editar Empleado";

                EmpleadoDTO emp = Empleado.BuscarDni(txtDni.Text);
                Id = emp.Id;
                txtApellidos.Text = emp.Persona.Apellidos;
                txtNombres.Text = emp.Persona.Nombres;
                dtpFechaNacimiento.Value = emp.Persona.FechaNacimiento;
                txtCorreoElectronico.Text = emp.Persona.CorreoElectronico;
                txtTelefono.Text = emp.Persona.Telefono;
                if (emp.Persona.Sexo == "M")
                {
                    rdbMasculino.Checked = true;
                    rdbFemenino.Checked = false;
                }
                else
                {
                    rdbFemenino.Checked = true;
                    rdbMasculino.Checked = false;
                }
                txtCuil.Text = emp.Cuil;
                cboTipoUsuario.SelectedIndex = cboTipoUsuario.FindStringExact(emp.TipoUsuario.Descripcion);
                cboTipoUsuario.Enabled = false;
                txtUsuario.Text = emp.Usuario;
                txtContraseña.Text = emp.Contraseña;
                chkActivo.Checked = emp.Activo;
                dtpFechaIngreso.Value = emp.FechaIngreso;
            }
            pnlPagina0.Location = new Point(0, 0);
            AdministrarPermisos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                   (Id == -1) ? "¿Desea registrar un Empleado?" : "¿Desea guardar los cambios?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    KeyValuePair<int, string> seleccionTipo = (KeyValuePair<int, string>)cboTipoUsuario.Items[cboTipoUsuario.SelectedIndex];
                    if (Id == -1)
                    {
                        Empleado.Guardar(
                            txtDni.Text, txtApellidos.Text, txtNombres.Text, dtpFechaNacimiento.Value,
                            (rdbMasculino.Checked) ? "M" : "F", txtCorreoElectronico.Text, txtTelefono.Text,
                            txtCuil.Text, txtUsuario.Text, txtContraseña.Text, dtpFechaIngreso.Value,
                            seleccionTipo.Key, chkActivo.Checked);
                    }
                    else
                    {
                        Empleado.Editar(
                            Id, txtDni.Text, txtApellidos.Text, txtNombres.Text, dtpFechaNacimiento.Value,
                            (rdbMasculino.Checked) ? "M" : "F", txtCorreoElectronico.Text, txtTelefono.Text,
                            txtCuil.Text, txtUsuario.Text, txtContraseña.Text, dtpFechaIngreso.Value,
                            seleccionTipo.Key, chkActivo.Checked);
                        if (Padre.Sesion.Persona.Dni == txtDni.Text)
                        {
                            Padre.Sesion = Empleado.BuscarDni(txtDni.Text);
                            Padre.AdministrarPermisos();
                        }
                    }
                    if (Padre.Sesion.TipoUsuario.Id <= 2)
                    {
                        Padre.AbrirFormPanel(new Gerente.frmEmpleados(Padre));
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

            cboTipoUsuario.Visible = true;
            txtUsuario.Visible = true;
            txtContraseña.Visible = true;
            dtpFechaIngreso.Visible = true;
            btnAnterior.Visible = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pnlPagina0.Visible = true;

            cboTipoUsuario.Visible = false;
            txtUsuario.Visible = false;
            txtContraseña.Visible = false;
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

                    cboTipoUsuario.Enabled = true;
                    txtUsuario.Enabled = true;
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
            if (cboTipoUsuario.SelectedIndex == -1)
            {
                errNuevoMedico.SetError(cboTipoUsuario, "Debe ingresar un Tipo de Usuario");
                camposValidos = false;
            }
            else
            {
                KeyValuePair<int, string> seleccionTipo = (KeyValuePair<int, string>)cboTipoUsuario.Items[cboTipoUsuario.SelectedIndex];
                if ((Padre.Sesion.TipoUsuario.Id != 0 && seleccionTipo.Key == 0) || seleccionTipo.Key == 3)
                {
                    errNuevoMedico.SetError(cboTipoUsuario, "No puede crear un usario de este tipo");
                    camposValidos = false;
                }
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

            if (paginaAnterior)
            {
                errNuevoMedico.SetError(btnAnterior, "Errores en la pagina anterior");
            }

            return camposValidos;
        }
    }
}
