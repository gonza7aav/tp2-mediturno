using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class Especialidad
    {
        public static EspecialidadDTO Buscar(int id)
        {
            return EspecialidadDAL.Buscar(id);
        }

        public static void CargarComboBox(ComboBox cb)
        {
            int ancho = 0;
            int maximo = 0;
            foreach (EspecialidadDTO temp in EspecialidadDAL.Buscar())
            {
                // calculo en ancho mas largo de texto
                ancho = TextRenderer.MeasureText(temp.Descripcion, cb.Font).Width;
                if (maximo < ancho)
                {
                    maximo = ancho;
                }
                cb.Items.Add(new KeyValuePair<int, String>(temp.Id, temp.Descripcion));
            }
            cb.ValueMember = "Key";
            cb.DisplayMember = "Value";
            cb.SelectedIndex = -1;
            cb.DropDownWidth = maximo;
        }

        public static void CargarDataGrid(DataGridView grd)
        {
            grd.Rows.Clear();
            List<EspecialidadDTO> especialidades = new List<EspecialidadDTO>();
            especialidades = EspecialidadDAL.Buscar();
            foreach (EspecialidadDTO temp in especialidades)
            {
                grd.Rows.Add(
                    null,
                    temp.Id,
                    temp.Descripcion);
            }
        }

        public static void CargarDataGrid(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<EspecialidadDTO> especialidades = new List<EspecialidadDTO>();
            especialidades = EspecialidadDAL.Buscar(apenom);
            foreach (EspecialidadDTO temp in especialidades)
            {
                grd.Rows.Add(
                    null,
                    temp.Id,
                    temp.Descripcion);
            }
        }

        public static void Guardar(string desc)
        {
            EspecialidadDTO nuevo = new EspecialidadDTO(desc);
            if (EspecialidadDAL.Guardar(nuevo))
            {
                MessageBox.Show(
                    "La Especialidad fue guardada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar la Especialidad.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, string desc)
        {
            EspecialidadDTO nuevo = new EspecialidadDTO(id, desc);
            if (EspecialidadDAL.Editar(nuevo))
            {
                MessageBox.Show(
                    "La Especialidad fue modificada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar la Especialidad.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
