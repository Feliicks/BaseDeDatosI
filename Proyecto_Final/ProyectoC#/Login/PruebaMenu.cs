using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;
using System.Drawing.Printing;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Login
{
    public partial class Menu_prueba2 : MaterialForm
    {
        public Menu_prueba2(string usuarioL,string passL)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200,
            TextShade.WHITE
           

            );;
            label1.Text = DateTime.Now.ToShortTimeString() + " : "+DateTime.Now.ToShortDateString();
            lblU.Text = usuarioL;
            lblP.Text = passL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ventanaPrincipal(lblU.Text,lblP.Text));
        }
        private void AbrirFormHijo(object formPrueba)
        {
            if (this.pnlVentana.Controls.Count > 0)
                this.pnlVentana.Controls.RemoveAt(0);
            Form fh = formPrueba as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlVentana.Controls.Add(fh);
            this.pnlVentana.Tag = fh;
            fh.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new controlUsers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inventario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Rastrear());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login v1 = new Login();
            this.Close();
            v1.Show();
            
        }
    }
}
