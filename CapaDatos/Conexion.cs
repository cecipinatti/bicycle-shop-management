using System.Data.SQLite;

namespace CapaDatos
{
    public class Conexion
    {
        private string basedatos;
        private static Conexion conexion = null;

        private Conexion()
        {
            basedatos = "./bd_gestor.db";
        }

        public SQLiteConnection crearConexion()
        {
            SQLiteConnection conexion = null;
            try
            {
                conexion = new SQLiteConnection("Data Source=" + basedatos);
                conexion.Open();

                // Habilitar las claves foráneas
                using (var comando = new SQLiteCommand("PRAGMA foreign_keys = ON;", conexion))
                {
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
            return conexion;
        }

        public static Conexion getConexion()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
    }
}
