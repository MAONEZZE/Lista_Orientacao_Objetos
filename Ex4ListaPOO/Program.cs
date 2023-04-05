namespace Ex4ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veic = new Veiculo(200, 450, 100);

            double combKm = veic.calcCombustivelPorKm();

            Console.WriteLine("Consumo de Combustível por Km: " + combKm);
        }
    }
}