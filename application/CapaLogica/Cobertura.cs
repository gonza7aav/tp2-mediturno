using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class Cobertura
    {
        public static CoberturaDTO Buscar(int id)
        {
            return CoberturaDAL.Buscar(id);
        }

        public static void CargarDataGrid(DataGridView grd)
        {
            grd.Rows.Clear();
            List<CoberturaDTO> coberturas = new List<CoberturaDTO>();
            coberturas = CoberturaDAL.Buscar();
            foreach (CoberturaDTO temp in coberturas)
            {
                if (temp.Id != 10)
                {
                    grd.Rows.Add(
                        (temp.Id == 1) ? null : MediTurno.Properties.Resources.feather_edit,
                        temp.Id,
                        temp.ObraSocial.Nombre,
                        temp.Descripcion);
                }
            }
        }

        public static void CargarDataGrid(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<CoberturaDTO> coberturas = new List<CoberturaDTO>();
            coberturas = CoberturaDAL.Buscar(apenom);
            foreach (CoberturaDTO temp in coberturas)
            {
                if (temp.Id != 10)
                {
                    grd.Rows.Add(
                        (temp.Id == 1) ? null : MediTurno.Properties.Resources.feather_edit,
                        temp.Id,
                        temp.ObraSocial.Nombre,
                        temp.Descripcion);
                }
            }
        }

        public static void CargarDataGridBusqueda(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<CoberturaDTO> coberturas = new List<CoberturaDTO>();
            coberturas = CoberturaDAL.Buscar(apenom);
            foreach (CoberturaDTO temp in coberturas)
            {
                if (temp.Id != 10 && temp.Estado)
                {
                    grd.Rows.Add(
                        temp.Id,
                        temp.Descripcion,
                        temp.ObraSocial.Nombre);
                }
            }
        }

        public static void Guardar(int os, string nom, bool estado)
        {
            CoberturaDTO nuevo = new CoberturaDTO(ObraSocialDAL.Buscar(os), nom, estado);
            if (CoberturaDAL.Guardar(nuevo))
            {
                MessageBox.Show(
                    "La Cobertura fue guardada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar la Cobertura.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, int os, string nom, bool estado)
        {
            CoberturaDTO modificado = new CoberturaDTO(id, ObraSocialDAL.Buscar(os), nom, estado);
            if (CoberturaDAL.Editar(modificado))
            {
                MessageBox.Show(
                    "La Cobertura fue modificada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar la Cobertura.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
