using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Negocio

{
    public class ClienteNegocio
    {

        public List<Cliente> listarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();  
            AccesoDatos accesodatos = new AccesoDatos();


            try
            {
                accesodatos.SetearConsulta("Select id_cliente, nombre_legal, nombre_fantasia, cuit, iva, domicilio, V.nombre as Vendedor, V.id_vendedor as id_vendedor FROM Clientes C, vendedores V where V.id_vendedor = C.id_vendedor");
                accesodatos.EjecutarLectura();


                while (accesodatos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.id_cliente= (int)accesodatos.Lector[aux.id_cliente];
                    aux.nombre_legal = (string)accesodatos.Lector["nombre_legal"];
                    aux.nombre_fantasia = (string)accesodatos.Lector["nombre_fantasia"];
                    aux.cuit = (string)accesodatos.Lector["cuit"];
                    aux.iva = (string)accesodatos.Lector["iva"];
                    aux.domicilio = (string)accesodatos.Lector["domicilio"];
                    //aux.localidad = (string)accesodatos.Lector["localidad"];
                    //aux.horario = (TimeSpan)accesodatos.Lector["horario"];
                    aux.vendedor = new Vendedor();
                    aux.vendedor.nombre = (string)accesodatos.Lector["Vendedor"];
                    aux.vendedor.id_vendedor = (int)accesodatos.Lector["id_vendedor"];

                    listaClientes.Add(aux);

                }


                return listaClientes;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { accesodatos.CerrarConexion(); }


    }

     public void Agregar (Cliente nuevo)

        {
            AccesoDatos accesoDatos= new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("Insert into Clientes (nombre_legal, nombre_fantasia, cuit, iva, domicilio,id_vendedor) values (@nombre_legal, @nombre_fantasia, @cuit, @iva, @domicilio, @id_vendedor)");
                accesoDatos.SetearParametro("@id_cliente", nuevo.id_cliente);
                accesoDatos.SetearParametro("@nombre_legal", nuevo.nombre_legal);
                accesoDatos.SetearParametro("@nombre_fantasia", nuevo.nombre_fantasia);
                accesoDatos.SetearParametro("@cuit", nuevo.cuit);
                accesoDatos.SetearParametro("@iva", nuevo.iva);
                accesoDatos.SetearParametro("@domicilio", nuevo.domicilio);
                accesoDatos.SetearParametro("@id_vendedor", nuevo.vendedor.id_vendedor);

                accesoDatos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public void Modificar(Cliente cliente)
        { AccesoDatos accesoDatos= new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("update Clientes set nombre_legal = @nombre_legal, nombre_fantasia = @nombre_fantasia, cuit = @cuit, iva = @iva, domicilio = @domicilio, id_vendedor = @id_vendedor Where id_cliente = @id_cliente");
                accesoDatos.SetearParametro("@id_cliente", cliente.id_cliente);
                accesoDatos.SetearParametro("@nombre_legal", cliente.nombre_legal);
                accesoDatos.SetearParametro("@nombre_fantasia", cliente.nombre_fantasia);
                accesoDatos.SetearParametro("@cuit", cliente.cuit);
                accesoDatos.SetearParametro("@iva", cliente.iva);
                accesoDatos.SetearParametro("@domicilio", cliente.domicilio);
                accesoDatos.SetearParametro("@id_vendedor", cliente.vendedor.id_vendedor);

                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoDatos.CerrarConexion();
            }

        }

    }
}
