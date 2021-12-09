using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using Entidades;

namespace Negocios
{
    public class conexionSQLN
    {

        ConexionSQL cn = new ConexionSQL();
        public int conSQL(string user, string pass  )
        {
            return cn.queryLogin(user,pass);
        }
        public DataTable consultaDT()
        {

            return cn.consultaUsuariosDG(); ;
        }
        public DataTable consultainvDT()
        {

            return cn.consultainvDG(); ;
        }

        public int insertarRegistro(string nom, string ape, string ci, string tel, string user, string contra, string log, string cargo)
        {
            return cn.insertarRegistro(nom,ape,ci,tel,user,contra,log,cargo);
        }
        public int modUsuario(string nom, string ape, string ci, string tel, string user, string contra, string log,string cargo)
        {
            return cn.modUsuario(nom, ape, ci, tel, user, contra, log,cargo);
        }
        public int eliminarUsuario(string ci)
        {
            return cn.eliminarUsuario(ci );
        }


        public int insertarRegistroInv(string prod, string cat, string prec, string cant, string cod)
        {
            return cn.insertarRegistroInv(prod, cat, prec, cant, cod);
        }
        public int modUsuarioInv(string prod, string cat, string prec, string cant, string cod)
        {
            return cn.modUsuarioInv(prod, cat, prec, cant, cod);
        }
        public int eliminarUsuarioInv(string cod)
        {
            return cn.eliminarUsuario(cod);
        }


        public string consultaFactura()
        {
            return cn.consultaFactura();
        }
        public Tuple<string, string> consultaInventario(string codigo) 
        {
            return cn.consultaInventario(codigo);
        }

        public Tuple<string> consultaCliente(string codigo)
        {
            return cn.consultaCliente(codigo);
        }
        public void  insertarFactura (List<Factura> F)
        {
            cn.insertarFactura(F);
        }


        public Tuple<string,string,string> consultaUsuario(string usuario,string pass)
        {
            return cn.consultaUsuario (usuario, pass);
        }
        
        public int actualizacionCantInv(string cod, int cant)
        {
            return cn.actualizacionCantInv(cod,cant);
        }

        public int insertarCliente(string nom, string tel, string dir, string correo, string code)
        {
            return cn.insertarCliente(nom,  tel, dir, correo, code);
        }


        public DataTable consultaClienteDT()
        {
            return cn.consultaClienteDT();
        }
        public DataTable multiTablaAD(int num)
        {
            return cn.multitabla(num);
        }
        public DataTable Rastrear(int num,string code)
        {
            return cn.queryRastrear(num, code);
        }
    }

}
