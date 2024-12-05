using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_propiedadReducida
{
    internal class Articulo
    {
        // Atributos
        private int codigoMarca;

        // Propiedades reducida: atajo PROP TAB TAB
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }

        // Propiedad extendida
        public int CodidoMarca
        {
            get { return codigoMarca; }
            set 
            {

                // validar el seteo de codigo de marca
                if (value > 0 && value < 11)
                {
                    codigoMarca = value;
                }
                else
                {
                    codigoMarca = -1;
                }
                 
            }
        }


    }
}
