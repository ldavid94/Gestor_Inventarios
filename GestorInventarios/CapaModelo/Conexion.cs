using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Conexion
    {
        public OdbcConnection conexion()
        {

            OdbcConnection conexion = new OdbcConnection("Dsn=tienda_conveniencia");
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conexion;
        }


        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}
