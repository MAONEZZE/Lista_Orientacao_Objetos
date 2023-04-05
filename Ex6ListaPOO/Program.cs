using System.Text.RegularExpressions;

namespace Ex6ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grauCelsius = 0;

            Conversor cv = new Conversor(grauCelsius);

            double grauF = cv.calcFahrenheit();
             
            Console.WriteLine($"{grauCelsius} Celsius é: {grauF} em Fahrenheit");
        }
    }
}