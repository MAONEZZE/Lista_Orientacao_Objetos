using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4ListaPOO
{
    internal class Veiculo
    {
        public int kmInicial;
        public int kmFinal;
        public int consumo;

        public Veiculo(int kmInicial, int kmFinal, int consumo)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.consumo = consumo;
        }

        public double calcCombustivelPorKm()
        {
            int kmTotal;
            double combKm;

            kmTotal = kmFinal - kmInicial;
            combKm = consumo / kmTotal;

            return combKm;

            
        }
    }
}
