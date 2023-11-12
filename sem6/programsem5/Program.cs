// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int Input(string message)
{
System.Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int[,] Getmatrix(int len1, int len2, int a, int b)
{
int[,] matrix = new int[len1, len2];
b++; // Генерировать будем до b включительно
Random rand = new Random();
for (int i = 0; i < len1; i++)
{
for (int j = 0; j < len2; j++)
{
matrix[i, j] = rand.Next(a, b);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write("{0, 3} ", matrix[i, j]);
}
System.Console.WriteLine();
}
}

void ReplaceRows(int[,] matrix, int row1, int row2)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[row1, j] += matrix[row2, j];
matrix[row2, j] = matrix[row1, j] - matrix[row2, j];
matrix[row1, j] = matrix[row1, j] - matrix[row2, j];
// a,b
// a = a + b
// b = a - b; (a + b) - b = a
// a = a - b; (a + b) - a = b
//
}
}

int m = Input("Введите кол-во строк: "),
n = Input("Введите кол-во стобцов: ");
int[,] arr = Getmatrix(m, n, 0, 9);

System.Console.WriteLine("Изначальная матрица");
PrintMatrix(arr);

ReplaceRows(arr, 0, arr.GetLength(0) - 1);

System.Console.WriteLine("Измененная матрица");
PrintMatrix(arr);