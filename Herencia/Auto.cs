using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Auto : Vehiculo
    {

        public Auto() { 
            Chasis = new Chasis();
        }

        public Motor Motor { get; set; }
        public Chasis Chasis { get; }
    }
}
