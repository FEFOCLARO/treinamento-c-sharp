/*
    ATIVIDADE 06

    Peça um número inteiro, retorne se é um número positivo, neutro ou negativo.

    Exemplos:
    -5: Negativo
    34: Positivo
    -3: Negativo
    0: Neutro

    
*/

Console.WriteLine("Digite um número de -100 à 100:");

int numero = Convert.ToInt16(Console.ReadLine());



if (numero < -100 || numero > 100)
{
    Console.WriteLine("Número que foge ao range.");
}
else if (numero >= 1 )
{
    Console.WriteLine("Positivo.");
}
else if (numero == 0)
{
    Console.WriteLine("Neutro.");
}
else if (numero <= -1 )
{
    Console.WriteLine("Negativo.");
}
else 
{
    Console.WriteLine("Desconhecido.");
}
