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
    public partial class controlUsers : Form
    {
        conexionSQLN cn = new conexionSQLN();

    
        public controlUsers()
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

            dataGridView1.DataSource = cn.consultaDT();

        }

        private void controlUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //nom,ape,ci,tel,user,contra,log
            int enableLog;

            int indexBox = cmbCargos.SelectedIndex;
            string cargo;
            switch (indexBox)
            {
                case 0:
                    cargo = "Administrador";
                    break;
                case 1:
                    cargo = "Secretario/a";
                    break;
                case 2:
                    cargo = "Tecnico";
                    break;
                case 3:
                    cargo = "Ventas";
                    break;
                case 4:
                    cargo = "Admr. Ventas";
                    break;
                case 5:
                    cargo = "Otro";
                    break;
                default:
                    cargo = "POR DEFECTO??";
                    break;
            }

            if (checkBox1.Checked == true)
            {
                enableLog = 1;
            }
            else
            {
                enableLog = 0;
            }
            cn.insertarRegistro(txtNombre.Text, txtApellido.Text, txtCi.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text, enableLog.ToString(),cargo ) ;
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int enableLog;
            int indexBox = cmbCargos.SelectedIndex;
            string cargo;
            switch (indexBox)
            {
                case 0:
                    cargo = "Administrador";
                    break;
                case 1:
                    cargo = "Secretario/a";
                    break;
                case 2:
                    cargo = "Tecnico";
                    break;
                case 3:
                    cargo = "Ventas";
                    break;
                case 4:
                    cargo = "Admr. Ventas";
                    break;
                case 5:
                    cargo = "Otro";
                    break;
                default:
                    cargo = "POR DEFECTO??";
                    break;
            }


            if (checkBox1.Checked == true)
            {
                enableLog = 1;
            }
            else
            {
                enableLog = 0;
            }
            cn.modUsuario(txtNombre.Text, txtApellido.Text, txtCi.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text, enableLog.ToString(),cargo);
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cn.eliminarUsuario(txtCi.Text);
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultaDT();
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            int enableLog;
            if (checkBox1.Checked == true)
            {
                txtUsuario.Visible = true;
                txtContrasena.Visible = true;
                label6.Visible = true;
                usuario.Visible = true;
        
                    enableLog = 1;
               
              
            }
            else
            {
                txtUsuario.Visible = false;
                txtContrasena.Visible = false;
                label6.Visible = false;
                usuario.Visible = false;
                    enableLog = 0;

            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
