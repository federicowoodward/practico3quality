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
    public partial class frmCrearAlumnos : Form
    {
        private List<ClassAlumno> listaAlumnos;
        public frmCrearAlumnos(List<ClassAlumno> alumnos)
        {
            InitializeComponent();
            listaAlumnos = alumnos ?? throw new ArgumentNullException(nameof(alumnos));
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Nombre.Text;
                int edad = int.Parse(Edad.Text);
                string carrera = Carrera.Text;
                string estado = cmbEstado.Text;

                ClassAlumno newAlumno = new ClassAlumno(nombre, edad, carrera, estado);

                listaAlumnos.Add(newAlumno);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los datos ingresados no corresponde con el tipo de datos solicitados");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                MessageBox.Show("Alumno creado con exito.");
                LimpiarControles();
            }

        }

        private void LimpiarControles()
        {

            Nombre.Text = "";
            Edad.Text = "";
            Carrera.Text = "";
            cmbEstado.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

    }
}
