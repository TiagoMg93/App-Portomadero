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
    public partial class fmrMesas : Form
    {
        public List<string> rutas = new List<string>();
        int conteo = 0;
        int ubicacionRuta;
        public string nuevaRuta;
        string usuario;
        string rol;
        public fmrMesas(string user,string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarMesa();
        }
        private void agregarMesa()
        {
            Button button = new Button();
            button.BackColor = System.Drawing.SystemColors.MenuBar;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.Color.Black;
            button.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            button.BackgroundImage = Properties.Resources.mesa__1_;
            button.Name = "button " + conteo;
            conteo += 1;
            button.Text = "Mesa " + conteo;
            button.Size = new System.Drawing.Size(81, 113);
            button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            button.UseVisualStyleBackColor = false;
            button.Click += new EventHandler(ClickButton);
            flpPanel.Controls.Add(button);
            rutas.Add(Properties.Resources.mesa__1_.ToString());
        }
        private void modificarMesa(Button button, string ruta, Form form)
        {
            fmrModificarMesa mesa = new fmrModificarMesa(button, ruta,this);
            mesa.FormClosed += mesa_formClosed;
            mesa.Show();
        }
        private void mesa_formClosed(object sender, FormClosedEventArgs e)
        {
            rutas[ubicacionRuta] = nuevaRuta;
        }
        private void ClickButton(object sender,EventArgs e)
        {
            Button botonClick = (Button)sender;
            string nombre = botonClick.Name;
            int indice = nombre.IndexOf(' ');
            ubicacionRuta = int.Parse(nombre.Substring(indice));
            modificarMesa((Button)sender,rutas[ubicacionRuta],this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrMesas_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            clsMesas mesas = new clsMesas();
            flpPanel.Controls.Clear();
            tbEliminar.Text = "";
            try
            {
                table = mesas.cargarEspacios();
                for(int espacio = 0; espacio < table.Rows.Count; espacio++)
                {
                    agregarMesa();
                    Button boton = flpPanel.Controls[espacio] as Button;
                    boton.Text = table.Rows[espacio][1].ToString();
                    boton.BackgroundImage = Image.FromFile(table.Rows[espacio][3].ToString());
                    rutas.Insert(espacio, table.Rows[espacio][3].ToString());
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la información de los espacios");
            }
}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                clsMesas mesas = new clsMesas();
                foreach(Button button in flpPanel.Controls)
                {
                    mesas.Pd_Nombre = button.Text;
                    mesas.Pd_Estado = "Disponible";
                    string nombre = button.Name;
                    int indice = nombre.IndexOf(' ');
                    int posicion = int.Parse(nombre.Substring(indice));
                    mesas.Pd_Ruta = rutas[posicion];
                    mesas.Pd_Modifica = usuario;
                    data = mesas.consultarMesa();
                    if(data.Rows.Count < 1)
                    {
                        mesas.guardarMesa();
                    }
                    else
                    {
                        mesas.actualizarMesa();
                        MessageBox.Show("Actualizar");
                    }
                }
                tbEliminar.Text = "";
                MessageBox.Show("Se guardo correctamente la información");
            }
            catch
            {
                MessageBox.Show("No se pudo guardar la información de los espacios");
            }
}

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(rol != "Administrador")
            {
                MessageBox.Show("Solo el administrador puede eliminar espacios");
            }
            else
            {
                if(tbEliminar.Text != "")
                {
                    try
                    {
                        clsMesas mesas = new clsMesas();
                        mesas.Pd_Nombre = tbEliminar.Text;
                        mesas.eliminarMesa();
                        tbEliminar.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo eliminar el espacio");
                    }
                }
            }
        }
    }
}
