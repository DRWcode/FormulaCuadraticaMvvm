using System;

namespace FormulaCuadraticaMvvm.Models
{
    public class FormulaCuadratica
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public string Calcular()
        {
            if (A != 0)
            {
                double resultadoRaiz = Math.Pow(B, 2) - (4 * A * C);

                if (resultadoRaiz >= 0)
                {
                    double x1 = (-B + Math.Sqrt(resultadoRaiz)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(resultadoRaiz)) / (2 * A);

                    return $"X1={x1}, X2={x2}";
                }
                else
                {
                    return "La raíz cuadrada no puede ser negativa";
                }
            }
            else
            {
                return "El valor de A no puede ser cero";
            }
        }
    }
}
