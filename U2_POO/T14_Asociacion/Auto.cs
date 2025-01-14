using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Asociacion
{
    internal class Auto
    {
        // Atributos privados
        private string marca;
        private Conductor conductor; // Asociacion con la clase conductor
        private Motor motor; // Composicion: el motor pertenece al auto


        // Propiedades publicas
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Conductor Conductor
        {
            get { return conductor; }
            set { conductor = value; } // se puede asignar un conductor

        }

        public Motor Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        // Constructor
        public Auto(string marca, int potenciaMotor)
        {
            this.marca = marca;
            this.motor = new Motor(potenciaMotor); // crea el motor como parte del auto
        }

        // Metodo para mostrar informacion del auto y su conductor
        public void Mostrar()
        {
            Console.WriteLine($"Auto: {Marca}");
            Motor.MostrarDetalle();
            if (conductor != null)
            {
                conductor.MostrarDetalles();
            }
            else
            {
                Console.WriteLine("Este auto no tiene conductor asignado");
            }
        }
    }
}
