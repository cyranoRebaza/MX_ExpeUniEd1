using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_sobreescrituraMetodos
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        // sobreescribo el metodo ToString
        public override string ToString()
        {
            // return base.ToString();
            return $"el nombre del animal domestico es: {Nombre}";
        }
    }
}
