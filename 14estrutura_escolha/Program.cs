// Variável
using System.Runtime.InteropServices;

string linguagem = "HTML";

// Estrutura de escolha (ctrl+; para comentar toda estrutura)
// switch(linguagem)
// {
//     case "HTML":
//     Console.WriteLine("Linguagem de Marcação.");
//     break;
     
//     case "CSS":
//     Console.WriteLine("Linguagem de Estilos.");
//     break;

//     case "C#":
//     Console.WriteLine("Linguagem de Programação.");
//     break;

//     default:
//     Console.WriteLine("Linguagem desconhecida.");
//     break;
// }

// Expressão switch
string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação",
    "CSS"  => "Linguagem de estilos",
    "C#"   => "Linguagem de programação",
    _      => "Linguagem desconhcida"
};

Console.WriteLine(retorno);