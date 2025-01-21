
using System;

namespace Exercicio
{

    {
        static void Main()
        {
            string ?nome;
        
            do
            {
                nome = NomeGenerator.GerarNomeAleatorio();
                Console.WriteLine($"Nome gerado: {nome}");
            }
        while (nome.ToLower() != "sair");
    }
}
}
