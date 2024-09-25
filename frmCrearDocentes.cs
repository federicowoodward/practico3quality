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
    public partial class frmCrearDocentes : Form
    {
        private List<ClassDocente> listaDocentes;
        public frmCrearDocentes(List<ClassDocente> docentes)
        {
            InitializeComponent();
            listaDocentes = docentes ?? throw new ArgumentNullException(nameof(docentes));
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Nombre.Text;
                int edad = int.Parse(Edad.Text);
                string puesto = Puesto.Text;

                ClassDocente newDocente = new ClassDocente(nombre, edad, puesto);

                listaDocentes.Add(newDocente);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los datos ingresados no corresponde con el tipo de datos solicitados");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                MessageBox.Show("Docente creado con exito.");
                LimpiarControles();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {

            Nombre.Text = "";
            Edad.Text = "";
            Puesto.Text = "";
        }
    }
}
