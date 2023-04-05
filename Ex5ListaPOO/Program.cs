namespace Ex5ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int raio = 6;
            Esfera esf = new Esfera(raio);

            double volume = esf.calcVolumeEsfera();

            Console.WriteLine($"Volume da esfera com raio {raio}: {volume}");
        }
    }
}