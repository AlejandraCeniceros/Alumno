using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumni alumni1 = new Alumni();
            alumni1.Direccion = "452 Col centro";
            alumni1.Nacimiento = "30/08/00";
            alumni1.Telefono = "644 1 29 55 71";


            Console.WriteLine("Alumno1:" );
            Console.WriteLine("Nombre:" + alumni1.Nombre);
            Console.WriteLine("Matricula:" + alumni1.Matricula);

            Alumni alumni2 = new Alumni();
            alumni2.Nombre = "pedro";
            alumni2.Matricula = "412365";

            Console.WriteLine("Alumno2:");
            Console.WriteLine("Nombre:" + alumni2.Nombre);
            Console.WriteLine("Matricula:" + alumni2.Matricula);

            Alumni alumni3 = new Alumni("Ana", "412563");
            Console.WriteLine("Alumno3:");
            Console.WriteLine("Nombre:" + alumni3.Nombre);
            Console.WriteLine("Matricula:" + alumni3.Matricula);


            Console.Read();

        }
    }
}
