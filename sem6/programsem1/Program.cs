// programsem1
int[,] GetArray(int m, int n, int min, int max)
{
int[,] array = new int[m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = rand.Next(min, max);
}
}
return array;
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
}

int[,] arr = GetArray(3, 4, 0, 10);
PrintArray(arr);