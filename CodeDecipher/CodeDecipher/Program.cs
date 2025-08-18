int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
int[] combinação = new int[3];


combinação[0] = Array.IndexOf(numeros, 19);
combinação[1] = Array.IndexOf(numeros, 42);
combinação[2] = Array.IndexOf(numeros, 7);

Console.WriteLine($"Combinação do cadeado: {combinação[0]}-{combinação[1]}-{combinação[2]}");