using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimales
{
    internal class AnimalesDomesticos : Animal
    {

        public string Nombre { get; set; }

        public override string ToString()
        {
            return "Animal: " + Nombre;
        }

    }
}
