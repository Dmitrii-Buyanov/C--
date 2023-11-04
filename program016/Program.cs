// Задача 31: Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int length, int min, int max)
{
int[] array = new int[length];
Random rand = new Random();
for (int i = 0; i < length; i++)
{
array[i] = rand.Next(min, max + 1);
}
return array;
}

void PrintArray(int[] inArray)
{
for (int i = 0; i < inArray.Length; i++)
{
Console.Write(inArray[i] + " ");
}
Console.WriteLine();
}
int[] GetSumms(int[] inArray)
{
int[] result = new int[2];
foreach (int el in inArray)
{
if (el > 0) result[0] += el;
if (el < 0) result[1] += el;
}
return result;
}
void GetSumms2(int[] inArray)
{
int positiveSum = 0;
int negativeSum = 0;
foreach (int el in inArray)
{
if (el > 0) positiveSum += el;
if (el < 0) negativeSum += el;
}
Console.Write(positiveSum + " сумма положительных " + negativeSum + " сумма отрицательных");
}

int[] arr = GetArray(12, -9, 9);
PrintArray(arr);
int[] res = GetSumms(arr);
//Console.Write($"{res[0]} сумма положительных чисел {res[1]} сумма отрицательных чисел");
GetSumms2(arr);