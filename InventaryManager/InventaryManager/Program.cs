Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };

Console.WriteLine("Itens no inventário inicial:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}

Console.WriteLine("---------------------");
inventario.Remove(1);
inventario.Add(4, "Poção de Vida");

Console.WriteLine("Itens no inventário atualizado:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}