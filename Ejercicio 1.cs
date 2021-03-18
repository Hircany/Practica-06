
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    public class Profesor : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Hircany";
            persona1.Edad = 18;
            Console.WriteLine("Los datos de la persona son: ");
            persona1.Imprimir();

            Empleado empleado1 = new Profesor();
            empleado1.Nombre = "Eribel";
            empleado1.Edad = 18;
            empleado1.Sueldo = 2524;
            Console.WriteLine("Los datos del profesor son: ");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}