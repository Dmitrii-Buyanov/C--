// Задайте произвольный массив.
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int Krico()
{
    int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    PrintArrayInReverse(arr , arr.Length - 1);
    return 0;
}
void PrintArrayInReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.WriteLine(array[index]);
        PrintArrayInReverse(array, index - 1);
    }
}
int A = Krico();