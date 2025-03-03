using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDPagoProveedor
    {
        public DataTable Obtener()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Id_Pago_Proveedor, Id_Gasto_Proveedor, strftime('%d/%m/%Y', Fecha) AS Fecha, Importe FROM Pago_Proveedor " +
                    "ORDER BY Fecha DESC, Id_Pago_Proveedor DESC " +
                    "LIMIT 55; ";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public DataTable ObtenerPorId(int idGasto)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Id_Pago_Proveedor, Id_Gasto_Proveedor, strftime('%d/%m/%Y', Fecha) AS Fecha, Importe FROM Pago_Proveedor " +
                    "WHERE Id_Gasto_Proveedor = @Id_Gasto " +
                    "ORDER BY Fecha DESC;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Gasto", idGasto);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void Agregar(CEPagoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "INSERT INTO Pago_Proveedor (Id_Gasto_Proveedor, Fecha, Importe) " +
                    "VALUES (@Id_Gasto_Proveedor, @Fecha, @Importe)";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Gasto_Proveedor", cE.IdGastoProveedor);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Importe", cE.Importe);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(CEPagoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "UPDATE Pago_Proveedor " +
                    "SET Fecha = @Fecha, Importe = @Importe " +
                    "WHERE Id_Pago_Proveedor = @Id_Pago_Proveedor";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Importe", cE.Importe);
                    comando.Parameters.AddWithValue("@Id_Pago_Proveedor", cE.IdPagoProveedor);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CEPagoProveedor cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "DELETE FROM Pago_Proveedor " +
                    "WHERE Id_Pago_Proveedor = @Id_Pago_Proveedor";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Pago_Proveedor", cE.IdPagoProveedor);
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
