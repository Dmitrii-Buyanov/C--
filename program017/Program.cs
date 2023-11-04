// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
System.Console.Write("{0, 3}", num);
}
System.Console.WriteLine();

}

void ReplaceElements(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = -array[i];
}
}

int[] arr = GetArray(20, -9, 9);
PrintArray(arr);
ReplaceElements(arr);
PrintArray(arr);
