/*

    ATIVIDADE 05

    Peça um ano e retorne se é bissexto ou não.

    Dica: Um ano bissexto ocorre a cada 4 anos.

*/

Console.WriteLine("Digite um ano:");

int ano = Convert.ToInt16(Console.ReadLine());

if ((ano % 4) == 0)
{
    Console.WriteLine("Este ano é bissexto.");
}
else
{
    Console.WriteLine("Não é um ano bissexto.");
}