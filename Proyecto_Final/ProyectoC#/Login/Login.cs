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
using MaterialSkin;
using MaterialSkin.Controls;
namespace Login
{
    public partial class Login : MaterialForm
    {
        conexionSQLN cn = new conexionSQLN();
        public Login()
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
                TextShade.WHITE

                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            //ventanaPrincipal fVP = new ventanaPrincipal(xtUser.Text, txtPass.Text);

            //fVP.lblUsuario.Text = txtUser.Text;
            //fVP.lblCi.Text = txtPass.Text;
    

            if (cn.conSQL(txtUser.Text, txtPass.Text)==1)
            {
                MessageBox.Show("Se ha encontrado las credenciales");
                this.Hide();
                //ventanaPrincipal v1 = new ventanaPrincipal(txtUser.Text, txtPass.Text);
                //PruebaMenu v1 = new PruebaMenu(txtPass.Text, txtPass.Text);
                Menu_prueba2 v1 = new Menu_prueba2(txtUser.Text,txtPass.Text);
                v1.Show();

            }
            else
            {
                MessageBox.Show("No se ha encontrado las credenciales");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
