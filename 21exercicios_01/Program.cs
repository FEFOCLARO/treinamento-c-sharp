/*

    Atividade 01

    Peça dois números inteiros, se forem iguais realize a soma, se forem diferentes, realize a multiplicação.

*/
Console.WriteLine("Por favor, escreva um número:");

int numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Por favor, escreva outro número:");

int numero2 = Convert.ToInt16(Console.ReadLine());

if (numero1 == numero2)
{
    Console.WriteLine(numero1 + numero2);
}

else
{
    Console.WriteLine(numero1 * numero2);
}