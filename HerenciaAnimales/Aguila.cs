using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimales
{
    internal class Aguila : AnimalesSalvajes, IVolador
    {
        public string Volar()
        {
            return "El Águila vuela";
        }

        public override string Comunicarse()
        {
            return "soy un águila";
        }

    }
}
