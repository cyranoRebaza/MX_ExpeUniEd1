using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T02_propiedadesLarga
{
    internal class Botella
    {
        // Atributos
        private int capacidad;
        private string color;
        private string material;
        private int cantidaActual;

        // Propiedades - formar larga: donde puedo manipular el get y el set
        public int Capacidad
        {
            get { return capacidad; }  // lectura
            set { capacidad = value; } // escritura
        }

        public string Color
        {
            get { return color; } // lectura
        }

        public string Material
        {
            get { return material; } // solo lectura
        }

        public int cantidadActual
        {
            get { return cantidaActual; }
        }

        public int MyProperty { get; set; }

    }
}
