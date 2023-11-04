// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int Input(string message)
{
System.Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}


int[] InputArray()
{
int len = Input("Введите длину массива: ");
int[] array = new int[len];
for (int i = 0; i < len; i++)
array[i] = Input($"Введите элемент массива №{i}: ");
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

bool NumInArray(int[] array, int num)
{
foreach (int el in array)
{
if (el == num) return true;
}
return false;
}

int[] arr = InputArray();
PrintArray(arr);
int num = Input("Введите искомое число: ");
string YesStr = "Ваше число принадлежит массиву",
NoStr = "Вашего числа нет в массиве";
System.Console.WriteLine(NumInArray(arr, num) ? YesStr: NoStr);