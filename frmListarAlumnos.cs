using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmListarAlumnos : Form
    {
        internal List<ClassAlumno> listaAlumnos; 

        public frmListarAlumnos(List<ClassAlumno> alumnos)
        {
            InitializeComponent();
            listaAlumnos = alumnos ?? throw new ArgumentNullException(nameof(alumnos));
            RenderizarAlumnos();
        }

        private void RenderizarAlumnos()
        {
            var alumnosCursando = listaAlumnos?.FindAll(a => a.Status == "Cursando");

            PanelRenderAlumnos.Controls.Clear();

            // Verifica si la lista de alumnos cursando está vacía o nula
            if (alumnosCursando == null || alumnosCursando.Count == 0)
            {
                Label lblNoAlumnos = new Label
                {
                    Text = "No hay alumnos",
                    AutoSize = true,
                    ForeColor = Color.Red, 
                    TextAlign = ContentAlignment.MiddleCenter
                };

                PanelRenderAlumnos.Controls.Add(lblNoAlumnos);
            }
            else
            {
                int yPosition = 0;
                foreach (var alumno in alumnosCursando)
                {
                    Label lblAlumno = new Label
                    {
                        Text = $"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}, Carrera: {alumno.Major}, Estado: {alumno.Status}",
                        AutoSize = true,
                        Location = new Point(10, yPosition) // Ajusta la ubicación
                    };
                    PanelRenderAlumnos.Controls.Add(lblAlumno);
                    yPosition += lblAlumno.Height + 10;
                }
            }
        }
    }
}
