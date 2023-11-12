//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int Input(string message)
{
System.Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
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

void FillMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = i + j;
}
}
}

int m = Input("Введите кол-во строк: "),
n = Input("Введите кол-во стобцов: ");

int[,] arr = new int[m,n];
FillMatrix(arr);
PrintMatrix(arr);