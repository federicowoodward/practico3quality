using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmListarExAlumnos : Form
    {
        private List<ClassAlumno> listaAlumnos;
        public frmListarExAlumnos(List<ClassAlumno> exalumnos)
        {
            InitializeComponent();
            listaAlumnos = exalumnos ?? throw new ArgumentNullException(nameof(exalumnos));
            RenderizarExAlumnos();
        }

        private void RenderizarExAlumnos()
        {
            panelRendeExAlumnos.Controls.Clear();

            var exAlumnos = listaAlumnos?.FindAll(a => a.Status == "Finalizado");

            if (exAlumnos == null || exAlumnos.Count == 0)
            {
                Label lblNoDocentes = new Label
                {
                    Text = "No hay ex alumnos",
                    AutoSize = true,
                    ForeColor = Color.Red,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                panelRendeExAlumnos.Controls.Add(lblNoDocentes);
            }
            else
            {
                int yPosition = 0;
                foreach (var exalumnos in exAlumnos)
                {
                    Label lblExAlumnos = new Label
                    {
                        Text = $"Nombre: {exalumnos.Nombre}, Edad: {exalumnos.Edad}, Carrera: {exalumnos.Major}",
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    panelRendeExAlumnos.Controls.Add(lblExAlumnos);
                    yPosition += lblExAlumnos.Height + 10;

                }
            }
        }
    }
}
