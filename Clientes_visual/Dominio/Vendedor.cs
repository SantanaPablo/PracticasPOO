using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vendedor
    {
        public string nombre { get; set; }
        public string telefono { get; set; }

        public string mail { get; set; }

        public int id_vendedor { get; set; }    

        public override string ToString()
        {
            return nombre;
        }


    }
}
