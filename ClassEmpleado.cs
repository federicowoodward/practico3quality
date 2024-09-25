using System;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class ClassEmpleado : ClassPersona
    {
        public string Position { get; set; }
        public int Seniority { get; set; }
        public double Salary { get; set; }
        public ClassEmpleado() : base()
        {
            Position = "desconocido";
            Seniority = 0;
            Salary = 0.0;
        }
        public ClassEmpleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
            Position = puesto;
        }
        public override void GetInfoPersona()
        {
            Console.WriteLine("{0} es un empleado del puesto: {1}", Nombre, Position);
        }
    }
}
