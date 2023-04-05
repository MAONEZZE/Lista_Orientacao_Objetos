namespace Ex1ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, altura, comprimento;

            largura = 10;
            altura = 5;
            comprimento = 20;

            Caixa cx = new Caixa(altura, largura, comprimento);

            int volume = cx.calcVolume();

            Console.WriteLine("O Volume da caixa é: " + volume);
        }
    }
}