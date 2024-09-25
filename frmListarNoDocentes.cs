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
    public partial class frmListarNoDocentes : Form
    {
        private List<ClassNoDocente> listaNoDocentes;
        public frmListarNoDocentes(List<ClassNoDocente> empleado)
        {
            InitializeComponent();
            listaNoDocentes = empleado ?? throw new ArgumentNullException(nameof(empleado));
            RenderizarDocentes();
        }
        
        private void RenderizarDocentes()
        {
            PanelRenderNoDocentes.Controls.Clear();

            if (listaNoDocentes == null || listaNoDocentes.Count == 0)
            {
                Label lblNoDocentes = new Label
                {
                    Text = "No hay empleados",
                    AutoSize = true,
                    ForeColor = Color.Red,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                PanelRenderNoDocentes.Controls.Add(lblNoDocentes);
            }
            else
            {
                int yPosition = 0;
                foreach (var docente in listaNoDocentes)
                {
                    Label lblDocente = new Label
                    {
                        Text = $"Nombre: {docente.Nombre}, Edad: {docente.Edad}, Puesto: {docente.Position}",
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };

                    PanelRenderNoDocentes.Controls.Add(lblDocente);
                    yPosition += lblDocente.Height + 10;

                }
            }
        }

    }
}
