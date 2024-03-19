using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace App_Portomadero
{
    public partial class fmrMenu : Form
    {
        public string rol;
        string usuario;
        string nombre;
        public fmrMenu(string role, string user, string name)
        {
            InitializeComponent();
            rol = role;
            usuario = user;
            nombre = name;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            fmrInicio inicio = new fmrInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            fmrProducto producto = new fmrProducto(0, "",usuario,rol);
            producto.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            fmrListaClientes clientes = new fmrListaClientes(rol, usuario);
            clientes.Show();
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            fmrListaEmpleados listaEmpleados = new fmrListaEmpleados(usuario, rol);
            listaEmpleados.Show();
        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            fmrFactura factura = new fmrFactura(nombre, null, "");
            factura.Show();
        }

        private void btnPedido_Click_1(object sender, EventArgs e)
        {
            fmrPedido pedido = new fmrPedido(0, 0);
            pedido.Show();
        }

        private void btnListaFac_Click_1(object sender, EventArgs e)
        {
            fmrListaFacturas fmrLista = new fmrListaFacturas();
            fmrLista.Show();
        }

        private void btnListPed_Click_1(object sender, EventArgs e)
        {
            fmrListaPedidos fmrLista = new fmrListaPedidos();
            fmrLista.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            fmrListaCargos cargos = new fmrListaCargos(rol, usuario);
            cargos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            fmrListaUsuarios usuarios = new fmrListaUsuarios(usuario,rol);
            usuarios.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            fmrRoles roles = new fmrRoles();
            roles.Show();
        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            fmrProducto producto = new fmrProducto(0,"",usuario,rol);
            producto.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            fmrListaProductos productos = new fmrListaProductos(usuario,rol);
            productos.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            fmrListaCategorias categorias = new fmrListaCategorias(usuario, rol);
            categorias.Show();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            fmrIngredientes ingredientes = new fmrIngredientes(usuario,rol);
            ingredientes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmrInventario inventario = new fmrInventario(usuario);
            inventario.Show();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            fmrRecetas recetas = new fmrRecetas(usuario);
            recetas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrReserva reserva = new fmrReserva(usuario,"","");
            reserva.Show();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            fmrConfReserva reserva = new fmrConfReserva(usuario);
            reserva.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            fmrListaReservas reservas = new fmrListaReservas(usuario,rol);
            reservas.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            fmrMesas mesas = new fmrMesas(usuario,rol);
            mesas.Show();
        }
    }
}
