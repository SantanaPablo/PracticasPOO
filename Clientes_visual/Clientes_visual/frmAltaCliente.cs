using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes_visual
{
    public partial class frmAltaCliente : Form
    {

        private Cliente cliente = null;
        public frmAltaCliente()
        {
            InitializeComponent();
            Text = "Agregar Cliente";
        }

        public frmAltaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            Text = "Modificar Cliente";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {    ClienteNegocio clienteNegocio= new ClienteNegocio();
            try
            {   

                if (cliente == null) cliente = new Cliente();

                cliente.nombre_legal = txbNombreLegal.Text;
                cliente.nombre_fantasia = txbNombreFantasia.Text;
                cliente.cuit = txbCuit.Text;
                cliente.iva = txbIVA.Text;
                cliente.domicilio= txbDomicilio.Text;
                cliente.vendedor = (Vendedor)cboVendedor.SelectedItem;

                if (cliente.id_cliente != 0)
                {
                    clienteNegocio.Modificar(cliente);
                    MessageBox.Show("cliente: " + cliente.nombre_legal + " modificado");


                }
                else
                {
                    clienteNegocio.Agregar(cliente);
                    MessageBox.Show("cliente: " + cliente.nombre_legal + " agredado");
                }
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            VendedorNegocio vendedorNegocio= new VendedorNegocio();
            cboVendedor.DataSource= vendedorNegocio.Listar();
            cboVendedor.ValueMember = "id_vendedor";
            cboVendedor.DisplayMember = "nombre";

            if (cliente != null)
            {
                txbNombreLegal.Text= cliente.nombre_legal;
                txbNombreFantasia.Text = cliente.nombre_fantasia;
                txbCuit.Text = cliente.cuit;
                txbIVA.Text = cliente.iva;
                txbDomicilio.Text = cliente.domicilio;
                cboVendedor.SelectedValue = cliente.vendedor.id_vendedor;

            }

        }
    }
}
