using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5ListaPOO
{
    internal class Esfera
    {
        public int raio;

        public Esfera(int raio)
        {
            this.raio = raio;
        }

        public double calcVolumeEsfera()
        {
            double volume;

            volume = (4/3) * 3.14 * Math.Pow(this.raio, 3);

            return volume;

            
        }
    }
}
