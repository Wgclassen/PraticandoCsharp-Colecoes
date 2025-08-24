Dictionary<string, string> tarefas = new Dictionary<string, string>()
{
{ "Refatorar módulo de login", "Ana" },
{ "Testar API de pagamentos", "Pedro" }
};

tarefas.Clear();
tarefas.Add("Implementar autenticação OAuth", "João");
tarefas.Add("Otimizar consultas SQL", "Maria");
tarefas.Add("Atualizar documentação", "Carlos");

Console.WriteLine("Tarefas do próximo sprint:");
foreach (var tarefa in tarefas)
{
    Console.WriteLine($" - {tarefa.Key}: {tarefa.Value}");
}