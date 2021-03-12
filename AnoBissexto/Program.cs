using System;

namespace AnoBissexto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano e descubra se ele é bissexto ou não.");
            Console.WriteLine("----------------------------------------");
            var userInput = Console.ReadLine();

            bool validNumber = false;
            do
            {
                try
                {
                    int year = int.Parse(userInput);
                    validNumber = true;

                    Console.WriteLine();

                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                        Console.WriteLine($"{year} É um ano bissexto!");
                    else
                        Console.WriteLine($"{year} NÃO É um ano bissexto!");

                    Console.WriteLine("\n----------------------------------------------\n Desenvolvido por Daniel dos Santos Gonçalves");
                }
                catch (Exception e)
                {
                    // Ano inválido.
                    Console.WriteLine("--------- Digite um valor númerico! ---------");
                    userInput = Console.ReadLine();
                }
            } while (validNumber == false);
        }
    }
}
