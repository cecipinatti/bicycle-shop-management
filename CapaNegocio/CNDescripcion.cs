using CapaDatos;
using CapaEntidad;
using System.Data;
using static CapaEntidad.CEDescripcion;

namespace CapaNegocio
{
    public class CNDescripcion<T> : CNIDescripcion where T : CEDescripcion, new()
    {
        private readonly CDDescripcion<T> cD = new();

        private T ConvertirEntidad(CEDescripcion cE)
        {
            if (cE is T entidad)
                return entidad;

            throw new InvalidCastException("Tipo no compatible.");
        }

        private string FormatearDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion)) return descripcion;

            return descripcion.Substring(0, 1).ToUpper() + descripcion.Substring(1).ToLower();
        }

        public bool Verificar(CEDescripcion cE, out string mensajeValidacion)
        {
            mensajeValidacion = string.Empty;

            try
            {
                var entidad = cE as T;
                if (entidad == null)
                {
                    mensajeValidacion = "Tipo no compatible.";
                    return false;
                }

                string descripcionNormalizada = FormatearDescripcion(cE.Descripcion);
                
                if (string.IsNullOrWhiteSpace(descripcionNormalizada))
                {
                    mensajeValidacion = "La descripción no puede estar vacía.";
                    return false;
                }

                if (cD.Verificar(descripcionNormalizada))
                {
                    mensajeValidacion = "Registro ya existente.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                mensajeValidacion = $"Error al verificar existencia:\n {ex.Message}";
                return false;
            }
        }



        public DataTable Obtener(int estado)
        {
            return cD.Obtener(estado);
        }
 
        public string Agregar(CEDescripcion cE)
        {
            try
            {
                var entidad = ConvertirEntidad(cE);
                entidad.Descripcion = FormatearDescripcion(entidad.Descripcion);

                cD.Agregar(entidad);
                return "Registro creado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al crear el registro:\n" + ex.Message;
            }
        }

        public string ActualizarDescripcion(CEDescripcion cE)
        {
            try
            {
                var entidad = ConvertirEntidad(cE);
                entidad.Descripcion = FormatearDescripcion(entidad.Descripcion);

                cD.ActualizarDescripcion(entidad);
                return "Registro actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el registro:\n" + ex.Message;
            }

        }

        public string ActualizarEstado(CEDescripcion cE, EstadoDescripcion estado)
        {
            try
            {
                var entidad = ConvertirEntidad(cE);
                entidad.Estado = estado;

                cD.ActualizarEstado(entidad, estado);
                return estado == EstadoDescripcion.ACTIVO ? "Registro restaurado exitosamente." : "Registro eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el estado del registro:\n{ex.Message}";
            }
        }



        /*
         *  Productos (de lista)
         */
        public DataTable ObtenerProductos(int idLista = -1)
        {
            return cD.ObtenerProductos(idLista);
        }

        // Al agregar/actualizar lista:
        // Agregar, actualizar y eliminar productos
        public string AgregarProductos(int idLista, List<Productos> nuevaLista)
        {
            try
            {
                int cantidadAgregados = 0, cantidadActualizados = 0, cantidadEliminados = 0;
                var listaPrevia = cD.ObtenerProductosPorIdLista(idLista);

                // conjuntos para comparación
                var descripcionesPrevias = listaPrevia.Select(p => p.Descripcion).ToHashSet();
                var descripcionesNuevas = nuevaLista.Select(p => p.Descripcion).ToHashSet();


                // Agregar o Actualizar
                foreach (var productoNuevo in nuevaLista)
                {
                    productoNuevo.IdLista = idLista;
                    productoNuevo.Estado = EstadoDescripcion.ACTIVO;

                    if (descripcionesPrevias.Contains(productoNuevo.Descripcion))
                    {
                        // el producto ya existe
                        cD.Actualizar(productoNuevo);
                        cantidadActualizados++;
                    }
                    else
                    {
                        // el producto no existe
                        cD.Agregar(productoNuevo);
                        cantidadAgregados++;
                    }
                }

                // Eliminar
                foreach (var productoPrevio in listaPrevia)
                {
                    productoPrevio.IdLista = idLista;
                    if (!descripcionesNuevas.Contains(productoPrevio.Descripcion))
                    {
                        // el producto no está en la nueva lista
                        var entidad = ConvertirEntidad(productoPrevio);
                        cD.ActualizarEstado(entidad, EstadoDescripcion.INACTIVO);
                        cantidadEliminados++;
                    }
                }

                return $"Productos procesados correctamente.\n" +
                       $"Agregados: {cantidadAgregados}, Actualizados: {cantidadActualizados}, Eliminados: {cantidadEliminados}";
            }
            catch (Exception ex)
            {
                return $"Error al procesar los productos: {ex.Message}";
            }
        }

        // Al actualizar estado de lista (eliminar o restaurar):
        public void ActualizarEstadoProductos(int idLista, EstadoDescripcion estado)
        {
            var productos = cD.ObtenerProductosPorIdLista(idLista);

            foreach (var producto in productos)
            {
                var entidad = ConvertirEntidad(producto);
                cD.ActualizarEstado(entidad, estado);
            }
        }

        public string ObtenerDescripcionProductoPorId(int idProducto)
        {
            return cD.ObtenerDescripcionPorId(idProducto);
        }

        public DataTable BuscarProductos(Productos cE, bool incluirMasVendidos)
        {
            return cD.BuscarProductos(cE, incluirMasVendidos);
        }

    }
}

