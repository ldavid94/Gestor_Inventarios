using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Odbc;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaVista;
using System.Drawing;
using System.Windows.Forms;



namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public void logindatos(string usuario, string passward)
        {           
            string tabla_usuarios = "tbl_usuarios";
            string sql = "select * from " + tabla_usuarios + " where Usuario = '" + usuario + "' and Contraseña = '" + passward + "';";


            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("passward", passward);
                cmd.ExecuteNonQuery();
                OdbcDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    Bienvenida me = new Bienvenida();
                    me.lblUsername.Text = "Bienvenido, " + usuario + ".";
                    me.cbxUsuario.Text = usuario;
                    me.llenarcbxpermisos(usuario);
                    me.Show();
                }
                else
                {
                    Notificaciones n = new Notificaciones("Login", "Error", "El usuario o la contraseña son incorrectas", Color.FromArgb(23, 162, 184), 3);
                    n.ShowDialog();
                    Principal men = new Principal();
                    men.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }

        public OdbcDataAdapter llenarTblSalida1(string tabla, string fecha, string usuario)
        {
            string sql = "select Fecha, Hora, Almacen, Usuario, Cantidad from " + tabla + " where Fecha = '" + fecha + "' and Usuario = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblSalida2(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void registrarSalida(string fecha, string usuario, string idalmacen, string almacen, string idproducto, string descripcion, string cantidad)
        {
            string sql = "insert into tbl_salidas (Fecha, Usuario, IdAlmacen, Almacen, IdProducto, Descripcion, cantidad) values ('" + fecha + "','" + usuario + "','" + idalmacen + "','" + almacen + "','" + idproducto + "','" + descripcion + "','" + cantidad + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Salida", "Error", "La Salida no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void registrarAlmacen(string nombre)
        {
            string sql = "insert into tbl_almacen (Almacen) values ('" + nombre + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Almacen", "Guardado", "El Almacen se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
                n.ShowDialog();

            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Almacen", "Error", "El Almacen no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void registrarUsuarios(string usuario, string contraseña, string nombre, string id_tipo)
        {
            string sql = "insert into tbl_usuarios (Usuario, Contraseña, Nombre, Id_Tipo) values ('" + usuario + "','" + contraseña + "','" + nombre + "','" + id_tipo + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Usuario", "Guardado", "El Usuario se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
                n.ShowDialog();

            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Usuario", "Error", "El Usuario no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public OdbcDataAdapter llenarTblAlmacen(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void eliminarAlmacen(string id_almacen)
        {
            try
            {
                string sql = "delete from tbl_almacen where Codigo = " + id_almacen + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Almacen", "Eliminado", "El Almacen se elimino con éxito", Color.FromArgb(220, 53, 63), 2);
                n.ShowDialog();

            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Almacen", "Error", "El Almacen no se elimino" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public OdbcDataAdapter llenarTblUsuarios(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblEntradas(string tabla, string fecha, string usuario)
        {
            string sql = "select Fecha, Hora, Tipo, Usuario, Proveedor, Cantidad from " + tabla + " where Fecha = '" + fecha + "' and Usuario = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblEntradas2(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarEntrada(string clave, string dato)
        {
            string sql = "select * from tbl_entradas where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarBitacoras(string tabla, string clave, string dato)
        {
            string sql = "select * from " + tabla + " where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarEntradaF(string fecha1, string fecha2)
        {
            string sql = "select * from tbl_entradas where Fecha between '" + fecha1 + "' and '" + fecha2 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarInventario(string clave, string dato)
        {
            string sql = "select * from tbl_inventario where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarInventarioF(string fecha1, string fecha2)
        {
            string sql = "select * from tbl_inventario where Fecha between '" + fecha1 + "' and '" + fecha2 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblinventario(string tabla)
        {
            string sql = "select Codigo, Descripcion, Categoria, Almacen, Entradas, Salidas, Stock from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblproductos(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblbitacoras(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarProducto(string clave, string dato)
        {
            string sql = "select * from tbl_producto where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarSalida(string clave, string dato)
        {
            string sql = "select * from tbl_salidas where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter BuscarSalidaF(string fecha1, string fecha2)
        {
            string sql = "select * from tbl_salidas where Fecha between '" + fecha1 + "' and '" + fecha2 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarAlmacen(string clave, string dato)
        {
            string sql = "select * from tbl_almacen where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarProveedor(string clave, string dato)
        {
            string sql = "select * from tbl_proveedores where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarUsuario(string clave, string dato)
        {
            string sql = "select * from tbl_usuarios where " + clave + " = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeE(string fecha1, string fecha2)
        {
            string sql = "select IdProducto, Producto, Cantidad from tbl_entradas where Fecha between '" + fecha1 + "' and ' " + fecha2 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeS(string fecha1, string fecha2)
        {
            string sql = "select IdProducto, Descripcion, Cantidad from tbl_salidas where Fecha between '" + fecha1 + "' and ' " + fecha2 + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeEBitacora(string fecha1, string fecha2, string usuario)
        {
            string sql = "select Fecha, Nombre, Cantidad from tbl_bitacora_entradas where Fecha between '" + fecha1 + "' and ' " + fecha2 + "' and Nombre = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeSBitacora(string fecha1, string fecha2, string usuario)
        {
            string sql = "select Fecha, Nombre, Cantidad from tbl_bitacora_salidas where Fecha between '" + fecha1 + "' and ' " + fecha2 + "' and Nombre = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeLBitacora(string fecha1, string fecha2, string usuario)
        {
            string sql = "select Fecha, Nombre, Estado from tbl_bitacora_login where Fecha between '" + fecha1 + "' and ' " + fecha2 + "' and Nombre = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter ReportedeCBitacora(string fecha1, string fecha2, string usuario)
        {
            string sql = "select Fecha, Nombre, IdCompra from tbl_bitacora_compras where Fecha between '" + fecha1 + "' and ' " + fecha2 + "' and Nombre = '" + usuario + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void registrarEntrada(string fecha, string usuario, string id_proveedores, string nombre_proveedores, string id_producto, string descripcion_producto, string compra, string venta, string cantidad)
        {
            string sql = "insert into tbl_entradas (Fecha, Usuario, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) values ('" + fecha + "','" + usuario + "','" + id_proveedores + "','" + nombre_proveedores + "','" + id_producto + "','" + descripcion_producto + "','" + compra + "','" + venta + "','" + cantidad + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public OdbcDataReader llenartxtCategorias()
        {
            string sql = "select Categoria from tbl_categoria;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIdProducto()
        {
            string sql = "select Codigo from tbl_inventario;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxUsuario()
        {
            string sql = "select Nombre from tbl_tipo_usuario;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIdAlmacen()
        {
            string sql = "select Codigo from tbl_almacen;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIdProveedore()
        {
            string sql = "select Codigo from tbl_proveedores";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenartxtDescripcion(string id_producto)
        {
            string sql = "select Descripcion from tbl_inventario where Codigo = '" + id_producto + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenartxtNombrealmacen(string id_almacen)
        {
            string sql = "select Almacen from tbl_almacen where Codigo = '" + id_almacen + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenartxtProveedor(string id_proveedor)
        {
            string sql = "select Nombre from tbl_proveedores where Codigo = '" + id_proveedor + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenartxtStockE(string id_producto)
        {
            string sql = "select Entradas from tbl_inventario where Codigo = '" + id_producto + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenartxtEntradas(string id_producto)
        {
            string sql = "select Stock from tbl_inventario where Codigo = '" + id_producto + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }
        public OdbcDataReader llenartxtSalidas(string id_producto)
        {
            string sql = "select Salidas from tbl_inventario where Codigo = '" + id_producto + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenartxtIdUsuario(string nombre)
        {
            string sql = "select Id from tbl_tipo_usuario where Nombre = '" + nombre + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxPrecioCompra(string id)
        {
            string sql = "select Precio_Compra from tbl_entradas where IdProducto = '" + id + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }


        public OdbcDataReader llenarcbxPrecioVenta(string id)
        {
            string sql = "select Precio_Venta from tbl_entradas where IdProducto = '" + id + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public void registrarProducto(string codigo, string descripcion, string categoria, string almacen, string proveedor)
        {
            string sql = "insert into tbl_producto values ('" + codigo + "','" + descripcion + "','" + categoria + "','" + almacen + "','" + proveedor + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Producto", "Guardado", "El Producto se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Producto", "Error", "El Producto no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void eliminarProducto(string id_producto)
        {
            try
            {
                string sql = "delete from tbl_producto where Codigo = " + id_producto + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Producto", "Eliminado", "El Producto se elimino con éxito", Color.FromArgb(220, 53, 63), 2);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Producto", "Error", "El Producto no se elimino " + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public OdbcDataReader llenarcbxAlmacenes()
        {
            string sql = "select Almacen from tbl_almacen;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void registroInventarioN(string fecha, string codigo, string descripcion, string categoria, string almacen)
        {
            string sql = "insert into tbl_inventario values ('" + fecha + "','" + codigo + "','" + descripcion + "','" + categoria + "','" + almacen + "','0','0','0');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Guardado" + ex);
            }
        }

        public void eliminarInventario(string id_producto)
        {
            try
            {
                string sql = "delete from tbl_inventario where Codigo = " + id_producto + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        public void EntradaInventario(string cantidad1, string cantidad2, string id)
        {
            string sql = "update tbl_inventario set Entradas = '" + cantidad1 + "', Stock = '" + cantidad2 + "' where (Codigo = '" + id + "'); ";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void SalidaInventario(string cantidad1, string cantidad2, string id)
        {
            string sql = "update tbl_inventario set Salidas = '" + cantidad1 + "', Stock = '" + cantidad2 + "'  where (Codigo = '" + id + "'); ";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void registrarProveedor(string nombre, string telefono)
        {
            string sql = "insert into tbl_proveedores (Nombre, Telefono) values ('" + nombre + "','" + telefono + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Proveedor", "Guardado", "El Proveedor se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Proveedor", "Error", "El Proveedor no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }

        }

        public OdbcDataAdapter llenarTblproveedor(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTeble = new OdbcDataAdapter(sql, con.conexion());
            return dataTeble;
        }

        public void eliminarProveedor(string codigo)
        {
            try
            {
                string sql = "delete from tbl_proveedores where Codigo = " + codigo + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Proveedor", "Eliminado", "El Proveedor se elimino con éxito", Color.FromArgb(220, 53, 63), 2);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Proveedor", "Error", "El Proveedor no se elimino" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void eliminarUsuario(string codigo)
        {
            try
            {
                string sql = "delete from tbl_usuarios where Codigo = " + codigo + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Usuario", "Eliminado", "El Usuario se elimino con éxito", Color.FromArgb(220, 53, 63), 2);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Usuario", "Error", "El Usuario no se elimino" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void registrarBitacoraLogin(string fecha, string hora, string nombre, string estado)
        {
            string sql = "insert into tbl_bitacora_login values ('" + fecha + "','" + hora + "','" + nombre + "','" + estado + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void registrarBitacoraEntradas(string fecha, string hora, string nombre, string cantidad)
        {
            string sql = "insert into tbl_bitacora_entradas (Fecha, Hora, Nombre, Cantidad) values ('" + fecha + "','" + hora + "','" + nombre + "','" + cantidad + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void registrarBitacoraSalidas(string fecha, string hora, string nombre, string cantidad)
        {
            string sql = "insert into tbl_bitacora_salidas (Fecha, Hora, Nombre, Cantidad) values ('" + fecha + "','" + hora + "','" + nombre + "','" + cantidad + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public OdbcDataReader llenarcbxTProveedores()
        {
            string sql = "select count(*) from tbl_proveedores;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxTCategorias()
        {
            string sql = "select count(*) from tbl_categoria;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxTProductos()
        {
            string sql = "select count(*) from tbl_producto;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter llenarTblStock(string tabla)
        {
            string sql = "select Codigo, Descripcion, Stock from " + tabla + " where Stock<=10;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblCompra(string tabla)
        {
            string sql = "select IdProducto, Producto, Cantidad from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataReader llenarcbxIdPocoStock()
        {
            string sql = "select Codigo from tbl_inventario where Stock<=10;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxTotalIngresos()
        {
            string sql = "select sum(Total) as Total from tbl_ingresos;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void registrarCompra(string fecha, string idproducto, string producto, string cantidad)
        {
            string sql = "insert into tbl_compra (Fecha_Compra, IdProducto, Producto, Cantidad, Estado) values ('" + fecha + "','" + idproducto + "','" + producto + "','" + cantidad + "','1');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compra" + ex);
            }
        }

        public void registrarBitacoraCompra(string fecha, string hora, string nombre)
        {
            string sql = "insert into tbl_bitacora_compras (Fecha, Hora, Nombre) values ('" + fecha + "','" + hora + "','" + nombre + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void eliminarCompra(string codigo)
        {
            try
            {
                string sql = "delete from tbl_compra where Codigo = " + codigo + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void modificarCompra(string cantidad, string codigo)
        {
            string sql = "update tbl_compra set Cantidad = '" + cantidad + "' where (Codigo = '" + codigo + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void vaciarCompra(string tabla)
        {
            string sql = "truncate table " + tabla + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public OdbcDataReader DashboardTsalidas(string fecha1, string fecha2)
        {
            string sql = "select count(*) from tbl_salidas where Fecha between '" + fecha1 + "' and '" + fecha2 + "' ;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader DashboardTproducto(string fecha1, string fecha2)
        {
            string sql = "select sum(Stock) as Total from tbl_inventario;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader DashboardTentradas(string fecha1, string fecha2)
        {
            string sql = "select count(*) from tbl_entradas where Fecha between '" + fecha1 + "' and '" + fecha2 + "' ;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader DashboardTingresos(string fecha1, string fecha2)
        {
            string sql = "select sum(Total) from tbl_ingresos where Fecha between '" + fecha1 + "' and '" + fecha2 + "' ;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader DashboardTProveedores()
        {
            string sql = "select count(*) from tbl_proveedores;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public OdbcDataAdapter Dashboardgrafica1(string fecha1, string fecha2)
        {
            string sql = "select Fecha, sum(Cantidad) as Total from tbl_salidas where Fecha between '" + fecha1 + "' and '" + fecha2 + "' group by Fecha;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter Dashboardgrafica2(string fecha1, string fecha2)
        {
            string sql = "select Cantidad, Descripcion from tbl_productos_populares where Fecha between '" + fecha1 + "' and '" + fecha2 + "' order by Cantidad desc limit 5;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter Dashboardgrafica3()
        {
            string sql = "select Proveedores, sum(Cantidad) as Total from tbl_entradas group by Proveedores;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter Dashboard2grafica1(string fecha1, string fecha2)
        {
            string sql = "select IdProducto, sum(Cantidad) as Total from tbl_entradas where Fecha between '" + fecha1 + "' and '" + fecha2 + "' group by IdProducto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter Dashboard2grafica2(string fecha1, string fecha2)
        {
            string sql = "select IdProducto, sum(Cantidad) as Total from tbl_salidas where Fecha between '" + fecha1 + "' and '" + fecha2 + "' group by IdProducto;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void registrarGanancia(string fecha, string total)
        {
            string sql = "insert into tbl_ingresos (Fecha, Total) values ('" + fecha + "','" + total + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public OdbcDataAdapter llenarTblCategoria(string tabla)
        {
            string sql = "select * from " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter BuscarCategoria(string dato)
        {
            string sql = "select * from tbl_categoria where Categoria = '" + dato + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void registrarCategoria(string categoria)
        {
            string sql = "insert into tbl_categoria (Categoria) values ('" + categoria + "');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Categoria", "Guardado", "La Categoria se guardo con éxito", Color.FromArgb(40, 167, 69), 1);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Categoria", "Error", "La Categoria no se guardo" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void eliminarCategoria(string codigo)
        {
            try
            {
                string sql = "delete from tbl_categoria where Codigo = " + codigo + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Notificaciones n = new Notificaciones("Categoria", "Eliminado", "La Categoria se elimino con éxito", Color.FromArgb(220, 53, 63), 2);
                n.ShowDialog();
            }
            catch (Exception ex)
            {
                Notificaciones n = new Notificaciones("Categoria", "Error", "La Categoria no se elimino" + ex, Color.FromArgb(23, 162, 184), 3);
                n.ShowDialog();
            }
        }

        public void registrarControl(string idproducto, string producto, string cantidad)
        {
            string sql = "insert into tbl_control (IdProducto, Producto, Cantidad) values ('" + idproducto + "','" + producto + "','" + cantidad + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public OdbcDataAdapter llenarTblControl(string tabla)
        {
            string sql = "select IdProducto, Producto, Cantidad from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataReader llenarcbxNAlmacen()
        {
            string sql = "select Almacen from tbl_almacen;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        public OdbcDataReader llenarcbxNProveedor()
        {
            string sql = "select Nombre from tbl_proveedores;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcbxNProducto(string nombre)
        {
            string sql = "select Descripcion from tbl_producto where Empresa = '" + nombre + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIDProducto(string nombre)
        {
            string sql = "select Codigo from tbl_inventario where Descripcion = '" + nombre + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIDProveedor(string nombre)
        {
            string sql = "select Codigo from tbl_proveedores where Nombre = '" + nombre + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public void vaciarRegistro(string tabla)
        {
            string sql = "truncate table " + tabla + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void registrarRegistroE(string fecha, string hora, string tipo, string usuario, string proveedor, string cantidad)
        {
            string sql = "insert into tbl_registro_entrada (Fecha, Hora, Tipo, Usuario, Proveedor, Cantidad) values ('" + fecha + "','" + hora + "','" + tipo + "','" + usuario + "','" + proveedor + "','" + cantidad + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void registrarRegistroS(string fecha, string hora, string tipo, string almacen, string usuario, string cantidad)
        {
            string sql = "insert into tbl_registro_salidas (Fecha, Hora, Tipo, Almacen, Usuario, Cantidad) values ('" + fecha + "','" + hora + "','" + tipo + "','" + almacen + "','" + usuario + "','" + cantidad + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public OdbcDataReader llenarcbxNombreProducto(string almacen)
        {
            string sql = "select Descripcion from tbl_inventario where Almacen = '" + almacen + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxIDAlmacen(string almacen)
        {
            string sql = "select Codigo from tbl_almacen where Almacen = '" + almacen + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxPermiso(string usuario)
        {
            string sql = "select Id_Tipo from tbl_usuarios where Usuario = '" + usuario + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return null;
            }
        }

        public OdbcDataReader llenarcbxUsuarios()
        {
            string sql = "select Usuario from tbl_usuarios;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return null;
            }
        }
    }

}

