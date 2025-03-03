using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNProductoVenta
    {
        private readonly CDProductoVenta cD = new();

        public DataTable ObtenerProductosVendidos()
        {
            return cD.ObtenerProductosVendidos();
        }

        public DataTable ObtenerProductosPorId(int idVenta)
        {
            return cD.ObtenerProductosPorId(idVenta);
        }

        public string AgregarProductoVenta(int idVenta, List<CEProductoVenta> listaProductosVenta)
        {
            try
            {
                foreach (var producto in listaProductosVenta)
                {
                    producto.IdVenta = idVenta;
                    cD.Agregar(producto);
                }

                return "Registro creado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear el registro:\n" + ex.Message;
            }
        }

        public string ActualizarProductoVenta(int idVenta, List<CEProductoVenta> listaProductosVenta)
        {
            try
            {
                string mensajeEliminacion = EliminarProductoVenta(idVenta);

                int productosAgregados = 0;
                foreach (var producto in listaProductosVenta)
                {
                    producto.IdVenta = idVenta;
                    cD.Agregar(producto);
                    productosAgregados++;
                }

                return "Registro actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el registro:\n" + ex.Message;
            }
        }

        public string EliminarProductoVenta(/*CEProductoVenta cE*/ int idVenta)
        {
            try
            {
                //cD.Eliminar(cE);
                cD.Eliminar(idVenta);
                return "Registro eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el registro:\n" + ex.Message;
            }
        }

    }
}
