namespace CapaEntidad
{
    /*
     *  Clase base
     */
    public class CEDescripcion 
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public EstadoDescripcion Estado { get; set; }

        public enum EstadoDescripcion
        {
            ACTIVO = 1,
            INACTIVO,
        }

    }



    /*
    *  Clases derivadas: Los nombres corresponden con las tablas de la base de datos
    */
    public class Categoria_Gasto : CEDescripcion { }

    public class Categoria_Venta : CEDescripcion { }

    public class Proveedores : CEDescripcion { }

    public class Clientes : CEDescripcion { }

    public class Productos : CEDescripcion 
    {
        // Productos de lista
        public int IdLista { get; set; }
        public decimal Precio { get; set; }

    }

}