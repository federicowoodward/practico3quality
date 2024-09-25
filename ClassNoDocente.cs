using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class ClassNoDocente : ClassEmpleado, IRangoEdades
    {
        public ClassNoDocente() : base()
        {
        }

        public ClassNoDocente(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }

        public string RangoEdades()
        {
            if (Edad < 18)
                return "menor de edad con autorización de los padres";
            else if (Edad < 30)
                return "jóvenes";
            else if (Edad < 40)
                return "adulto joven";
            else
                return "adulto";
        }
    }
}
