// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!; 
  return result;
}

bool IsPallindrome(string str)
{
  str = str.ToLower(); 
  for (int i = 0; i < str.Length; i++)
  {
    if (str[i] != str[str.Length - 1 - i]) return false;
  }
  return true;
}

string str = Input("Введите строку: ");
System.Console.WriteLine(IsPallindrome(str) ? "Да, является" : "Нет, не является");