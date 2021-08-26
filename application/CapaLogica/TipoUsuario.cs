using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class TipoUsuario
    {
        public static void CargarComboBox(ComboBox cb)
        {
            int ancho = 0;
            int maximo = 0;
            foreach (TipoUsuarioDTO temp in TipoUsuarioDAL.Buscar())
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
    }
}
