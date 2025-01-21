// Vetor de nomes
string[] nomes = {"Fernando", "Cleber", "Téo", "Marrocos"};

// Exibir os nomes
// Console.WriteLine(nomes);

// A posição do vetor sempre inicia no 0 e precisa ser apontada para ser retornada, 0 aponta fernando, 3 aponta marrocos, 2 téo, 1 cleber...
// Console.WriteLine(nomes[0]);
// Console.WriteLine(nomes[1]);
// Console.WriteLine(nomes[2]);
// Console.WriteLine(nomes[3]);

// Laço para
for(int indice = 0; indice < 4; indice++)
{
    Console.WriteLine(nomes[indice]);
}
