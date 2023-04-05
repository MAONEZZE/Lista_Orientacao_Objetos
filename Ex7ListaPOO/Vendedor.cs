using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7ListaPOO
{
    internal class Vendedor
    {
        public double percentualComissao;
        public double salarioBase;
        public double totalVendas;

        public Vendedor(double salarioBase, double totalVendas, double percentualComissao) 
        {
            this.salarioBase = salarioBase;
            this.percentualComissao = percentualComissao;
            this.totalVendas = totalVendas;
        }

        public double calcSalarioTotal()
        {
            double salariototal;

            salariototal = salarioBase + ((totalVendas * percentualComissao)/100);

            return salariototal;
        }
    }
}
