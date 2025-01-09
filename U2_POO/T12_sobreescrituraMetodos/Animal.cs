using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_sobreescrituraMetodos
{
    internal class Animal
    {
        // virtual: para sobreescribir el metodo comunicarse() en cada animal que herede el metodo
        public virtual string Comunicarse()
        {
            return "Se comunica: hacen ruido..";
        }
    }
}
