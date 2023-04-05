using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9ListaPOO
{
    internal class Professor
    {
        public double nota1, nota2, nota3, nota4, nota5;

        public Professor(double nota1, double nota2, double nota3, double nota4, double nota5)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.nota5 = nota5;

        }

        public double calcMediaHarmonica()
        {
            double media;
            double divisor;

            divisor = (1 / this.nota1) + (1 / this.nota2) + (1 / this.nota3) + (1 / this.nota4) + (1 / this.nota5);

            media = 5 / divisor;

            return media;
        }
    }
}
