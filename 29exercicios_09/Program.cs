/*
    ATIVIDADE 09

    Peça um número e retorne a tabuada inteira dele.

*/

Console.WriteLine("Dê um número de 1 a 10.");
int numero = Convert.ToInt16(Console.ReadLine());

int multiplicador = 1;

for (multiplicador = 1; multiplicador < 11; multiplicador++)
{
    Console.WriteLine(numero * multiplicador);
}