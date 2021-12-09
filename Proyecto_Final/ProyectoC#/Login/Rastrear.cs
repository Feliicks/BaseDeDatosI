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
    public partial class Rastrear : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public Rastrear()
        {
            InitializeComponent();

            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue400, Primary.Blue500,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //    )
            //    ;

          //  dtgTabla.DataSource = cn.multiTablaAD(cmbVista.SelectedIndex);




        }

        private void Rastrear_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgTabla.DataSource = cn.multiTablaAD(cmbVista.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string forma;
            comboBox1.Cursor = default;
            txtUPF.Visible = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtUPF.ForeColor = Color.Gray;
                    txtUPF.Text = "Introduzca codigo de usuario";
                    
                break;
                case 1:
                    txtUPF.ForeColor = Color.Gray;
                    txtUPF.Text = "Introduzca codigo de cliente";
                    break;
                case 2:
                    txtUPF.ForeColor = Color.Gray;
                    txtUPF.Text = "Introduzca el numero de factura";
                    break;
                default:
                    txtUPF.ForeColor = Color.Gray;
                    txtUPF.Text = "";
                    break;
            }
            if (txtUPF.Text=="")
            {
                txtUPF.ForeColor = Color.Gray;
                txtUPF.Text = "Seleccione un tipo de rastreo";
            }
            
        }

        private void txtUPF_Enter(object sender, EventArgs e)
        {
            if (txtUPF.Text == "prueba")
            {
                txtUPF.Text = "";
                txtUPF.ForeColor = Color.Black; 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //txtUPF.Text = "Enter some text here";
        }

        private void txtUPF_Leave_1(object sender, EventArgs e)
        {
        
        }

        private void txtUPF_Click(object sender, EventArgs e)
        {
            txtUPF.Text = "";
            txtUPF.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgTabla.DataSource=cn.Rastrear(comboBox1.SelectedIndex, txtUPF.Text);
            //cn.queryRastrear(1, "4413");
        }
    }
}
