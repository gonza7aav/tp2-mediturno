using MediTurno.CapaLogica;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.Administrador
{
    public partial class frmNuevoCobertura : Form
    {
        private frmPrincipal Padre;
        private int Id;

        public frmNuevoCobertura(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
            Id = -1;
        }

        public frmNuevoCobertura(frmPrincipal padre, int pId)
        {
            InitializeComponent();
            Padre = padre;
            Id = pId;
        }

        private void frmNuevoCobertura_Load(object sender, EventArgs e)
        {
            ObraSocial.CargarComboBox(cboObraSocial);
            if (Id != -1)
            {
                lblTitulo.Text = "Editar Cobertura";
                CoberturaDTO cob = Cobertura.Buscar(Id);
                txtNombre.Text = cob.Descripcion;
                cboObraSocial.SelectedIndex = cboObraSocial.FindStringExact(cob.ObraSocial.Nombre);
                chkActivo.Checked = cob.Estado;
                chkActivo.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult res = MessageBox.Show(
                    (Id == -1)? "¿Desea registrar una Cobertura?" : "¿Desea guardar los cambios?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    KeyValuePair<int, string> seleccionObraSocial = (KeyValuePair<int, string>)cboObraSocial.Items[cboObraSocial.SelectedIndex];
                    if (Id == -1)
                    {
                        Cobertura.Guardar(seleccionObraSocial.Key, txtNombre.Text, true);
                    }
                    else
                    {
                        Cobertura.Editar(Id, seleccionObraSocial.Key, txtNombre.Text, chkActivo.Checked);
                    }
                    Padre.AbrirFormPanel(new Secretario.frmCoberturas(Padre)); ;
                }
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
            errNuevoCobertura.Clear();

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errNuevoCobertura.SetError(txtNombre, "Debe ingresar una Cobertura");
                camposValidos = false;
            }
            if (cboObraSocial.SelectedIndex == -1)
            {
                errNuevoCobertura.SetError(cboObraSocial, "Debe ingresar una Obra Social");
                camposValidos = false;
            }
            else
            {
                KeyValuePair<int, string> seleccionObraSocial = (KeyValuePair<int, string>)cboObraSocial.Items[cboObraSocial.SelectedIndex];
                if (seleccionObraSocial.Key == 1)
                {
                    errNuevoCobertura.SetError(cboObraSocial, "Debe ingresar una Obra Social valida");
                    camposValidos = false;
                }
            }

            return camposValidos;
        }
    }
}
