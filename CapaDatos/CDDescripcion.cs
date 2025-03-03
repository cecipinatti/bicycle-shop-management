using CapaEntidad;
using System.Data;
using System.Data.SQLite;
using static CapaEntidad.CEDescripcion;

namespace CapaDatos
{
    public class CDDescripcion<T> where T : CEDescripcion, new()
    {
        public DataTable Obtener(int estado)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"SELECT * FROM {typeof(T).Name} " +
                    "WHERE Estado = @Estado ";

                if (typeof(T) == typeof(Productos))
                {
                    consulta += " AND Id_Lista IS NULL ";
                }

                consulta += "ORDER BY Descripcion;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", estado);

                    using (var adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public void Agregar(T cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"INSERT INTO {typeof(T).Name} (Descripcion) VALUES (@Descripcion)";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarDescripcion(T cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"UPDATE {typeof(T).Name} SET Descripcion = @Descripcion " +
                    "WHERE Id = @Id";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.Parameters.AddWithValue("@Id", cE.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEstado(T cE, EstadoDescripcion estado)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"UPDATE {typeof(T).Name} SET Estado = @Estado WHERE Id = @Id";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Estado", (int)estado);
                    comando.Parameters.AddWithValue("@Id", cE.Id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public bool Verificar(string descripcion)
        {
            bool existenciaDescripcion;

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = $"SELECT EXISTS(SELECT 1 FROM {typeof(T).Name} WHERE Descripcion = @Descripcion);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);

                    existenciaDescripcion = Convert.ToBoolean(comando.ExecuteScalar());
                }
            }

            return existenciaDescripcion;
        }



        /*
         *  Productos (de lista)
         */
        public DataTable ObtenerProductos(int idLista)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT p.Id AS Id_Producto, p.Descripcion, p.Precio, " +
                    "(p.Precio * (1 + l.Porcentaje / 100)) AS Precio_Final " +
                    "FROM Productos p " +
                    "LEFT JOIN Listas l " +
                    "ON p.Id_Lista = l.Id_Lista " +
                    "WHERE l.Id_Lista = @Id_Lista";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Lista", idLista);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public List<Productos> ObtenerProductosPorIdLista(int idLista)
        {
            List<Productos> productos = new();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT * FROM Productos WHERE Id_Lista = @Id_Lista;";
                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Lista", idLista);
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(MapearProducto(reader));
                        }
                    }
                }
            }
            return productos;
        }

        private Productos MapearProducto(SQLiteDataReader reader)
        {
            return new Productos
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                IdLista = reader.GetInt32(reader.GetOrdinal("Id_Lista")),
                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                Estado = (EstadoDescripcion)reader.GetInt32(reader.GetOrdinal("Estado")),
                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
            };
        }

        public void Agregar(Productos cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "INSERT INTO Productos (Id_Lista, Descripcion, Estado, Precio) " +
                    "VALUES (@Id_Lista, @Descripcion, @Estado, @Precio);";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Lista", cE.IdLista);
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);
                    comando.Parameters.AddWithValue("@Precio", cE.Precio);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(Productos cE)
        {
            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "UPDATE Productos " +
                    "SET Estado = @Estado, Precio = @Precio " +
                    "WHERE Descripcion = @Descripcion;";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Descripcion", cE.Descripcion);
                    comando.Parameters.AddWithValue("@Precio", cE.Precio);
                    comando.Parameters.AddWithValue("@Estado", cE.Estado);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //public void Eliminar(Productos cE)
        //{
        //    using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
        //    {
        //        string consulta =
        //            "DELETE FROM Productos " +
        //            "WHERE Id = @Id";

        //        using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
        //        {
        //            comando.Parameters.AddWithValue("@Id", cE.Id);
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //}

        public DataTable BuscarProductos(Productos cE, bool incluirMasVendidos)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta =
                    "SELECT " +
                    "(SELECT SUM(pv.Cantidad) FROM Producto_Venta pv " +
                    " WHERE pv.Id_Producto = p.Id " +
                    " AND pv.Id_Venta IN (SELECT v.Id_Venta FROM Ventas v WHERE v.Fecha >= DATE('now', '-6 months'))) AS Vendidos, " +
                    "p.Id AS Id_Producto, p.Descripcion, p.Precio, " +
                    "(p.Precio * (1 + IFNULL(l.Porcentaje, 0) / 100)) AS Precio_Final " +
                    "FROM Productos p " +
                    "LEFT JOIN Listas l ON p.Id_Lista = l.Id_Lista " +
                    "WHERE p.Estado = 1 ";

                List<string> filtros = new List<string>();

                if (cE.IdLista == 0)
                {
                    filtros.Add("p.Id_Lista IS NULL"); // Productos sin lista
                }
                else if (cE.IdLista > 0)
                {
                    filtros.Add("l.Id_Lista = @Id_Lista");
                }

                string[] palabrasFiltro = cE.Descripcion.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < palabrasFiltro.Length; i++)
                {
                    filtros.Add($"p.Descripcion LIKE @Filtro{i}");
                }

                if (filtros.Count > 0)
                {
                    consulta += " AND " + string.Join(" AND ", filtros);
                }

                consulta += (incluirMasVendidos)
                    ? " ORDER BY Vendidos DESC NULLS LAST, p.Descripcion LIMIT 100"
                    : " ORDER BY p.Descripcion LIMIT 100";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    if (cE.IdLista > 0)
                    {
                        comando.Parameters.AddWithValue("@Id_Lista", cE.IdLista);
                    }

                    for (int i = 0; i < palabrasFiltro.Length; i++)
                    {
                        comando.Parameters.AddWithValue($"@Filtro{i}", "%" + palabrasFiltro[i] + "%");
                    }

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(comando))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public string ObtenerDescripcionPorId(int idProducto)
        {
            string descripcion = "Descripción no encontrada";

            using (SQLiteConnection conexion = Conexion.getConexion().crearConexion())
            {
                string consulta = "SELECT Descripcion FROM Productos WHERE Id = @Id_Producto";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id_Producto", idProducto);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        descripcion = resultado.ToString();
                    }
                }
            }

            return descripcion;
        }

    }
}