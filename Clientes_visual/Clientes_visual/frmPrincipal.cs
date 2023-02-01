using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Clientes_visual
{
    public partial class frmPrincipal : Form
    {   

        private List<Cliente> listClientes = new List<Cliente>();
        private Cliente cliente = new Cliente();
        private List<Vendedor> listVendedores = new List<Vendedor>();
        private Vendedor vendedor= new Vendedor();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(Cliente cliente)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            listClientes = negocio.listarClientes();
            VendedorNegocio vendedorNegocio= new VendedorNegocio();
            listVendedores = vendedorNegocio.Listar();
            bindingSource1.DataSource = listClientes;
            
            

            Cargar();



        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            cliente = (Cliente)bindingSource1.Current;
            txbNombreFantasia.Text = cliente.nombre_fantasia;
            txbNombre_Legal.Text = cliente.nombre_legal;
            txbCuit.Text = cliente.cuit;
            txbIva.Text = cliente.iva;
            txbDomicilio.Text = cliente.domicilio;
            txbVendedor.Text = cliente.vendedor.nombre;

            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCliente alta = new frmAltaCliente();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Cliente seleccionado;
            seleccionado = (Cliente)bindingSource1.Current;

            frmAltaCliente modificar = new frmAltaCliente(seleccionado);
            modificar.ShowDialog();
            Cargar();

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            Cargar();

        }
    }
}