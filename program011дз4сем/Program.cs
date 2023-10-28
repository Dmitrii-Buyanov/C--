/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.Write("Введите Введите число которое будет возводиться в степень: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите число на которое будет возводится в степень: ");
int num2 = int.Parse(Console.ReadLine());

double squ (int A , int B)
{
    double sum = Math.Pow(A , B);
    return sum ;
}

double result = squ(num1, num2);
System.Console.Write("Квадрат числа равен: ");
System.Console.Write(result);


