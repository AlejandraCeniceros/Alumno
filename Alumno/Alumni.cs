using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Alumni
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumni()
        {
            Matricula = "sin asignar";
            Nombre = "Pendiente";
        }

        public Alumni(string nacimiento, string direccion, string telefono)
        {
            Matricula = "sin asignar";
            Nombre = "Pendiente";
            Nacimiento = nacimiento;
            Direccion = direccion;
            Telefono = telefono; 

        }

        public Alumni(string nombre, string matricula)
        {

        }
    }
}
