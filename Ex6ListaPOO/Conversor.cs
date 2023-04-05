using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6ListaPOO
{
    internal class Conversor
    {
        public double grauCelsius;

        public Conversor(double grauCelsius)
        {
            this.grauCelsius = grauCelsius;
        }

        public double calcFahrenheit()
        {
            double grauF;

            grauF = this.grauCelsius * 1.8 + 32;

            return grauF;
        }
    }
}
