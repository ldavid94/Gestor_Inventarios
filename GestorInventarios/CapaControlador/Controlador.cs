using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public int verificarusuario(string usuario, string passward)
        {
            sn.logindatos(usuario, passward);
            return 1;
        }

        public DataTable llenarTblS(string tabla, string fecha, string usuario)
        {
            OdbcDataAdapter dt = sn.llenarTblSalida1(tabla, fecha, usuario);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblS2(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblSalida2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblA(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblAlmacen(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblI(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblinventario(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblE(string tabla, string fecha, string usuario)
        {
            OdbcDataAdapter dt = sn.llenarTblEntradas(tabla, fecha, usuario);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblE2(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblEntradas2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblP(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblproductos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblPro(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblproveedor(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblU(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblUsuarios(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblBit(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblbitacoras(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblSto(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblStock(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblCom(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblCompra(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarGBarras(string fecha1, string fecha2)
        {
            OdbcDataAdapter dt = sn.Dashboardgrafica1(fecha1, fecha2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarGpastel(string fecha1, string fecha2)
        {
            OdbcDataAdapter dt = sn.Dashboardgrafica2(fecha1, fecha2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarGbarrashorizontal()
        {
            OdbcDataAdapter dt = sn.Dashboardgrafica3();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarGrafica1(string fecha1, string fecha2)
        {
            OdbcDataAdapter dt = sn.Dashboard2grafica1(fecha1, fecha2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarGrafica2(string fecha1, string fecha2)
        {
            OdbcDataAdapter dt = sn.Dashboard2grafica2(fecha1, fecha2);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblC(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblCategoria(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblCon(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblControl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void guardarSalida(string fecha, string usuario, string idalmacen, string almacen, string idproducto, string descripcion, string cantidad)
        {
            sn.registrarSalida(fecha, usuario, idalmacen, almacen, idproducto, descripcion, cantidad);
        }

        public void guardarAlmacen(string nombre)
        {
            sn.registrarAlmacen(nombre);
        }

        public void guardarEntrada(string fecha,string usuario, string id_proveedores, string nombre_proveedores, string id_producto, string descripcion_producto, string compra, string venta, string cantidad)
        {
            sn.registrarEntrada(fecha, usuario, id_proveedores, nombre_proveedores, id_producto, descripcion_producto, compra, venta, cantidad);
        }

        public void guardarProducto(string codigo, string descripcion, string categoria, string almacen, string proveedor)
        {
            sn.registrarProducto(codigo, descripcion, categoria, almacen, proveedor);
        }

        public void guardarInventarioNuevo(string fecha, string codigo, string descripcion, string categoria, string almacen)
        {
            sn.registroInventarioN(fecha, codigo, descripcion, categoria, almacen);
        }

        public void guardarProveedor(string nombre, string telefono)
        {
            sn.registrarProveedor(nombre, telefono);
        }

        public void guardarUsuario( string usuario, string contraseña, string nombre, string id_tipo)
        {
            sn.registrarUsuarios(usuario, contraseña, nombre, id_tipo);
        }

        public void guardarCompra(string fecha, string idproducto, string producto, string cantidad)
        {
            sn.registrarCompra(fecha, idproducto, producto, cantidad);
        }

        public void guardarGanancia(string fecha, string total)
        {
            sn.registrarGanancia(fecha, total);
        }

        public void guardarBitacoraLogin(string fecha, string hora, string nombre, string estado)
        {
            sn.registrarBitacoraLogin(fecha, hora, nombre, estado);
        }

        public void guardarBitacoraEntradas(string fecha, string hora, string nombre, string cantidad)
        {
            sn.registrarBitacoraEntradas(fecha, hora, nombre, cantidad);
        }

        public void guardarBitacoraSalidas(string fecha, string hora, string nombre, string cantidad)
        {
            sn.registrarBitacoraSalidas(fecha, hora, nombre, cantidad);
        }

        public void guardarBitacoraCompra(string fecha, string hora, string nombre)
        {
            sn.registrarBitacoraCompra(fecha, hora, nombre);
        }

        public void guardarCategoria(string categoria)
        {
            sn.registrarCategoria(categoria);
        }

        public void relizarControl(string idproducto, string producto, string cantidad)
        {
            sn.registrarControl(idproducto, producto, cantidad);
        }

        public void relizarRegistroE(string fecha, string hora, string tipo, string usuario, string proveedor, string cantidad)
        {
            sn.registrarRegistroE(fecha, hora, tipo, usuario, proveedor, cantidad);
        }

        public void relizarRegistroS(string fecha, string hora, string tipo, string almacen, string usuario, string cantidad)
        {
            sn.registrarRegistroS(fecha, hora, tipo, almacen, usuario, cantidad);
        }

        public void realizarNCompra(string tabla)
        {
            sn.vaciarCompra(tabla);
        }

        public int borrar_almacen(TextBox id_almacen)
        {
            if (string.IsNullOrEmpty(id_almacen.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("¿Desea eliminar el almacen #" + id_almacen.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.eliminarAlmacen(id_almacen.Text);
            return 1;
        }

        public int borrar_categoria(TextBox id_categoria)
        {
            if (string.IsNullOrEmpty(id_categoria.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("¿Desea eliminar la categoria #" + id_categoria.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.eliminarCategoria(id_categoria.Text);
            return 1;
        }

        public DataTable datosBusquedaE(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarEntrada(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaFechaE(string fecha1, string fecha2)
        {
            OdbcDataAdapter db = sn.BuscarEntradaF(fecha1, fecha2);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaI(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarInventario(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaFechaI(string fecha1, string fecha2)
        {
            OdbcDataAdapter db = sn.BuscarInventarioF(fecha1, fecha2);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaP(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarProducto(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaS(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarSalida(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaFechaS(string fecha1, string fecha2)
        {
            OdbcDataAdapter db = sn.BuscarSalidaF(fecha1, fecha2);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaA(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarAlmacen(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }
        
        public DataTable datosBusquedaPro(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarProveedor(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaUsu(string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarUsuario(clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable datosBusquedaBit(string tabla, string clave, string dato)
        {
            OdbcDataAdapter db = sn.BuscarBitacoras(tabla, clave, dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteE(string fecha1, string fecha2)
        {
            OdbcDataAdapter db = sn.ReportedeE(fecha1, fecha2);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteS(string fecha1, string fecha2)
        {
            OdbcDataAdapter db = sn.ReportedeS(fecha1, fecha2);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaCategoria(string dato)
        {
            OdbcDataAdapter db = sn.BuscarCategoria(dato);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteEB(string fecha1, string fecha2, string usuario)
        {
            OdbcDataAdapter db = sn.ReportedeEBitacora(fecha1, fecha2, usuario);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteSB(string fecha1, string fecha2, string usuario)
        {
            OdbcDataAdapter db = sn.ReportedeSBitacora(fecha1, fecha2, usuario);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteLB(string fecha1, string fecha2, string usuario)
        {
            OdbcDataAdapter db = sn.ReportedeLBitacora(fecha1, fecha2, usuario);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public DataTable BusquedaReporteCB(string fecha1, string fecha2, string usuario)
        {
            OdbcDataAdapter db = sn.ReportedeCBitacora(fecha1, fecha2, usuario);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }

        public int borrar_producto(TextBox id_producto)
        {
            if (string.IsNullOrEmpty(id_producto.Text))
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("¿Desea eliminar el producto #" + id_producto.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borro el almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.eliminarProducto(id_producto.Text);
            sn.eliminarInventario(id_producto.Text);
            return 1;
        }

        public OdbcDataReader llenartxtC()
        {
            return sn.llenartxtCategorias();
        }

        public OdbcDataReader llenarcbxAlma()
        {
            return sn.llenarcbxAlmacenes();
        }

        public void guardarEntradaInventario(string cantidad1, string cantidad2, string id)
        {
            sn.EntradaInventario(cantidad1, cantidad2, id);
        }

        public void guardarSalidaInventario(string cantidad1, string cantidad2, string id)
        {
            sn.SalidaInventario(cantidad1, cantidad2, id);
        }

        public void guardarModificacionCompra(string cantidad, string codigo)
        {
            sn.modificarCompra(cantidad, codigo);
        }

        public OdbcDataReader llenarcbxIdPro()
        {
            return sn.llenarcbxIdProducto();
        }

        public OdbcDataReader llenarcbxTprov()
        {
            return sn.llenarcbxTProveedores();
        }

        public OdbcDataReader llenarcbxTCat()
        {
            return sn.llenarcbxTCategorias();
        }

        public OdbcDataReader llenarcbxTProd()
        {
            return sn.llenarcbxTProductos();
        }

        public OdbcDataReader llenarcbxIdProve()
        {
            return sn.llenarcbxIdProveedore();
        }

        public OdbcDataReader llenarcbxIdAlma()
        {
            return sn.llenarcbxIdAlmacen();
        }

        public OdbcDataReader llenarcbxUsu()
        {
            return sn.llenarcbxUsuario();
        }

        public OdbcDataReader llenarcbxIdProducto()
        {
            return sn.llenarcbxIdPocoStock();
        }

        public OdbcDataReader llenarcbxGanancias()
        {
            return sn.llenarcbxTotalIngresos();
        }

        public OdbcDataReader llenarcbxNombreA()
        {
            return sn.llenarcbxNAlmacen();
        }

        public OdbcDataReader llenarcbxNombreP()
        {
            return sn.llenarcbxNProveedor();
        }

        public OdbcDataReader llenarcbxUsuario()
        {
            return sn.llenarcbxUsuarios();
        }

        public OdbcDataReader llenartxtDes(string id_producto)
        {
            return sn.llenartxtDescripcion(id_producto);
        }

        public OdbcDataReader llenartxtprovee(string id_proveedor)
        {
            return sn.llenartxtProveedor(id_proveedor);
        }

        public OdbcDataReader llenartxtalma(string id_almacen)
        {
            return sn.llenartxtNombrealmacen(id_almacen);
        }

        public OdbcDataReader llenartxtsalida(string id_producto)
        {
            return sn.llenartxtSalidas(id_producto);
        }

        public OdbcDataReader llenartxtusuario(string nombre)
        {
            return sn.llenartxtIdUsuario(nombre);
        }

        public OdbcDataReader llenarcbxPC(string codigo)
        {
            return sn.llenarcbxPrecioCompra(codigo);
        }

        public OdbcDataReader llenarcbxPV(string codigo)
        {
            return sn.llenarcbxPrecioVenta(codigo);
        }

        public OdbcDataReader llenarcbxNProducto(string nombre)
        {
            return sn.llenarcbxNProducto(nombre);
        }

        public OdbcDataReader llenarcbxIDprodu(string nombre)
        {
            return sn.llenarcbxIDProducto(nombre);
        }

        public OdbcDataReader llenarcbxIDprovee(string nombre)
        {
            return sn.llenarcbxIDProveedor(nombre);
        }

        public OdbcDataReader llenarcbxNomProducto(string almacen)
        {
            return sn.llenarcbxNombreProducto(almacen);
        }

        public OdbcDataReader llenarcbxIDAlm(string almacen)
        {
            return sn.llenarcbxIDAlmacen(almacen);
        }

        public OdbcDataReader DashboardTotalS(string fecha1, string fecha2)
        {
            return sn.DashboardTsalidas(fecha1, fecha2);
        }

        public OdbcDataReader DashboardTotalP(string fecha1, string fecha2)
        {
            return sn.DashboardTproducto(fecha1, fecha2);
        }

        public OdbcDataReader DashboardTotalE(string fecha1, string fecha2)
        {
            return sn.DashboardTentradas(fecha1, fecha2);
        }

        public OdbcDataReader DashboardTotalI(string fecha1, string fecha2)
        {
            return sn.DashboardTingresos(fecha1, fecha2);
        }

        public OdbcDataReader DashboardTotalpro()
        {
            return sn.DashboardTProveedores();
        }

        public OdbcDataReader DashboardTotalprod(string fecha1, string fecha2)
        {
            return sn.DashboardTproducto(fecha1, fecha2);
        }

        public OdbcDataReader llenarPermisos(string usuario)
        {
            return sn.llenarcbxPermiso(usuario);
        }

        public int borrar_proveedor(TextBox codigo) 
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("¿Desea eliminar el proveedor #" + codigo.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.eliminarProveedor(codigo.Text);
            return 1;
        }

        public OdbcDataReader llenartxtEntrada(string id_producto)
        {
            return sn.llenartxtStockE(id_producto);
        }

        public OdbcDataReader llenartxtStock(string id_producto)
        {
            return sn.llenartxtEntradas(id_producto);
        }

        public int borrar_usuario(TextBox codigo)
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                MessageBox.Show("El campo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("¿Desea eliminar el usuario #" + codigo.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.eliminarUsuario(codigo.Text);
            return 1;
        }

        public void borrar_compra(string codigo)
        {
            sn.eliminarCompra(codigo);
        }

        public int NuevaCompra(string codigo)
        {
            DialogResult result = MessageBox.Show("¿Desea  hacer una nueva compra? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se va a realizar nueva compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.vaciarCompra(codigo);
            return 1;
        }

        public int NuevoRegistro(string tabla)
        {
            DialogResult result = MessageBox.Show("¿Desea hacer una nueva Operacion? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se va a realizar nueva Operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sn.vaciarRegistro(tabla);
            return 1;
        }
    }
}
