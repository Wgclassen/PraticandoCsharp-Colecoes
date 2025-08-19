HashSet<int> setScores = new HashSet<int>
{
    150,
    90,
    200,
    120,
    150,
    80,
    180,
    200
};

List<int> orderedScores = setScores.OrderBy(score => score).ToList();
Console.WriteLine("Scores únicos em ordem crescente:");
foreach (int score in orderedScores)
{
    Console.WriteLine(score);
}