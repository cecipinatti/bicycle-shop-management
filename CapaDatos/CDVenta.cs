using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDVenta
    {
        public DataTable Obtener()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT v.Id_Venta, strftime('%d/%m/%Y', v.Fecha) AS Fecha, v.Id_Categoria_Venta, cv.Descripcion AS Categoria_Venta, v.Id_Cliente, " +
                    "c.Descripcion AS Cliente,  v.Importe_Total, IFNULL(SUM(pc.Importe), 0) AS Pago_Total, (v.Importe_Total - IFNULL(SUM(pc.Importe), 0)) AS Saldo, v.Estado FROM Ventas v " +
                    "LEFT JOIN Categoria_Venta cv ON v.Id_Categoria_Venta = cv.Id " +
                    "LEFT JOIN Clientes c ON v.Id_Cliente = c.Id " +
                    "LEFT JOIN Pago_Cliente pc ON v.Id_Venta = pc.Id_Venta " +
                    "GROUP BY v.Id_Venta, v.Fecha, cv.Descripcion, c.Descripcion " +
                    "ORDER BY v.Fecha DESC, v.Id_Venta DESC " +
                    "LIMIT 55;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public int Agregar(CEVenta cE)
        {
            int idVenta = -1;
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "INSERT INTO Ventas (Id_Categoria_Venta, Id_Cliente, Fecha, Importe_Total, Estado) " +
                    "VALUES (@Id_Categoria_Venta, @Id_Cliente, @Fecha, @ImporteTotal, @Estado);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Categoria_Venta", cE.IdCategoriaVenta);
                    comando.Parameters.AddWithValue("@Id_Cliente", cE.IdCliente.HasValue ? (object)cE.IdCliente.Value : DBNull.Value);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);

                    comando.ExecuteNonQuery();

                    idVenta = (int)conexion.LastInsertRowId; // Recuperar el ID insertado
                }
            }
            return idVenta;
        }

        public int Actualizar(CEVenta cE)
        {
            int filasAfectadas = 0;
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "UPDATE Ventas " +
                    "SET Id_Categoria_Venta = @Id_Categoria_Venta, Id_Cliente = @Id_Cliente, Fecha = @Fecha, " +
                    "Importe_Total = @ImporteTotal, Estado = @Estado " +
                    "WHERE Id_Venta = @Id_Venta";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Categoria_Venta", cE.IdCategoriaVenta);
                    comando.Parameters.AddWithValue("@Id_Cliente", cE.IdCliente.HasValue ? (object)cE.IdCliente.Value : DBNull.Value);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);
                    comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);

                    filasAfectadas = comando.ExecuteNonQuery();
                }
            }
            return filasAfectadas > 0 ? cE.IdVenta : -1;
        }

        public void ActualizarEstado(CEVenta cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "UPDATE Ventas " +
                    "SET Estado = @Estado " +
                    "WHERE Id_Venta = @Id_Venta";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);
                    comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CEVenta cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "DELETE FROM Ventas " +
                    "WHERE Id_Venta = @IdVenta";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdVenta", cE.IdVenta);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable Buscar(CEVenta cE)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT  v.Id_Venta, strftime('%d/%m/%Y', v.Fecha) AS Fecha, v.Id_Categoria_Venta,  cv.Descripcion AS Categoria_Venta, v.Id_Cliente, " +
                    "c.Descripcion AS Cliente,  v.Importe_Total, IFNULL(SUM(pc.Importe), 0) AS Pago_Total, (v.Importe_Total - IFNULL(SUM(pc.Importe), 0)) AS Saldo, v.Estado FROM Ventas v " +
                    "LEFT JOIN Categoria_Venta cv ON v.Id_Categoria_Venta = cv.Id " +
                    "LEFT JOIN Clientes c ON v.Id_Cliente = c.Id " +
                    "LEFT JOIN Pago_Cliente pc ON v.Id_Venta = pc.Id_Venta " +
                    "WHERE 1=1";

                List<SQLiteParameter> parametros = new List<SQLiteParameter>();

                if (cE.IdCategoriaVenta > 0)
                {
                    consulta += " AND v.Id_Categoria_Venta = @IdCategoriaVenta";
                    parametros.Add(new SQLiteParameter("@IdCategoriaVenta", cE.IdCategoriaVenta));
                }

                if (cE.IdCliente > 0)
                {
                    consulta += " AND v.Id_Cliente = @IdCliente";
                    parametros.Add(new SQLiteParameter("@IdCliente", cE.IdCliente));
                }

                if (cE.Mes > 0)
                {
                    consulta += " AND strftime('%m', v.Fecha) = @Mes";
                    parametros.Add(new SQLiteParameter("@Mes", cE.Mes.ToString("D2")));
                }

                if (cE.Anio > 0)
                {
                    consulta += " AND strftime('%Y', v.Fecha) = @Anio";
                    parametros.Add(new SQLiteParameter("@Anio", cE.Anio.ToString()));
                }

                if (cE.Estado > 0)
                {
                    consulta += " AND v.Estado = @Estado";
                    parametros.Add(new SQLiteParameter("@Estado", cE.Estado));
                }

                consulta += " GROUP BY v.Id_Venta, v.Fecha, cv.Descripcion, c.Descripcion " +
                            "ORDER BY v.Fecha DESC, v.Id_Venta DESC " +
                            "LIMIT 55;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddRange(parametros.ToArray());

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

    }
}
