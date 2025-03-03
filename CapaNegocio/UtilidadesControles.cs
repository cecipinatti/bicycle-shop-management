namespace CapaNegocio
{
    public class UtilidadesControles
    {
        public static void InicializarNumericUpDown(NumericUpDown control)
        {
            control.Minimum = 0;
            control.Maximum = int.MaxValue;
            control.Increment = 1;
        }

    }
}
