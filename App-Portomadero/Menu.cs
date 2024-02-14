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
    public partial class Menu : Form
    {
        public string rol;
        public Menu(string role, string name)
        {
            InitializeComponent();
            rol = role;
            lbNombre.Text = name;
        }
    }
}
