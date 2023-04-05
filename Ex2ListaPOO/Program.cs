namespace Ex2ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grauF;

            grauF = 32;

            Conversor cv = new Conversor(grauF);

            double grauCelsius = cv.calcGrauCelsius();

            Console.WriteLine($"{grauF} Fahrenheit é: {grauCelsius} em Celsius");
        }
    }
}