using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_constructoresDesctructores
{
    internal class Botella
    {
        // Atributos
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        // constructor - valores iniciales
        public Botella(string color, string material)
        {
            capacidad = 100;
            this.color = color;
            this.material = material;
            cantidadActual = 0;
            
        }

        // propiedades
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public string Color
        {
            get { return color; }
        }

        public string Material
        {
            get { return material; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }
    }
}
