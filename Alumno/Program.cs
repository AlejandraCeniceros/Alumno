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

            Console.WriteLine("Direccion:" + alumni1.Direccion);
            Console.WriteLine("Nacimiento:" + alumni1.Nacimiento);
            Console.WriteLine("Telefono:" + alumni1.Telefono);

            Console.Read();

        }
    }
}
