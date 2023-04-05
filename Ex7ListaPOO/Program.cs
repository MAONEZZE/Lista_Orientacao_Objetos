namespace Ex7ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase = 2000, percentualComissao = 10, totalVendas = 50;

            Vendedor vend = new Vendedor(salarioBase, totalVendas, percentualComissao);

            double salariototal = vend.calcSalarioTotal();

            Console.WriteLine($"Salario Base: {salarioBase}\nPercentual de Comissão: {percentualComissao}\nTotal de Vendas: {totalVendas}\nSalario Total: {salariototal}");
        }
    }
}