using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF03_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaro una variable fecha tipo DateTipe con el  constructor por defecto
            DateTime fecha = new DateTime();

            Console.WriteLine($"la fecha es: {fecha.ToString()}");

            // declaro una variable fecha2 de tipo DateTipe con constructor con valores iniciales 
            DateTime fecha2 = new DateTime(2004, 4, 1);
            Console.WriteLine($"la fecha es: {fecha2.ToString()}");

            // Declaro una variable sin llamar al constructor --> llamando DateTime.Now
            DateTime fecha3 = DateTime.Now;
            Console.WriteLine($"la fecha es: {fecha3.ToString()}");

            // otros metodos para mostrar la fecha
            Console.WriteLine($"la fecha es: {fecha3.AddDays(5)}"); // agrega 5 dias
            Console.WriteLine($"la fecha es: {fecha3.ToShortDateString()}"); // fecha corta formato string
            Console.WriteLine($"la fecha es: {fecha3.ToShortTimeString()}"); // hora corta formato string
            Console.WriteLine($"la fecha es: {fecha3.ToString("dd/MM/yyyy")}"); // formato personalizado
            Console.ReadKey();
        }
    }
}
