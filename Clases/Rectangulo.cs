using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_Clases_y_Objetos
{
    class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return Base * Altura;           
        }
    }
}
