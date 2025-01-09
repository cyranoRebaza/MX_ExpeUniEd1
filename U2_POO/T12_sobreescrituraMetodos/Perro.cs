using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_sobreescrituraMetodos
{
    internal class Perro : AnimalDomestico
    {
        // override: sobreescrribo el metodo comunicarse()
        public override string Comunicarse()
        {
            return "Se comunica haciendo: Guau guau";
        }
    }
}
