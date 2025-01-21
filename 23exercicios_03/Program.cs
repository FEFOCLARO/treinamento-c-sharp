/*
    ATIVIDADE 03

    Peça duas notas, em seguida realize a média e retorne a situação.

    Considere:
    7 - 10: Aprovado(a)
    5 - 6.9: Em Recuperação
    0 - 4.9: Reprovado(a)
*/


Console.WriteLine("Digite sua primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

double nota_mediana = (nota1 + nota2) / 2;

if (nota_mediana >= 7)
{
    Console.WriteLine("Aprovado(a)");
}

else if (nota_mediana >= 5)
{
    Console.WriteLine("Em Recuperação");
}

else
{
    Console.WriteLine("Reprové");
}