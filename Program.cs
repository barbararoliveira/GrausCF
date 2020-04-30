using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, vou ajudá-lo a coverter °C para °F. Digite enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Digite o valor em celcius:");
            double celcius = double.Parse (Console.ReadLine ());

            double vl = 1.8; // vl = valor 
            double farenheit  = 32;

            Console.Write(celcius + " graus celcius equivalem a: ");
            Console.Write(celcius * vl + farenheit );
            Console.WriteLine(" graus farenheit.");

            Console.ReadKey();
        }
    }
}
