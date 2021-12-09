using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Login
{
    public partial class RegCliente : MaterialForm

    {


        conexionSQLN cn = new conexionSQLN();
        public RegCliente(string codigoCliente)
        {


            InitializeComponent();

            // Cree un administrador de temas de materiales y agregue el formulario para administrar (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configurar esquema de color
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue400, Primary.Blue500,
            Primary.Blue500, Accent.LightBlue200,
            TextShade.WHITE);

            txtCodigo.Text= codigoCliente;


        }

        public string Nombre { get; set; }
        public string Codigo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void RegCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            cn.insertarCliente(txtNombre.Text, txtTelefono.Text, txtDir.Text, txtCorreo.Text, txtCodigo.Text);
            this.Close();
            MessageBox.Show("Cliente Registrad" +
                "o");
            Nombre =  txtNombre.Text;
            Codigo = txtCodigo.Text;


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
