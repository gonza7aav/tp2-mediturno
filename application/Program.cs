using System;
using System.Windows.Forms;
using MediTurno.CapaDatos;
using System.Data.Entity;

namespace MediTurno
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MediTurnoEntities>());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaPresentacion.frmPrincipal());
        }
    }
}
