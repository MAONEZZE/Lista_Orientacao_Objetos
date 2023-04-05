using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1ListaPOO
{
    internal class Caixa
    {
        public int altura;
        public int largura;
        public int comprimento;


        public Caixa(int altura, int largura, int comprimento)
        {
            this.altura = altura;
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public int calcVolume()
        {
            int volume;
            int area;

            area = this.largura * this.comprimento;

            volume = this.altura * area;

            return volume;
        }
    }
}
