using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Asociacion
{
    internal class Garaje
    {
        // Atributos privados
        private string nombre;
        private List<Auto> autos;

        // Propiedades publicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Auto> Autos
        {
            get { return autos; }
            set { autos = value; }
        }

        // Constructor
        public Garaje(string nombre)
        {
            this.nombre = nombre;
            this.autos = new List<Auto>();
        }

        // Metodo para agregar un solo auto
        public void AgregarAuto(Auto auto)
        {
            Autos.Add(auto);
        }

                
        // Metodo para mostrar los autos del garaje
        public void MostrarAutos()
        {
            Console.WriteLine($"Garaje: {Nombre}");
            if( Autos.Count > 0 )
            {
                Console.WriteLine("Contiene los siguientes autos");
                foreach (var auto in Autos)
                {
                    auto.Mostrar();
                }
            }
            else
            {
                Console.WriteLine("El garaje no tiene autos");
            }

            Console.WriteLine("");
               
        }
        
    }
}
