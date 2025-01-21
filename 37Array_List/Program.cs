using System.Collections;

// ArrayList
ArrayList lista = new ArrayList();


// Cadastrar dados na ArrayList
lista.Add("Fernandinho");
lista.Add(true);
lista.Add(30);

// Listar dados (var aqui é VARIÁVEL genérica não-tipada, pois no array list não há tipagem prévia)

foreach (var l in lista)
{
    Console.WriteLine(l);
}

