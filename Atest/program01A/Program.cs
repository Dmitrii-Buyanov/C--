// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int Normik()
{
    Console.Write("Введите число n = ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число m = ");
    int M = Convert.ToInt32(Console.ReadLine());
    PrintNumbersInRange(M, N);
    return 0;
}
    void PrintNumbersInRange(int start, int end)
{
    if (start <= end)
    {
        Console.WriteLine(start);
        PrintNumbersInRange(start + 1, end);
    }
}
int A = Normik();