double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
double total = 0;

foreach (var valor in doacoes)
{
    total += valor;
}
Console.WriteLine($"Total de doações: {total}");