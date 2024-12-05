using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06_metodoRecarga
{
    internal class Botella
    {
        // atributos
        private string material;
        private string color;
        private int capacidad;
        private int cantidadActual;

        // constructor
        public Botella(string material, string color)
        {
            this.material = material;
            this.color = color;
            capacidad = 100;
            cantidadActual = 0;
        }

        // propiedad
        public string Material 
        {
            get {  return material; } 
            
        }

        public string Color
        {
            get { return color; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        // metodo recargar()
        public float Recargar()
        {
            if (cantidadActual > 0)
            {
                int diferencia = capacidad - cantidadActual;
                float monto = (diferencia * 50) / 100;
                cantidadActual += diferencia;
                return monto;
            }

            cantidadActual = 100;
            return 50;
        }


    }
}
