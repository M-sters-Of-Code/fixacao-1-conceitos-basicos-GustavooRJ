using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometrometragemInicial, int quilometragemFinal)
        {
            double valorDiario = 100.0;
            double valorKm = 0.50;

            int quilometragemRodada = quilometrometragemInicial - quilometragemFinal;
            double valorTotal = (dias * valorDiario) + (quilometragemRodada * valorKm);

            return valorTotal;
        }
    }
}
