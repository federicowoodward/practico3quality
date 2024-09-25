using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class ClassAlumno : ClassPersona, IRangoEdades
    {
        public string Major { get; set; }
        public string Status { get; set; }
        public ClassAlumno() : base()
        {
            Major = "desconocido";
            Status = "desconocido";
        }
        public ClassAlumno(string nombre, int edad, string carrera, string estado) : base(nombre, edad)
        {
            Major = carrera;
            Status = estado;
        }
        public override void GetInfoPersona()
        {
            Console.WriteLine("{0} es alumno de la carrera {1} en estado: {2}", Nombre, Major, Status);
        }
        public string RangoEdades()
        {
            if (Edad < 18)
                return "menor de edad";
            else if (Edad < 30)
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
