// Solicite o valor do produto
Console.WriteLine("Insira o valor do produto:");
int valor_do_produto = Convert.ToInt32(Console.ReadLine());

// Informe sobre o desconto
Console.WriteLine("Agora, nas compras de valor superior a 500 reais e pagas à vista, você recebe 10% de desconto.");

// Pergunte ao cliente como ele deseja pagar
Console.WriteLine("Você deseja parcelar ou pagar à vista? Digite 1 para Parcelado e 2 para À vista:");
int forma_de_pagamento = Convert.ToInt32(Console.ReadLine());

if (forma_de_pagamento == 2 && valor_do_produto > 500)
{
    // Calcula o valor com desconto
    double valor_com_desconto = valor_do_produto * 0.9;
    Console.WriteLine($"Parabéns! Você recebeu um desconto de 10%. O valor total a pagar é: R${valor_com_desconto}");
}
else
{
    // Caso não encontre abrigo nas condições:
    Console.WriteLine($"O valor total a pagar é: R${valor_do_produto}");
}