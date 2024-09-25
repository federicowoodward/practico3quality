using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1s
{
    public class ClassDocente : ClassEmpleado, IRangoEdades
    {
        public ClassDocente() : base()
        {
        }
        public ClassDocente(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {
        }
        public string RangoEdades()
        {
            if (Edad < 30)
                return "jóvenes";       
            else if (Edad < 40)
                return "adulto joven";
            else if (Edad < 60)
                return "adulto";
            else
                return "adulto mayor";
        }
    }
}
