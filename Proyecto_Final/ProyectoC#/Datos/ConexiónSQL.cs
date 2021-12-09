using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class ConexionSQL
    {
        static string conexionString = "Data Source=localhost;database=empresaxyz;Integrated Security=True";
        SqlConnection con = new SqlConnection(conexionString);
        public int queryLogin(string usuario, string contrasena)
        {
            int count;
            con.Open();
            string query="SELECT Count(*) FROM usuarios WHERE usuario='"+usuario+"'AND contrasena ='"+contrasena+"' AND login = 1";
            SqlCommand cmd = new SqlCommand(query,con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            return count;
        }
     
        public int insertarRegistro(string nom, string ape , string ci , string tel , string user ,string contra, string log, string cargo)
        {
            int flag = 0;
            con.Open();
            string query = "INSERT INTO personas (ci,nombre,apellido,telefono,cargo) VALUES ('" + ci + "','" + nom + "','" + ape + "','" + tel + "','" + cargo + "')" +
                "INSERT INTO usuarios (usuario,contrasena,login,ci)VALUES ('" + user + "','" + contra + "','" + log + "','" + ci + "')";

            string queryAux = "SELECT cantidad FROM inventario WHERE codigo='" + 51 + "';";
            SqlCommand cmdAux = new SqlCommand(queryAux, con);
            SqlCommand cmd = new SqlCommand(query,con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int modUsuario(string nom, string ape, string ci, string tel, string user, string contra, string log,string cargo)
        {
            int flag = 0;
            con.Open();
            string query = " UPDATE personas SET nombre = '" + nom + "', apellido = '" + ape + "', telefono='" + tel + "', cargo = '"+cargo+"' WHERE ci='" + ci + "' " +
                "UPDATE usuarios SET usuario='" + user + "', contrasena ='" + contra + "', login ='" + log + "' WHERE ci='" + ci + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int eliminarUsuario(string ci)
        {
            int flag = 0;
            con.Open();
            string query1 = "DELETE FROM usuarios WHERE ci='" + ci + "';";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            string query = "DELETE FROM personas WHERE ci='" + ci + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd1.ExecuteNonQuery();
            flag = cmd.ExecuteNonQuery();
            con.Close(); 
            return flag;
        }


        public int insertarRegistroInv(string prod, string cat, string prec, string cant, string cod)
        {
            int flag = 0;
            con.Open();
            string query = "INSERT INTO inventario VALUES ('" + prod + "','" + cat + "','" + prec + "','" + cant + "','" + cod + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int modUsuarioInv(string prod, string cat, string prec, string cant, string cod)
        {
            int flag = 0;
            con.Open();
            string query = " UPDATE inventario SET producto = '" + prod + "', categoria = '" + cat + "', precio='" + prec + "', cantidad = '" + cant + "' WHERE codigo='" + cod + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int eliminarUsuarioInv(string cod)
        {
            int flag = 0;
            con.Open();

            string query = "DELETE FROM inventario WHERE codigo='" + cod + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;

        }

        public int insertarCliente(string nombre, string tel, string dir, string correo, string code)
        {
            int flag = 0;
            con.Open();
            string query = "INSERT into cliente (nombreCliente, telefonoCliente, dirCliente, correoCliente, codigoCliente) VALUES ('"+nombre+"','"+tel+"','"+dir+"','"+correo+"','"+code+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public DataTable consultaUsuariosDG()
        {
            string query = "SELECT per.nombre, per.apellido, per.telefono,per.cargo,usu.usuario, usu.ci, usu.login FROM personas AS per left join usuarios AS usu on per.ci = usu.ci; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public DataTable consultainvDG()
        {
            string query = "SELECT producto,categoria,precio,cantidad,codigo FROM inventario";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }
        public string consultaFactura()
        {
            con.Open();
            string query = "SELECT (SELECT DISTINCT TOP 1 numFactura FROM facturacion order by  numFactura DESC )+1 AS numFactura";
            string resul="NULL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resul= reg["numFactura"].ToString();  
            }
            con.Close();
            return resul;    
        }

        public int actualizacionCantInv(string codigo,int cant)
        {
            con.Open();
            int flag = 0;
            int count;


            string queryAux = "SELECT cantidad FROM inventario WHERE codigo='" + codigo + "';";
            SqlCommand cmdAux = new SqlCommand(queryAux, con);
            count = Convert.ToInt32(cmdAux.ExecuteScalar());


            string query = "UPDATE inventario SET cantidad ='" + (count-cant) + "' WHERE codigo='" + codigo + "';";
            SqlCommand cmd = new SqlCommand(query, con);


            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }


        public Tuple <string,string> consultaInventario(string codigo)
        {
            con.Open();
            string query = "SELECT * from inventario WHERE codigo= '"+codigo+"'";
            string resul = "NULL";
            string resul1 = "NULL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resul = reg["Producto"].ToString();
                  resul1 = reg["Precio"].ToString();
            } 
            con.Close();
            return Tuple.Create(resul,resul1);

        }

        public Tuple<string> consultaCliente(string codigo)
        {
            con.Open();
            string query = "SELECT cl.nombreCliente FROM cliente AS cl WHERE  codigoCliente='"+codigo+"';";
            string resul = "NULL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resul = reg["nombreCliente"].ToString();
            }
            con.Close();
            return Tuple.Create(resul );

        }


        public Tuple<string,string,string> consultaUsuario(string usuario, string pass)
        {
            con.Open();
            string query = "SELECT per.nombre,per.apellido, per.ci FROM personas as per INNER JOIN usuarios u on per.ci = u.ci WHERE u.usuario='" + usuario + "' and contrasena='" + pass + "';";
            string resul = "NULL";
            string resul2 = "NULL";
            string resul3 = "NULL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resul = reg["nombre"].ToString();
                resul2 = reg["apellido"].ToString();
                resul3 = reg["ci"].ToString();
            }
            con.Close();
            return Tuple.Create(resul,resul2,resul3);

        }



        public void insertarFactura(List<Factura> F)
        {
            con.Open();
            foreach (Factura fact in F)
            {
                int countCli;
                int countInv;
                int countUsu;

                string queryCli = "SELECT id_cliente FROM cliente WHERE codigoCliente='" + fact.CodigoCliente + "';";
                SqlCommand cmdCli = new SqlCommand(queryCli, con);
                countCli = Convert.ToInt32(cmdCli.ExecuteScalar());


                string queryInv = "SELECT id FROM inventario WHERE codigo='"+fact.Codigo+"'";
                SqlCommand cmdInv = new SqlCommand(queryInv, con);
                countInv = Convert.ToInt32(cmdInv.ExecuteScalar());


                string queryUsu = "Select  id_usuario FROM usuarios WHERE ci='" + fact.usuario + "';";
                SqlCommand cmdUsu = new SqlCommand(queryUsu, con);
                countUsu = Convert.ToInt32(cmdUsu.ExecuteScalar());
          

                string query = "INSERT INTO  facturacion (codigo, producto,  cliente, numFactura, cantidad, precioUnidad, descuento, montoTotal, id_cliente, id_inventario, id_usuario,fecha) " +
                                    "VALUES('" + fact.codigo + "', '" + fact.producto + "',  '" + fact.cliente + "','" + fact.NFactura + "','" + Convert.ToInt32 (fact.canitdad) + "','" + fact.PrecioUnidad + "','" +Convert.ToDouble(fact.descuento)+ "','" +Convert.ToDouble(fact.PrecioTotal)+"','"+countCli+"','"+countInv+"','"+countUsu+"','"+fact.fecha+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            con.Close();
        }
        public DataTable consultaClienteDT()
        {
            string query = "SELECT nombreCliente AS Nombre ,telefonoCliente AS Telefono,dirCliente AS Direccion,codigoCliente AS Codigo FROM cliente;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable multitabla(int num)
        {
            string query = "";
            switch (num)
            {
                case 0:
                    query = "SELECT  * FROM   General_Factura ";
                    break;
                case 1:
                    query = "SELECT * FROM VistaGeneral;";
                    break;

                default:
                    break;

            }

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public DataTable queryRastrear(int num, string cod)
        {
            string query;
            switch (num)
            {
                case 0:
                     query = "SELECT * FROM dbo.ventasUsuario ('"+cod+"');";
                    break;
                case 1:
                     query = "select * from  dbo.RasComprasCliente ('"+cod+"')";
                    break;
                case 2:
                     query = "select * from  dbo.rastrearFactura ('"+cod+"')";
                    break;
                default:
                    query = "Hola";
                    break;
            }
            
        
        
        SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
    }
}
