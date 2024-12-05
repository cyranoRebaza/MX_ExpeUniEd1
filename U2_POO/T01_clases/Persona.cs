using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T01_clases
{
    internal class Persona
    {
        // Persona: Edad, sueldo , nombre

        // Atributos o miembros
        private int edad;
        private float sueldo;
        private string nombre;


        // Metodo set y get
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetSueldo(float sueldo)
        {
            this.sueldo = sueldo;
        }

        public float GetSueldo()
        {
            return sueldo;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }





    }
}
