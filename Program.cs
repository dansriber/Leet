using System;

namespace Pasta_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
           string tradutor;

            //<---Inicio(Digite)--->//
            Console.Write("Digite Qualquer Coisa: ");
            tradutor = Console.ReadLine();
            //<---Fim(Digite)--->//

            //<---Inicio(Tradutor)--->//
            Console.WriteLine(tradutor
                .Replace("A", "4")
                .Replace("a", "4")

                .Replace("E", "3")
                .Replace("e", "3")

                .Replace("I", "1")
                .Replace("i", "1")
                .Replace("L", "1")
                .Replace("l", "1")

                .Replace("O", "0")
                .Replace("o", "0")

                .Replace("T", "7")
                .Replace("t", "7")

                .Replace("S", "5")
                .Replace("s", "5"));
            //<---Fim(Tradutor)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->// 
        }
    }
}
