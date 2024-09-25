using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            frmAcceso fAcceso = new frmAcceso();

            if (fAcceso.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fAcceso.Close();
                Application.Run(new frmMenuPrincipal());
            }
        }
    }
}
