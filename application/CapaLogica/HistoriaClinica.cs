using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class HistoriaClinica
    {
        public static HistoriaClinicaDTO BuscarTurno(TurnoDTO tur)
        {
            return HistoriaClinicaDAL.Buscar(tur);
        }

        public static void CargarDataGrid(DataGridView grd, EmpleadoDTO emp, PacienteDTO pac)
        {
            grd.Rows.Clear();
            List<TurnoDTO> turnos = new List<TurnoDTO>();
            turnos = TurnoDAL.BuscarDni(emp, pac.Persona.Dni);
            List<HistoriaClinicaDTO> hcs = new List<HistoriaClinicaDTO>();
            hcs = HistoriaClinicaDAL.Buscar(emp, pac);
            foreach (TurnoDTO t in turnos)
            {
                grd.Rows.Add(
                    (hcs.Exists(el => el.Turno.Id == t.Id)) ? MediTurno.Properties.Resources.feather_eye : null,
                    t.Id,
                    t.Medico.Empleado.Persona.Apellidos + " " + t.Medico.Empleado.Persona.Nombres,
                    t.Paciente.Persona.Apellidos + " " + t.Paciente.Persona.Nombres,
                    t.FechaHora.ToShortDateString(),
                    t.FechaHora.ToShortTimeString(),
                    (t.Cobertura.Id == 10)? "Ninguna" : t.Cobertura.ObraSocial.Nombre + " - " + t.Cobertura.Descripcion,
                    (hcs.Exists(el => el.Turno.Id == t.Id)) ? 1 : 0);
            }
        }

        public static void CargarDataGrid(DataGridView grd, EmpleadoDTO emp, PacienteDTO pac, DateTime desde, DateTime hasta)
        {
            grd.Rows.Clear();
            List<TurnoDTO> turnos = new List<TurnoDTO>();
            turnos = TurnoDAL.BuscarDni(emp, pac.Persona.Dni, desde, hasta);
            List<HistoriaClinicaDTO> hcs = new List<HistoriaClinicaDTO>();
            hcs = HistoriaClinicaDAL.Buscar(emp, pac);
            foreach (TurnoDTO t in turnos)
            {
                grd.Rows.Add(
                    (hcs.Exists(el => el.Turno.Id == t.Id)) ? MediTurno.Properties.Resources.feather_eye : null,
                    t.Id,
                    t.Medico.Empleado.Persona.Apellidos + " " + t.Medico.Empleado.Persona.Nombres,
                    t.Paciente.Persona.Apellidos + " " + t.Paciente.Persona.Nombres,
                    t.FechaHora.ToShortDateString(),
                    t.FechaHora.ToShortTimeString(),
                    (t.Cobertura.Id == 10) ? "Ninguna" : t.Cobertura.ObraSocial.Nombre + " - " + t.Cobertura.Descripcion,
                    (hcs.Exists(el => el.Turno.Id == t.Id)) ? 1 : 0);
            }
        }

        public static void Guardar(TurnoDTO tur, string desc, string arc)
        {
            HistoriaClinicaDTO hc = new HistoriaClinicaDTO(tur, desc, arc);
            if (HistoriaClinicaDAL.Guardar(hc))
            {
                MessageBox.Show(
                    "La Historia Clinica fue guardada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar La Historia Clinica.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, TurnoDTO tur, string desc, string arc)
        {
            HistoriaClinicaDTO hc = new HistoriaClinicaDTO(id, tur, desc, arc);
            if (HistoriaClinicaDAL.Editar(hc))
            {
                MessageBox.Show(
                    "La Historia Clinica fue modificada correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar la Historia Clinica.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
