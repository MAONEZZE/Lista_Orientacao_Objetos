using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2ListaPOO
{
    internal class Conversor
    {
        public double grauF;

        public Conversor(double grauF)
        {
            this.grauF = grauF;
        }

        public double calcGrauCelsius()
        {
            double grauCelsius;

            grauCelsius = (5 / 9) * (this.grauF - 32);

            return grauCelsius;
        }
    }
}
