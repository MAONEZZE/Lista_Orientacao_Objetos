using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3ListaPOO
{
    internal class Cilindro
    {
        public double altura;
        public double raioBase;

        public Cilindro(double altura, double raioBase)
        {
            this.altura = altura;
            this.raioBase = raioBase;
        }

        public double calcVolumeCilindro()
        {
            double volume, baseCL;

            baseCL = 3.14 * this.raioBase;
            volume = baseCL * altura;
            return volume;
            
        }
    }
}
