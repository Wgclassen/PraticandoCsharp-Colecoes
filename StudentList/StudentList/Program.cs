Dictionary<string, decimal> notas = new Dictionary<string, decimal>
{
    { "Ana", 8.75m },
    { "Bruno", 6.90m },
    { "Clara", 9.25m }
};

foreach (var item in notas)
{
    Console.WriteLine($"Aluno: {item.Key} - Nota: {item.Value}");
}