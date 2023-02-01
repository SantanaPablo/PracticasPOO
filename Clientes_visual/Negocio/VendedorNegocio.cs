using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VendedorNegocio
    {
       List<Vendedor> listVendedores = new List<Vendedor>();
        public List<Vendedor> Listar()
        {
            AccesoDatos accesoDatos= new AccesoDatos();
            accesoDatos.SetearConsulta("Select nombre, telefono, mail, id_vendedor FROM vendedores");
            accesoDatos.EjecutarLectura();
            
            while (accesoDatos.Lector.Read())
            {
                Vendedor aux = new Vendedor();
                aux.nombre = (string)accesoDatos.Lector["nombre"];
                aux.telefono = (string)accesoDatos.Lector["telefono"];
                aux.mail = (string)accesoDatos.Lector["mail"];
                aux.id_vendedor = (int)accesoDatos.Lector["id_vendedor"];

                listVendedores.Add(aux);
            }

            return listVendedores;
        }




    }
}
