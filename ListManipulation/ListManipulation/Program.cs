List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };



printTitle("LISTA ORIGINAL");
Console.WriteLine(string.Join(", ", nomes));
Console.WriteLine();

nomes.Order();
printTitle("LISTA ORDENADA");
Console.WriteLine(string.Join(", ", nomes));
Console.WriteLine();

nomes.Reverse();
printTitle("LISTA REVERSA");
Console.WriteLine(string.Join(", ", nomes));
Console.WriteLine();

nomes.RemoveAt(0);
printTitle("LISTA REMOVIDA");
Console.WriteLine(string.Join(", ", nomes));
Console.WriteLine();

nomes.Add("Lúcia");
printTitle("LISTA ADICIONADA");
Console.WriteLine(string.Join(", ", nomes));
Console.WriteLine();

Console.WriteLine($"A pessoa sorteada foi: {nomes[3]}");

void printTitle(string titulo)
{
    int largura = titulo.Length + 4;
    string borda = new string('*', largura);
    string meio = $"* {titulo} *";

    Console.WriteLine(borda);
    Console.WriteLine(meio);
    Console.WriteLine(borda);
}
