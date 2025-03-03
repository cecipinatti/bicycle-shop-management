using System.Globalization;

namespace CapaPresentacion
{
    public class UtilidadesImporte
    {
        public static bool EsDecimalMayorACero(string texto, out decimal resultado)
        {
            return decimal.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, out resultado) && resultado > 0;
        }

        public static void FormatearImporte(TextBox textBox)
        {
            textBox.Leave += (sender, e) =>
            {
                if (decimal.TryParse(textBox.Text.Replace(",", ""), out decimal valor))
                {
                    textBox.Text = valor.ToString("#,##0.00", CultureInfo.CurrentCulture);
                }
            };
        }

    }
}
