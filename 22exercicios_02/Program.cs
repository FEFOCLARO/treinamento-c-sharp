/*

    ATIVIDADE 02

    Peça um número e retorne se é par ou ímpar;

    DICA: Para sabermos se um número é par ou ímpar, será necessário utilizarmos o módulo > %

*/

int numero = Convert.ToInt16(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("É par.");
}

else
{
    Console.WriteLine("Não é par.");
}