namespace Ex10ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaP1 = 8, notaP2 = 5, peso1 = 2, peso2 = 3;

            Professor pf = new Professor(notaP1, notaP2, peso1, peso2);

            double media = pf.calcMedia();

            Console.WriteLine($"Nota Prova 1: {notaP1}\nNota Prova 2: {notaP2}\nMedia Ponderada: {media}");
        }
    }
}