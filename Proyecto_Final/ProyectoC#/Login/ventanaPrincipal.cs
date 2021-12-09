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
    public partial class ventanaPrincipal : Form
    {
       
        private double subtotal = 0;
        private double totalPrec = 0;
        private double desc = 0;
       
        conexionSQLN cn = new conexionSQLN();

        private DataTable dt;
        public ventanaPrincipal(string user , string pass)
        {
            InitializeComponent();

            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //// Color scheme
            //materialSkinManager.ColorScheme = new ColorScheme(
            //Primary.Blue400, Primary.Blue500,
            //Primary.Blue500, Accent.LightBlue200,
            //TextShade.WHITE

            //);

            //txtVenta.Text = (double.Parse (kres)* double.Parse(aux) ).ToString();
            txtVenta.Text = (100 * double.Parse(txtVentaEdit.Text)).ToString();
            //Int32.Parse(txtCantidadProducto.Text)*double.Parse(resultado.Item2);
            //txtVenta.Text = txtVentaEdit.Text;

            //txtDescuento.Text = txtDescuentoEdit.Text;

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyy");




               /////////////////
            var queryusu = cn.consultaUsuario(user, pass);
            lblUsu.Text = user;
            lblNameUsu.Text = queryusu.Item1;
            lblApeUsu.Text=  queryusu.Item2;
            lblCi.Text = queryusu.Item3;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");
            dtgFacturacion.DataSource = dt;
            txtnumFactura.Text = cn.consultaFactura();     
          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlUsers v1 = new controlUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario v1 = new Inventario();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtVentaEdit_TextChanged(object sender, EventArgs e)
        {
            txtVenta.Text = (100 * double.Parse(txtVentaEdit.Text)).ToString();
            //txtVenta.Text = txtVentaEdit.Text;
            //txtDescuento.Text = txtDescuentoEdit.Text;
        }

        private void txtDescuentoEdit_TextChanged(object sender, EventArgs e)
        {
            txtVenta.Text = (100 * double.Parse(txtVentaEdit.Text)).ToString();
            //txtVenta.Text = txtVentaEdit.Text;
           // txtDescuento.Text = txtDescuentoEdit.Text;
        }
        private void cmbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int indexBox = cmbDesc.SelectedIndex;
            int valDesc;
            double descEnd;
            switch (indexBox)
            {
                case 0:
                    valDesc = 5;
                    break;
                case 1:
                    valDesc = 10;
                    break;
                case 2:
                    valDesc = 15;
                    break;
                case 3:
                    valDesc = 0;
                    break;
                default:
                    valDesc = 0;
                    break;
            }

            var resultado =cn.consultaInventario(txtCodigoProducto.Text);
            DataRow row = dt.NewRow();
            row["Codigo"] = txtCodigoProducto.Text;
            row["Producto"] = resultado.Item1;
            row["Precio x Unidad"] = resultado.Item2;
            row["Cantidad"] = txtCantidadProducto.Text;
            row["Descuento"] = valDesc;
            row["Precio Total"] = Int32.Parse(txtCantidadProducto.Text)*double.Parse(resultado.Item2);

            dt.Rows.Add(row);
            ////
            ///
            lblitem1.Text= resultado.Item1;
            

            


            
            subtotal = subtotal + (Int32.Parse(txtCantidadProducto.Text) * double.Parse(resultado.Item2));
            descEnd = (subtotal * valDesc) / 100;
            lblitem2.Text = descEnd.ToString();
            //totalPrec = subtotal + (subtotal + double.Parse(txtVenta.Text));


            //totalPrec = ((double)subtotal * descuento)/100;// (subtotal + double.Parse(txtVenta.Text));
            totalPrec = subtotal - descEnd;
            lblPrecioSubtotal.Text = subtotal.ToString();
            lblPrecioTotal.Text = totalPrec.ToString();

            //if (desc==0)
            //{
            //    totalPrec = subtotal;
            //}
            //else
            //{
            //    //totalPrec = subtotal + (subtotal * double.Parse(txtVentaEdit.Text));
            //    //totalPrec = totalPrec - (totalPrec * desc)/100;
            //    totalPrec = subtotal - descEnd;
            //}


        }

        private void dtgFacturacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            var resultadoX = cn.consultaCliente(txtCodigoCliente.Text) ;
            txtClienteInfo.Text = resultadoX.Item1 ;
            //desc = resultadoX.Item2;
            RegCliente v1 = new RegCliente(txtCodigoCliente.Text);
            //
            if (txtClienteInfo.Text!="NULL")
            {
                
            }
            else
            {
                MessageBox.Show("Cliente no encontrado. Se registra un nuevo Cliente");
             
                if (v1.ShowDialog() == DialogResult.OK)
                {
                    txtClienteInfo.Text = v1.Nombre;
                    txtCodigoCliente.Text = v1.Codigo; 
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Actualizar inventario//
            cn.actualizacionCantInv(txtCodigoProducto.Text, int.Parse(txtCantidadProducto.Text));
            ///////////
            List<Factura> listFact = new List<Factura>();


            foreach (DataRow row in dt.Rows)
            {
                var resultadoX = cn.consultaCliente(txtCodigoCliente.Text);
                Factura fact = new Factura(); //afuera
                fact.Codigo = row["Codigo"].ToString();
                fact.Producto = row["Producto"].ToString();
                fact.PrecioUnidad = row["Precio x Unidad"].ToString();
                fact.Canitdad = row["Cantidad"].ToString();
                fact.Descuento = row["Descuento"].ToString();
                fact.PrecioTotal = row["Precio total"].ToString();
                fact.Subtotal = subtotal.ToString();
                fact.Cliente = resultadoX.Item1;
                fact.ClienteDescuento = desc.ToString();
                


                fact.CodigoCliente = txtCodigoCliente.Text;
                fact.Usuario = lblCi.Text;

                lblitem1.Text = txtCodigoCliente.Text; ;
                lblitem2.Text = fact.codigo;
                lblImpVenta.Text = fact.usuario;


                fact.Total = Convert.ToDouble(lblPrecioTotal.Text);
                fact.NFactura = txtnumFactura.Text;
                fact.Fecha = lblFecha.Text;
                listFact.Add(fact);

              

            }
            cn.insertarFactura(listFact);
            txtnumFactura.Text = cn.consultaFactura();


            MessageBox.Show("¡Se ha realizado la compra!");

            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();

        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Obetner nombre Cliente
            var resultadoX = cn.consultaCliente(txtCodigoCliente.Text);
            string Cliente = resultadoX.Item1;
            ///
            Font font = new Font("Arial", 10);
            Font fontGrande = new Font("Arial", 17);
            Font fontDescrip = new Font("Arial", 8);
            int ancho = 800;
            int y = 20;
            

            e.Graphics.DrawString("         Empresa XYZ", fontGrande, Brushes.Black, new RectangleF(0, y += 35, ancho, 30));
            e.Graphics.DrawString("    Venta de accesorios electronicos y otros.", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("                El Alto, La Paz - Bolivia", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
           
            e.Graphics.DrawString("-------------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                 ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("   NIT      :  365395019  ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("   FACTURA NRO    :      " + txtnumFactura.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            //e.Graphics.DrawString("   AUTORIZACION   :  54318743" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                 ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString("---------------------Venta----------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  FECHA   :   "+DateTime.Now.ToShortDateString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  CLIENTE   :  " + resultadoX.Item1, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("  NIT    :  "+ txtCodigoCliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("_________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString(" Cant. |        Descripción               |   P .U     |  Total", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("_________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString("  "+row["Cantidad"].ToString() + "      " + row["Producto"].ToString() + "           " + row["Precio x Unidad"].ToString() + "             " + row["Precio total"].ToString()
                    , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20)); 


            }


            e.Graphics.DrawString("____________________________________________________", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("                  TOTAL A PAGAR Bs.    "+ totalPrec, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString("       -----Gracias por su visita!------", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //printDocument1.DocumentName = new docu;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            //PrintPreviewDialog1 documento = new PrintPreviewDialog();
            //documento = Imprimir();
            //Imprimir.Show();
            //if (printPreviewDialog1)
            {

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblitem1.Text = DataTime.Now
        }

        private void registroInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cliente v1 = new Cliente();
            v1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = "";
            txtClienteInfo.Text = "";
            txtCodigoProducto.Text = "";
            txtCantidadProducto.Text = "1";





            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {

                row.Delete();
            }
            dt.AcceptChanges();

            lblPrecioSubtotal.Text = "0,00";
            lblPrecioTotal.Text = "0,00";
            subtotal = 0;
      totalPrec = 0;
desc = 0;

    }

        private void rastrearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}

