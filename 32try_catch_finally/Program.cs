try
{
    Console.WriteLine("Informe um valor inteiro:");
    int numero = Convert.ToInt16(Console.ReadLine());
}
catch(Exception errinhoDoFefo)
{
    Console.WriteLine("Houve uma falha: " + errinhoDoFefo.Message);
}
finally
{
    Console.WriteLine("Sistema finalizado.");
}
