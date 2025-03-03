namespace CapaNegocio
{
    public class UtilidadesFecha
    {
        public enum Meses
        {
            ENERO = 1,
            FEBRERO,
            MARZO,
            ABRIL,
            MAYO,
            JUNIO,
            JULIO,
            AGOSTO,
            SEPTIEMBRE,
            OCTUBRE,
            NOVIEMBRE,
            DICIEMBRE                
        }

        public static void CargarMeses(ComboBox cmb)
        {
            cmb.DataSource = Enum.GetValues(typeof(Meses));
            cmb.SelectedIndex = -1;
        }

        public static void ObtenerAnios(NumericUpDown control)
        {
            control.Minimum = 2023;
            control.Maximum = DateTime.Now.Year;
            control.Value = DateTime.Now.Year;
            control.Increment = 1;
        }

        public static (int mesAnterior, int anioAnterior) ObtenerMesYAnioAnterior(int mesActual, int anioActual)
        {
            int mesAnterior = mesActual - 1;
            int anioAnterior = anioActual;

            if (mesAnterior == 0)
            {
                mesAnterior = 12;
                anioAnterior--;
            }

            return (mesAnterior, anioAnterior);
        }

    }
}