//Secret hashmap

using System.Collections;
using System.Linq.Expressions;

Hashtable secret = new()
{
	{ "Vinicius", "Urso pardo" },
	{ "Gabriel", "Veado" },
	{ "Mauricio", "Gorila" },
	{ "Thiago", "Jacaré" },
	{ "Guilherme", "Cabra" },
	{ "Gustavo", "Canguru" }
};

secret.Add("Daniel", "Coelho");
secret["Igor"] = "Rato";

try
{
	secret.Add("Vinicius", "Ursão");
} 
catch (Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
	Console.WriteLine(ex.Message);
}

//Percorrendo itens do hashmap
Console.WriteLine("Membros do secreto e seu animal");
if (secret.Count == 0)
    Console.WriteLine("Não existem membros");
else
    foreach (DictionaryEntry entry in secret)
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    