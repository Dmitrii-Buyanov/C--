Console.Write("Введите первое число = ");
int num1 = int.Parse(Console.ReadLine()); //Конвертация строчной переменой в целое число
int num2 = num1 % 7; //Записываем омтаток деления на 7
int num3 = num1 % 23; //Записываем омтаток деления на 23
if (num2 == 0 && num3 == 0) //Выполнение жесткого условия "и"
{
Console.WriteLine("Кратно");
}
else Console.WriteLine("Не кратно");


// || - или                    // &&   ...  и ....