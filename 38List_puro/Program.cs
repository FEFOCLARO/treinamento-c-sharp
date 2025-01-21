// List é tipado, diferente do arraylist. Assim, é muito mais performático, pois o C# não precisa descobrir o tipo do dado.
List<string> nomes = new List<string>();

// Adicionar à lista

nomes.Add("Fernandinho");
nomes.Add("Luis");
nomes.Add("Maiara");

// Laço de repetição
for (int indice=0; indice<nomes.Count; indice++)
{
    Console.WriteLine(nomes[indice]);
}