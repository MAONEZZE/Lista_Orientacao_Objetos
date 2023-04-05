using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10ListaPOO
{
    internal class Professor
    {
        public double notaP1, notaP2;
        public double peso1, peso2;

        public Professor(double notaP1, double notaP2, double peso1, double peso2)
        {
            this.notaP1 = notaP1;
            this.notaP2 = notaP2;
            this.peso1 = peso1;
            this.peso2 = peso2;
        }

        public double calcMedia()
        {
            double media;

            media = (this.notaP1 * this.peso1 + this.notaP2 * this.peso2) / (this.peso1 + this.peso2);

            return media;
        }
    }
}
