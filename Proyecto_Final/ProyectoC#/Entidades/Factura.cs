using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        //MessageBox.Show(row["Codigo"].ToString());
        //        MessageBox.Show(row["Producto"].ToString());
        //        MessageBox.Show(row["Precio x Unidad"].ToString());
        //        MessageBox.Show(row["Cantidad"].ToString());
        //        MessageBox.Show(row["Descuento"].ToString());
        //        MessageBox.Show(row["Precio Total"].ToString());
        //        MessageBox.Show(row["Codigo"].ToString());


        //subtotal
        //cliente
        //descuento
        //total

       public string codigo = "";
       public string producto = "";
       public string precioUnidad = "";
       public string canitdad = "";
       public string descuento = "";
       public string precioTotal = "";
       public string subtotal = "";//no está
       public string cliente = "";
        public string fecha = "";

        public string usuario = "";
        private string codigoCliente = "";
        public string clienteDescuento = "";
        public double total = 0;
        public string nFactura = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public string Canitdad { get => canitdad; set => canitdad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string ClienteDescuento { get => clienteDescuento; set => clienteDescuento = value; }
       
        public string NFactura { get => nFactura; set => nFactura = value; }
        public double Total { get => total; set => total = value; }
        public string CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
