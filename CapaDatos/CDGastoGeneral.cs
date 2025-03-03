using System.Data.SQLite;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CDGastoGeneral
    {
        public DataTable Obtener()
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT gg.Id_Gasto_General, strftime('%d/%m/%Y', gg.Fecha) AS Fecha, gg.Id_Categoria_Gasto, cg.Descripcion, gg.Importe_Total, gg.Concepto " +
                    "FROM Gastos_Generales gg " +
                    "LEFT JOIN Categoria_Gasto cg " +
                    "ON gg.Id_Categoria_Gasto = cg.Id " +
                    "ORDER BY gg.Fecha DESC " +
                    "LIMIT 55;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(consulta, conexion))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public void Agregar(CEGastoGeneral cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");
                string consulta =
                    "INSERT INTO Gastos_Generales (Fecha, Importe_Total, Concepto, Id_Categoria_Gasto) " +
                    "VALUES (@Fecha, @ImporteTotal, @Concepto, @Id_Categoria_Gasto)";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Concepto", cE.Concepto);
                    comando.Parameters.AddWithValue("@Id_Categoria_Gasto", cE.IdCategoriaGasto);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(CEGastoGeneral cE) 
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");
                string consulta =
                    "UPDATE Gastos_Generales " +
                    "SET Fecha = @Fecha, Importe_Total = @ImporteTotal, Concepto = @Concepto, Id_Categoria_Gasto = @Id_Categoria_Gasto " +
                    "WHERE Id_Gasto_General = @Id_Gasto_General";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@ImporteTotal", cE.ImporteTotal);
                    comando.Parameters.AddWithValue("@Concepto", cE.Concepto);
                    comando.Parameters.AddWithValue("@Id_Categoria_Gasto", cE.IdCategoriaGasto);
                    comando.Parameters.AddWithValue("@Id_Gasto_General", cE.IdGastoGeneral);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CEGastoGeneral cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "DELETE FROM Gastos_Generales " +
                    "WHERE Id_Gasto_General = @Id_Gasto_General";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Gasto_General", cE.IdGastoGeneral);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable Buscar(CEGastoGeneral cE)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT gg.Id_Gasto_General, strftime('%d/%m/%Y', gg.Fecha) AS Fecha, gg.Id_Categoria_Gasto, cg.Descripcion, gg.Importe_Total, gg.Concepto " +
                    "FROM Gastos_Generales gg " +
                    "LEFT JOIN Categoria_Gasto cg " +
                    "ON gg.Id_Categoria_Gasto = cg.Id " +
                    "WHERE 1=1";

                List<SQLiteParameter> parametros = new List<SQLiteParameter>();

                if (cE.IdCategoriaGasto > 0)
                {
                    consulta += " AND gg.Id_Categoria_Gasto = @idCategoriaGasto";
                    parametros.Add(new SQLiteParameter("@idCategoriaGasto", cE.IdCategoriaGasto));
                }

                if (!string.IsNullOrEmpty(cE.Concepto))
                {
                    consulta += " AND gg.Concepto LIKE @concepto";
                    parametros.Add(new SQLiteParameter("@concepto", $"%{cE.Concepto}%"));
                }

                if (cE.Mes > 0)
                {
                    consulta += " AND strftime('%m', gg.Fecha) = @mes";
                    parametros.Add(new SQLiteParameter("@mes", cE.Mes.ToString("D2")));
                }

                if (cE.Anio > 0)
                {
                    consulta += " AND strftime('%Y', gg.Fecha) = @anio";
                    parametros.Add(new SQLiteParameter("@anio", cE.Anio.ToString()));
                }

                consulta += " ORDER BY gg.Fecha;";

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

