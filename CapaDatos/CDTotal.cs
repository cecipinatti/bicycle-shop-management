using System.Data.SQLite;
using System.Data;

namespace CapaDatos
{
    public class CDTotal
    {
        public DataTable ObtenerPorMes(int anio)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Mes, Total_Gasto, Total_Ingreso FROM Totales " +
                    "WHERE Anio = @anio " +
                    "ORDER BY Mes DESC;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@anio", anio.ToString());

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable ObtenerPorAnio()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                   "SELECT Anio, " +                   
                   "SUM(Total_Gasto) AS Total_Gasto, " +
                   "SUM(Total_Ingreso) AS Total_Ingreso " +
                   "FROM Totales " +
                   "GROUP BY Anio " +
                   "ORDER BY Anio DESC;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public (decimal totalIngreso, decimal totalGasto) ObtenerPorMesYAnio(int mes, int anio)
        {
            decimal totalIngreso = 0;
            decimal totalGasto = 0;

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT Total_Ingreso, Total_Gasto FROM Totales " +
                    "WHERE Anio = @anio AND Mes = @mes;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@anio", anio);
                    comando.Parameters.AddWithValue("@mes", mes);

                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalIngreso = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                            totalGasto = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        }
                    }
                }
            }

            return (totalIngreso, totalGasto);
        }

    }
}