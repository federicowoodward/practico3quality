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
    public partial class frmCrearNoDocentes : Form
    {
        private List<ClassNoDocente> listaNoDocentes;
        public frmCrearNoDocentes(List<ClassNoDocente> empleado)
        {
            InitializeComponent();
            listaNoDocentes = empleado ?? throw new ArgumentNullException(nameof(empleado));
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Nombre.Text;
                int edad = int.Parse(Edad.Text);
                string puesto = Puesto.Text;

                ClassNoDocente newNoDocente = new ClassNoDocente(nombre, edad, puesto);

                listaNoDocentes.Add(newNoDocente);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los datos ingresados no corresponde con el tipo de datos solicitados");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                MessageBox.Show("Empleado creado con exito.");
                LimpiarControles();
            }

        }

        private void LimpiarControles()
        {

            Nombre.Text = "";
            Edad.Text = "";
            Puesto.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

    }
}
