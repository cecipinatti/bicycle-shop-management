using System.Data.SQLite;
using System.Data;
using CapaEntidad;
using static CapaEntidad.CELista;

namespace CapaDatos
{
    public class CDLista
    {
        public DataTable Obtener(int estado)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT l.Id_Lista, l.Id_Proveedor, p.Descripcion AS Proveedor, l.Descripcion, strftime('%d/%m/%Y', l.Fecha) AS Fecha, l.Porcentaje " +
                    "FROM Listas l " +
                    "JOIN Proveedores p ON l.Id_Proveedor = p.Id " +
                    "WHERE l.Estado = @Estado;";

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

        public int Agregar(CELista cE)
        {
            int idLista = -1;
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "INSERT INTO Listas (Id_Proveedor, Descripcion, Fecha, Porcentaje, estado) " +
                    "VALUES (@Id_Proveedor, @Descripcion, @Fecha, @Porcentaje, @Estado);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Proveedor", cE.IdProveedor);
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Porcentaje", cE.Porcentaje);
                    comando.Parameters.AddWithValue("@Estado", (int)EstadoLista.ACTIVA);

                    comando.ExecuteNonQuery();

                    idLista = (int)conexion.LastInsertRowId; // Recuperar el ID insertado
                }
            }
            return idLista;
        }

        public void Actualizar(CELista cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string fechaFormateada = cE.Fecha.ToString("yyyy-MM-dd");

                string consulta =
                    "UPDATE Listas " +
                    "SET Descripcion = @Descripcion, Fecha = @Fecha, Porcentaje = @Porcentaje " +
                    "WHERE Id_Lista = @Id_Lista";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.Parameters.AddWithValue("@Fecha", fechaFormateada);
                    comando.Parameters.AddWithValue("@Porcentaje", cE.Porcentaje);
                    comando.Parameters.AddWithValue("@Id_Lista", cE.IdLista);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEstado(CELista cE, EstadoLista estado)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = "UPDATE Listas SET Estado = @Estado WHERE Id_Lista = @Id_Lista";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", (int)estado);
                    comando.Parameters.AddWithValue("@Id_Lista", cE.IdLista);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public bool Verificar(string descripcion)
        {
            bool existenciaDescripcion;

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"SELECT EXISTS(SELECT 1 FROM Listas WHERE Descripcion = @Descripcion);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);

                    existenciaDescripcion = Convert.ToBoolean(comando.ExecuteScalar());
                }
            }

            return existenciaDescripcion;
        }

    }
}
