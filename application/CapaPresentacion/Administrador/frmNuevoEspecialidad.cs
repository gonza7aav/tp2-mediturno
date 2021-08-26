using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.Administrador
{
    public partial class frmNuevoEspecialidad : Form
    {
        private frmPrincipal Padre;
        private int Id;

        public frmNuevoEspecialidad(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            Id = -1;
        }

        public frmNuevoEspecialidad(frmPrincipal padre, int pId)
        {
            InitializeComponent();
            Padre = padre;
            Id = pId;
        }

        private void frmNuevoEspecialidad_Load(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                lblTitulo.Text = "Editar Especialidad";
                EspecialidadDTO esp = Especialidad.Buscar(Id);
                txtNombre.Text = esp.Descripcion;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                   (Id == -1) ? "¿Desea registrar una Especialidad?" : "¿Desea guardar los cambios?",
                   "Confirmación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    if (Id == -1)
                    {
                        Especialidad.Guardar(txtNombre.Text);
                    }
                    else
                    {
                        Especialidad.Editar(Id, txtNombre.Text);
                    }
                    Padre.AbrirFormPanel(new Secretario.frmEspecialidades(Padre));
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = PonerMayuculas(txtNombre.Text);
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
            errNuevoEspecialidad.Clear();

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errNuevoEspecialidad.SetError(txtNombre, "Debe ingresar una Especialidad");
                camposValidos = false;
            }

            return camposValidos;
        }
    }
}