namespace Ex9ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 2, nota2 = 3, nota3 = 5, nota4 = 6, nota5 = 9;

            Professor pf = new Professor(nota1, nota2, nota3, nota4, nota5);

            double media = pf.calcMediaHarmonica();

            Console.WriteLine($"A media harmônica do aluno com as notas {nota1}, {nota2}, {nota3}, {nota4} e {nota5} é {media}");
        }
    }
}