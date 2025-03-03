using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDPagoCliente
    {
        public DataTable Obtener()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Id_Pago_Cliente, Id_Venta, strftime('%d/%m/%Y', Fecha) AS Fecha, Importe FROM Pago_Cliente " +
                    "ORDER BY Id_Pago_Cliente DESC " +
                    "LIMIT 55;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public DataTable ObtenerPorId(int idVenta)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Id_Pago_Cliente, Id_Venta, strftime('%d/%m/%Y', Fecha) AS Fecha, Importe FROM Pago_Cliente " +
                    "WHERE Id_Venta = @IdVenta " +
                    "ORDER BY Fecha DESC;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdVenta", idVenta);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void Agregar(CEPagoCliente cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "INSERT INTO Pago_Cliente (Id_Venta, Fecha, Importe) " +
                    "VALUES (@Id_Venta, @Fecha, @Importe)";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Venta", cE.IdVenta);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Importe", cE.Importe);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(CEPagoCliente cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "UPDATE Pago_Cliente " +
                    "SET Fecha = @Fecha, Importe = @Importe " +
                    "WHERE Id_Pago_Cliente = @Id_Pago_Cliente";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Importe", cE.Importe);
                    comando.Parameters.AddWithValue("@Id_Pago_Cliente", cE.IdPagoCliente);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CEPagoCliente cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "DELETE FROM Pago_Cliente " +
                    "WHERE Id_Pago_Cliente = @Id_Pago_Cliente";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Pago_Cliente", cE.IdPagoCliente);
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
