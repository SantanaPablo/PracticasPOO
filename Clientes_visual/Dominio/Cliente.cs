using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombre_legal { get; set; }
        public string nombre_fantasia { get; set; }

        public string cuit { get; set; }

        public string iva { get; set; }

        public string domicilio { get; set; }

        public string localidad { get; set; }
        public string cod_postal { get; set; }

        public string provincia { get; set; }

        public string telefono { get; set; }
        public string mail { get; set; }

        public string cuenta_corriente { get; set; }

        public double descuento { get; set; }

        public TimeSpan horario { get; set;}

        public Vendedor vendedor { get; set; }

        public Transporte transporte { get; set; }

    }

}
