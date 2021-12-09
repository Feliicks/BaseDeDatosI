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
using MaterialSkin;
using MaterialSkin.Controls;
namespace Login
{
    public partial class Inventario : Form
    {

        conexionSQLN cn = new conexionSQLN();
        public Inventario()
        {
            InitializeComponent();

            // Cree un administrador de temas de materiales y agregue el formulario para administrar (this)
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Configurar esquema de color
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE

            //    );
            dgvInventario.DataSource = cn.consultainvDT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            //cn.insertarRegistroInv(txtPrec.Text, txtCat.Text, txtPrec.Text, txtCant.Text, txtCod.Text);
            cn.insertarRegistroInv(txtProd.Text, txtCat.Text, txtPrec.Text, txtCant.Text, txtCod.Text);
            dgvInventario.DataSource = cn.consultainvDT();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cn.eliminarUsuarioInv(txtCod.Text);
            dgvInventario.DataSource = cn.consultainvDT();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            cn.modUsuarioInv(txtPrec.Text, txtCat.Text, txtPrec.Text, txtCant.Text, txtCod.Text);
            dgvInventario.DataSource = cn.consultainvDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvInventario.DataSource = cn.consultainvDT();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
