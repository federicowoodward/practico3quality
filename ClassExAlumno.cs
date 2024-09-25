using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public sealed class ClassExAlumno : ClassAlumno
    {
        public double GPA { get; set; }

        public ClassExAlumno() : base()
        {
            GPA = 0.0;
        }

        public ClassExAlumno(string nombre, int edad, string carrera, string estado, double promedio) : base(nombre, edad, carrera, estado)
        {
            GPA = promedio;
        }

        public override void GetCondition()
        {
            Console.WriteLine("Exalumno con promedio de {0}", GPA);
        }
    }
}
