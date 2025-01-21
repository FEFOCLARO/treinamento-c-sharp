/*
    ATIVIDADE 08

    Peça três lados e um triângulo e retorne o seu tipo:

    Equilátero: todos os lados congruentes;
    Isósceles: dois lados congruentes;
    Escalenos: todos os lados com medidas distintas.

*/

Console.WriteLine("Me dê a primeira medida:");

int lado1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Me dê a segunda medida:");

int lado2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Me dê a terceira medida:");

int lado3 = Convert.ToInt16(Console.ReadLine());

if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("Triângulo isósceles");
}
else if (lado1 == lado2 && lado1 == lado3);
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (lado1 != lado2 && lado2 != lado3);
{
    Console.WriteLine("Triângulo Escaleno.");
}