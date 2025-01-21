// Realizar pergunta ao usuário
Console.WriteLine("Qual é o seu nome?");

//Obter o nomezinho
string ?nome = Console.ReadLine();

/*
Por padrão, o C# obriga que as variáveis tenham algum valor atribuído. 
Porém se quiseres criar uma variável e não utilizá-la, utilize '?' antes do nome da variável.
Bastante útil para casos de Readline ou input, como no caso em tela.
*/ 

//Concatenação
Console.WriteLine($"Olá, {nome}");