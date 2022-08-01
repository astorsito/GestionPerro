using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPerro
{
    public class Perro
    {
        public string Nombre { set; get; }
        public string Raza { set; get; }
        public string Color { set; get; }
        public int Edad { set; get; }

        public Perro()
        {
        }

        public Perro(string nombre, string raza, string color, int edad)
        {
            Nombre = nombre;
            Raza = raza;
            Color = color;
            Edad = edad;
        }
    }
}
