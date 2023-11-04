// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int len, int a, int b)
{
int[] array = new int[len];
b++; // Генерировать будем до b включительно
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(a, b);
}
return array;
}

void PrintArray(int[] array)
{
foreach (int num in array)
{
System.Console.Write($"{num} ");
}
System.Console.WriteLine();
}

int CountElementsInRange(int[] array, int l, int r)
{
int count = 0;
foreach (int el in array)
{
if (l <= el && el <= r) ++count;
}
return count;
}

Console.Clear();
int[] arr = GetArray(123, -99, 99);
PrintArray(arr);
System.Console.WriteLine($"Кол-во элементов в диапазоне [10,99] = {CountElementsInRange(arr, 10, 99)}");