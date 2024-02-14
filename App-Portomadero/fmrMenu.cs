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
        public fmrMenu(string role, string name)
        {
            InitializeComponent();
            rol = role;
            lbNombre.Text = name;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            fmrFactura factura = new fmrFactura(lbNombre.Text, null, "");
            factura.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            fmrPedido pedido = new fmrPedido(0, 0);
            pedido.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            fmrInicio inicio = new fmrInicio();
            inicio.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            fmrProducto producto = new fmrProducto(0, "");
            producto.Show();
        }

        private void btnListaFac_Click(object sender, EventArgs e)
        {
            fmrListaFacturas fmrLista = new fmrListaFacturas();
            fmrLista.Show();
        }
    }
}
