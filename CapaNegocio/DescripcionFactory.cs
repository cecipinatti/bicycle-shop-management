using CapaEntidad;

namespace CapaNegocio
{
    public class DescripcionFactory
    {
        //public static CEDescripcion CrearEntidad(CEDescripcion baseEntidad)
        //{
        //    return baseEntidad switch
        //    {
        //        Categoria_Gasto => new Categoria_Gasto(),
        //        Categoria_Venta => new Categoria_Venta(),
        //        Productos => new Productos(),
        //        Proveedores => new Proveedores(),
        //        Clientes => new Clientes(),
        //        _ => throw new InvalidOperationException("Tipo no soportado")
        //    };
        //}
        //public static T CrearEntidad<T>() where T : CEDescripcion, new()
        //{
        //    return new T();
        //}
        public static CEDescripcion CrearEntidad(CEDescripcion baseEntidad)
        {
            var tipoEntidad = baseEntidad.GetType();
            return (CEDescripcion)Activator.CreateInstance(tipoEntidad)!;
        }

    }
}
