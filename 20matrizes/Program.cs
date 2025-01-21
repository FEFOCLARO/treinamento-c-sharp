// Matriz
string [,] dados = {
    {"Fernando", "Porto Alegre"},
    {"Kaíque", "Itumbiára"},
    {"Neis", "Mato Leitão"},
    {"Nabucodonosor", "Babilônia"}
};

// Exibição dos Dados
// Console.WriteLine(dados[0,1]);

//Exibição em Loop dos dados

foreach(string dado in dados)
{
    Console.WriteLine(dado);
}

// O que difere o Array de uma MATRIZ são suas colunas. A matriz possui duas colunas por linha.