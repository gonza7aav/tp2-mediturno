using MediTurno.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTurno.CapaLogica
{
    class Backup
    {
        public static bool RealizarBackup(string ubicacion)
        {
            string nombre = "MediTurno_" + DateTime.Now.Year.ToString() + "_"
                + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_"
                + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_"
                + DateTime.Now.Second.ToString() + ".bak";

            var stn = new Settings();
            var con = new SqlConnection(stn.ConnectionDB);
            var cmd = new SqlCommand("BACKUP DATABASE MediTurno TO DISK='" + ubicacion + "/" + nombre + "'", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }

        public static bool RestaurarBackup(string archivo)
        {
            var stn = new Settings();
            var con = new SqlConnection(stn.ConnectionDB);
            var cmd = new SqlCommand("RESTORE DATABASE MediTurno FROM DISK='" + archivo + "'", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                con.Close();
                return false;
            }
        }
    }
}
