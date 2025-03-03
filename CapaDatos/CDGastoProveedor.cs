using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDGastoProveedor
    {
        public DataTable Obtener(int estado)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT gp.Id_Gasto_Proveedor, strftime('%d/%m/%Y', gp.Fecha) AS Fecha, gp.Id_Proveedor, p.Descripcion AS Proveedor, gp.Importe_Total, gp.Estado, " +
                    "IFNULL(SUM(pp.Importe), 0) AS Pago_Total, " +
                    "(gp.Importe_Total - IFNULL(SUM(pp.Importe), 0)) AS Saldo " +
                    "FROM Gastos_Proveedores gp " +
                    "JOIN Proveedores p ON gp.Id_Proveedor = p.Id " +
                    "LEFT JOIN Pago_Proveedor pp ON gp.Id_Gasto_Proveedor = pp.Id_Gasto_Proveedor " +
                    "WHERE gp.Estado = @Estado " +
                    "GROUP BY gp.Id_Gasto_Proveedor, p.Descripcion, gp.Fecha, gp.Importe_Total " +
                    "ORDER BY gp.Fecha DESC " +
                    "LIMIT 55;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", estado);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public int Agregar(CEGastoProveedor cE)
        {
            int idGasto = -1;
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "INSERT INTO Gastos_Proveedores (Id_Proveedor, Fecha, Importe_Total, Estado) " +
                    "VALUES (@Id_Proveedor, @Fecha, @ImporteTotal, @Estado);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Proveedor", cE.IdProveedor);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);

                    comando.ExecuteNonQuery();

                    idGasto = (int)conexion.LastInsertRowId; // Recuperar el ID insertado
                }
            }
            return idGasto;
        }

        public void Actualizar(CEGastoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta = 
                    "UPDATE Gastos_Proveedores " +
                    "SET Id_Proveedor = @Id_Proveedor, Fecha = @Fecha, Importe_Total = @ImporteTotal, Estado = @Estado " +
                    "WHERE Id_Gasto_Proveedor = @Id_Gasto_Proveedor";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Proveedor", cE.IdProveedor);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);
                    comando.Parameters.AddWithValue("@Id_Gasto_Proveedor", cE.IdGastoProveedor);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEstado(CEGastoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "UPDATE Gastos_Proveedores " +
                    "SET Estado = @Estado " +
                    "WHERE Id_Gasto_Proveedor = @Id_Gasto_Proveedor";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);
                    comando.Parameters.AddWithValue("@Id_Gasto_Proveedor", cE.IdGastoProveedor);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CEGastoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {

                string consulta =
                    "DELETE FROM Gastos_Proveedores " +
                    "WHERE Id_Gasto_Proveedor = @Id_Gasto_Proveedor";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Gasto_Proveedor", cE.IdGastoProveedor);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public bool Verificar(int estado)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT EXISTS(SELECT 1 FROM Gastos_Proveedores " +
                    "WHERE Estado = @Estado);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", estado);
                    return Convert.ToBoolean(comando.ExecuteScalar());
                }
            }
        }
        
        public DataTable Buscar(CEGastoProveedor cE)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT gp.Id_Gasto_Proveedor, strftime('%d/%m/%Y', gp.Fecha) AS Fecha, gp.Id_Proveedor, p.Descripcion AS Proveedor, " +
                    "gp.Importe_Total, gp.Estado, IFNULL(SUM(pp.Importe), 0) AS Pago_Total, " +
                    "(gp.Importe_Total - IFNULL(SUM(pp.Importe), 0)) AS Saldo " +
                    "FROM Gastos_Proveedores gp " +
                    "JOIN Proveedores p ON gp.Id_Proveedor = p.Id " +
                    "LEFT JOIN Pago_Proveedor pp ON gp.Id_Gasto_Proveedor = pp.Id_Gasto_Proveedor " +
                    "WHERE 1=1";

                List<SQLiteParameter> parametros = new List<SQLiteParameter>();

                if (cE.IdProveedor > 0)
                {
                    consulta += " AND gp.Id_Proveedor = @Id_Proveedor";
                    parametros.Add(new SQLiteParameter("@Id_Proveedor", cE.IdProveedor));
                }

                if (cE.Mes > 0)
                {
                    consulta += " AND strftime('%m', gp.Fecha) = @Mes";
                    parametros.Add(new SQLiteParameter("@Mes", cE.Mes.ToString("D2")));
                }

                if (cE.Anio > 0)
                {
                    consulta += " AND strftime('%Y', gp.Fecha) = @Anio";
                    parametros.Add(new SQLiteParameter("@Anio", cE.Anio.ToString()));
                }

                if (cE.Estado > 0)
                {
                    consulta += " AND gp.Estado = @Estado";
                    parametros.Add(new SQLiteParameter("@Estado", cE.Estado));
                }

                consulta += " GROUP BY gp.Id_Gasto_Proveedor, p.Descripcion, gp.Fecha, gp.Importe_Total " +
                            "ORDER BY gp.Fecha DESC " +
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