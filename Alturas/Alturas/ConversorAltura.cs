using System;

namespace Alturas
{
    public static class ConversorAltura
    {
        public static double PesParaMetros(double pes)
        {
            return Math.Round(pes * 0.3048, 4);
        }
    }
}