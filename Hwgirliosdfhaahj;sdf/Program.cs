Console.Write("Вычисление длины пути торможения автомобиля");
Console.Write("Введите начальную скорость авто (м/c) = ");
int v0 = Convert.ToInt32(Console.ReadLine());
formul = 0;
formul = v0 * v0 / 10;
Console.WriteLine("До полной остановки автомобиль пройдёт = {formul} ");