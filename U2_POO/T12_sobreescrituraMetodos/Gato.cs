using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_sobreescrituraMetodos
{
    internal class Gato : AnimalDomestico
    {
        // override: sobreescribo el metodo Comunicarse()
        public override string Comunicarse()
        {
            return " Se comunica haciendo: miau miau";  
        }
    }
}
