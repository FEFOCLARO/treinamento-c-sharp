
using System;

namespace Exercicio
{
public class NomeGenerator
{
    private static Random random = new Random ();

    public static string GerarNomeAleatorio()
    {
        const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        char[] nome = new char[4];
        for (int i = 0; i < nome.Length; i++)
    {
        nome[i] = alfabeto[random.Next(alfabeto.Length)];
    }
    return new string (nome);
    
  }
 }

}