namespace Ex3ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cl = new Cilindro(6, 4);

            double volume = cl.calcVolumeCilindro();

            Console.WriteLine("O volume do cilindro: " + volume);
        }
    }
}