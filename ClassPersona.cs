using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class ClassPersona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Edad
        {
            get => edad;
            set
            {
                if (value >= 0)
                    edad = value;
                else
                    MessageBox.Show("la edad no puede ser negativa.");
            }
        }

        public ClassPersona()
        {
            nombre = "desconocido";
            edad = 0;
        }

        public ClassPersona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public abstract void GetInfoPersona();

        public virtual void GetCondition()
        {
            Console.WriteLine("{0} es una Persona", Nombre);
        }
    }
}
