/*
    ATIVIDADE 4

    Peça um dia de um determinado mês/ano, retorne o dia da semana.
    Observação: Neste exercício será utilizado como base o calendário de novembro de 2024, mas fique à vontade para escolher outro mês/ano.

*/

//Obter o dia
Console.WriteLine("Informe o dia do mês de novembro de 2024:");
int dia = Convert.ToInt16(Console.ReadLine());

//Verificação

//Segunda-feira
if (dia == 4 || dia == 11 || dia == 18 || dia == 25)
{
    Console.WriteLine("Este dia é segunda-feira.");
}
//Terça-feira
if (dia == 5 || dia == 12 || dia == 19 || dia == 26)
{
    Console.WriteLine("Este dia é terça-feira.");
}
//Quarta-feira
if (dia == 6 || dia == 13 || dia == 20 || dia == 27)
{
    Console.WriteLine("Este dia é quarta-feira.");
}
//Quinta-feira
if (dia == 7 || dia == 14 || dia == 21 || dia == 28)
{
    Console.WriteLine("Este dia é quinta-feira.");
}
//Sexta-feira
if (dia == 8 || dia == 15 || dia == 22 || dia == 29)
{
    Console.WriteLine("Este dia é sexta-feira.");
}
//Sábado
if (dia == 9 || dia == 16 || dia == 23 || dia == 30)
{
    Console.WriteLine("Este dia é sábado.");
}
//Domingo
if (dia == 3 || dia == 10 || dia == 17 || dia == 24)
{
    Console.WriteLine("Este dia é domingo.");
}