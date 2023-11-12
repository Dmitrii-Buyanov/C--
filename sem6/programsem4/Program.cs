// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int[] GetDiag(int[,] matrix)
{
int min = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
int[] diag = new int[min];
for (int i = 0; i < min; i++)
{
diag[i] = matrix[i,i];
}
return diag;
}

int getSum(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
sum += array[i];
}
return sum;
}

int m = Input("Введите кол-во строк: "),
n = Input("Введите кол-во стобцов: ");

int[,] arr = Getmatrix(m, n, 0, 9);
PrintMatrix(arr);
int[] diag = GetDiag(arr);
int sum = getSum(diag);

// Вывод
System.Console.Write("Сумма элементов главной диагонали: ");
for (int i = 0; i < diag.Length; i++)
{
System.Console.Write(diag[i] + (i < diag.Length - 1 ? "+": " = "));
}
System.Console.Write(sum);