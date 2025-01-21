/*
    ATIVIDADE 07

    Peça três números inteiros e retorne qual deles é o menor.
*/

//Obter os números
Console.WriteLine("Digite o primeiro número");
int numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int numero2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");
int numero3 = Convert.ToInt16(Console.ReadLine());

int menor = numero1;

if (numero2 < menor)
{
    menor = numero2;
}
if (numero3 < menor)
{
    menor = numero3;
}

//Retorno 
Console.WriteLine($"O menor número informado é o {menor}");