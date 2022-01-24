using System;
using Base64;

namespace Base64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dado = "";
            try
            {
                Console.Write("Escreva um dado(string): ");
                 dado = Console.ReadLine();
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            dado = Conversor.EncodeToBase64(dado);
            Console.WriteLine("Dado convertido: " + dado);

            dado = Conversor.DecodeFrom64(dado);
            Console.WriteLine("Dado desconvertido: " +dado);

            Console.ReadLine();
        }
    }
}