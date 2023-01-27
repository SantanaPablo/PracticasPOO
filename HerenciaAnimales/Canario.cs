using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimales
{
    internal class Canario : AnimalesDomesticos, IVolador
    {

        public override string Comunicarse()
        {
            return "Pio pio";
        }

        public string Volar()
        {
            return "El canario Vuela";
        }
    }
}
