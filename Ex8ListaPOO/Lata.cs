using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8ListaPOO
{
    internal class Lata
    {
        public int raioBase;
        public int altura;

        public Lata(int altura, int raioBase)
        {
            this.altura = altura;
            this.raioBase = raioBase;
        }

        public double calcVolume()
        {
            double volume;
            double baseLata;

            baseLata = 3.14 * Math.Pow(this.raioBase, 2);

            volume = this.altura * baseLata;

            return volume;
        }
    }
}
