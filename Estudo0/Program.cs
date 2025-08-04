int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Primeiro exemplo");
foreach (int numero in numeros)
{
    Console.WriteLine("O numero é: {0}", numero);
}

Console.WriteLine("Segundo exemplo");
foreach(var i in numeros)
{
       Console.WriteLine($"O numero é: {i}");
}

List<string> nomes = new List<string> { "Alice", "Pedro", "Robson" };

Console.WriteLine("Exemplo da primeira string");
foreach (var nome in nomes)
{
    Console.WriteLine($"O nome é : {nome}");
}

Console.WriteLine("Exemplo da segunda string");
foreach (var nome in nomes)
{
    Console.WriteLine("O nome é : {0}", nome);
}

string segundo = nomes[1];

Console.WriteLine(segundo);

string ultimo = nomes[^1];

Console.WriteLine(ultimo);

int[] pequenosNumeros = numeros[0..5];

Console.WriteLine(pequenosNumeros);