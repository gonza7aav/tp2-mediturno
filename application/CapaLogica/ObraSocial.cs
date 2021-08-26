using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class ObraSocial
    {
        public static ObraSocialDTO Buscar(int id)
        {
            return ObraSocialDAL.Buscar(id);
        }

        public static void CargarComboBox(ComboBox cb)
        {
            int ancho = 0;
            int maximo = 0;
            foreach (ObraSocialDTO temp in ObraSocialDAL.Buscar())
            {
                // calculo en ancho mas largo de texto
                ancho = TextRenderer.MeasureText(temp.Nombre, cb.Font).Width;
                if (maximo < ancho)
                {
                    maximo = ancho;
                }
                if (temp.Id != 7)
                {
                    cb.Items.Add(new KeyValuePair<int, String>(temp.Id, temp.Nombre));
                }
            }
            cb.ValueMember = "Key";
            cb.DisplayMember = "Value";
            cb.SelectedIndex = -1;
            cb.DropDownWidth = maximo;
        }

        public static void CargarDataGrid(DataGridView grd)
        {
            grd.Rows.Clear();
            List<ObraSocialDTO> os = new List<ObraSocialDTO>();
            os = ObraSocialDAL.Buscar();
            foreach (ObraSocialDTO temp in os)
            {
                if (temp.Id != 7)
                {
                    grd.Rows.Add(
                        (temp.Id == 1) ? null : MediTurno.Properties.Resources.feather_edit,
                        temp.Id,
                        temp.Nombre);
                }
            }
        }

        public static void CargarDataGrid(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<ObraSocialDTO> os = new List<ObraSocialDTO>();
            os = ObraSocialDAL.Buscar(apenom);
            foreach (ObraSocialDTO temp in os)
            {
                if (temp.Id != 7)
                {
                    grd.Rows.Add(
                        (temp.Id == 1) ? null : MediTurno.Properties.Resources.feather_edit,
                        temp.Id,
                        temp.Nombre);
                }
            }
        }

        public static void Guardar(string nom)
        {
            ObraSocialDTO nos = new ObraSocialDTO(nom, true);
            if (ObraSocialDAL.Guardar(nos))
            {
                MessageBox.Show(
                    "La Obra Social fue guardada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar la Obra Social.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, string nom, bool estado)
        {
            ObraSocialDTO nos = new ObraSocialDTO(id, nom, estado);
            if (ObraSocialDAL.Editar(nos))
            {
                MessageBox.Show(
                    "La Obra Social fue modificada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar la Obra Social.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
