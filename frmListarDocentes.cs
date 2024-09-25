using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1s;

namespace WindowsFormsApp1
{
    public partial class frmListarDocentes : Form
    {
        private List<ClassDocente> listaDocentes;
        private CRUDdocentes crudDocentes;
        public frmListarDocentes(List<ClassDocente> docentes)
        {
            InitializeComponent();
            listaDocentes = docentes ?? throw new ArgumentNullException(nameof(docentes));
            crudDocentes = new CRUDdocentes();
            RenderizarDocentes();
        }
        private void RenderizarDocentes()
        {

            PanelRenderDocentes.Controls.Clear();

            if (listaDocentes == null || listaDocentes.Count == 0)
            {
                Label lblNoAlumnos = new Label
                {
                    Text = "No hay Docentes",
                    AutoSize = true,
                    ForeColor = Color.Red,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                PanelRenderDocentes.Controls.Add(lblNoAlumnos);
            }
            else
            {
                int yPosition = 0;
                foreach (var alumno in listaDocentes)
                {
                    Label lblAlumno = new Label
                    {
                        Text = $"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}",
                        AutoSize = true,
                        Location = new Point(10, yPosition)
                    };
                    PanelRenderDocentes.Controls.Add(lblAlumno);
                    yPosition += lblAlumno.Height + 10;
                }
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {

        }

        private async void cargar_Click(object sender, EventArgs e)
        {
            try
            {
                bool allAdded = true;
                foreach (var docente in listaDocentes)
                {
                    if (docente != null)
                    {
                        bool added = await Task.Run(() => crudDocentes.AgregarDocente(docente));
                        if (!added)
                        {
                            allAdded = false;
                            MessageBox.Show($"No se pudo agregar el docente: {docente.Nombre}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        allAdded = false;
                        MessageBox.Show("Se encontró un docente nulo en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (allAdded)
                {
                    MessageBox.Show("Todos los docentes fueron agregados exitosamente a la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaDocentes.Clear();
                    RenderizarDocentes();
                }
                else
                {
                    MessageBox.Show("Algunos docentes no pudieron ser agregados. Por favor, revise la lista e intente nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar docentes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
