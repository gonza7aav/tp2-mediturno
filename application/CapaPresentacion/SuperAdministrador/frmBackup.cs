using MediTurno.CapaLogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediTurno.CapaPresentacion.SuperAdministrador
{
    public partial class frmBackup : Form
    {
        private frmPrincipal Padre;

        public frmBackup(frmPrincipal padre)
        {
            InitializeComponent();
            Padre = padre;
        }


        private void btnRealizarBackup_Click(object sender, EventArgs e)
        {
            DialogResult res = dlgUbicacion.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (Backup.RealizarBackup(dlgUbicacion.SelectedPath))
                {
                    MessageBox.Show(
                        "Se ha realizado el backup de forma exitosa",
                        "Backup",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Se produjo un error realizando el backup",
                        "Backup",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            DialogResult res = dlgArchivo.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (Backup.RestaurarBackup(dlgArchivo.FileName))
                {
                    MessageBox.Show(
                        "Se ha restaurado el backup de forma exitosa",
                        "Backup",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Se produjo un error restaurando el backup",
                        "Backup",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
