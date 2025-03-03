using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDProductoVenta
    {
        public DataTable ObtenerProductosVendidos()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                     "SELECT pv.Id_Producto, pv.Cantidad, p.Descripcion " +
                     "FROM Productos p " +
                     "INNER JOIN Producto_Venta pv ON p.Id = pv.Id_Producto " +
                     "INNER JOIN Ventas v ON pv.Id_Venta = v.Id_Venta " +
                     "WHERE p.Estado = 1 " +
                     "ORDER BY v.Id_Venta DESC " +
                     "LIMIT 55;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public DataTable ObtenerProductosPorId(int idVenta)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                     "SELECT pv.Id_Producto, pv.Cantidad, p.Descripcion " +
                     "FROM Productos p " +
                     "JOIN Producto_Venta pv ON p.Id = pv.Id_Producto " +
                     "JOIN Ventas v ON pv.Id_Venta = v.Id_Venta " +
                     "WHERE v.Id_Venta = @Id_Venta;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Venta", idVenta);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void Agregar(CEProductoVenta cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "INSERT INTO Producto_Venta (Id_Producto, Id_Venta, Cantidad) " +
                    "VALUES (@Id_Producto, @Id_Venta, @Cantidad)";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Producto", cE.IdProducto);
                    comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);
                    comando.Parameters.AddWithValue("@Cantidad", cE.Cantidad);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //public void Actualizar(CEProductoVenta cE)
        //{
        //    using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
        //    {
        //        string consulta =
        //            "UPDATE Producto_Venta " +
        //            "SET Cantidad = @Cantidad " +
        //            "WHERE Id_Producto = @Id_Producto AND Id_Venta = @Id_Venta";

        //        using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
        //        {
        //            comando.Parameters.AddWithValue("@Cantidad", cE.Cantidad);
        //            comando.Parameters.AddWithValue("@Id_Producto", cE.IdProducto);
        //            comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);

        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //}

        public void Eliminar(/*CEProductoVenta cE*/ int idVenta)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = "DELETE FROM Producto_Venta WHERE Id_Venta = @Id_Venta";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Venta", idVenta/*cE.IdVenta*/);
                    comando.ExecuteNonQuery();
                }

                //string consulta =
                //    "DELETE FROM Producto_Venta " +
                //    "WHERE Id_Producto = @Id_Producto AND Id_Venta = @Id_Venta";

                //using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                //{
                //    comando.Parameters.AddWithValue("@Id_Producto", cE.IdProducto);
                //    comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);

                //    comando.ExecuteNonQuery();
                //}
            }
        }

    }
}
