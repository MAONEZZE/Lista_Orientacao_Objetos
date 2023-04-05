namespace Ex8ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 6, raiobase = 2;

            Lata lt = new Lata(altura, raiobase);

            double volume = lt.calcVolume();

            Console.WriteLine($"Altura: {altura}\nRaio da Base: {raiobase}\nBase: {raiobase * 3.14}\nVolume: {volume}");

        }
    }
}