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
    public partial class Cliente : MaterialForm
    {
        conexionSQLN cn = new conexionSQLN();
        public Cliente()
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


            dataGridView1.DataSource = cn.consultaClienteDT();

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
