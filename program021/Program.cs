// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

using System.Xml.XPath;

string Input(string message)
{
  System.Console.Write(message);
  string result = Console.ReadLine()!; L
  return result;
}


string ToLower(string str)
{
  string result = string.Empty;
  for (int i = 0; i < str.Length; i++)
  {
    if(str[i] >= 'A' && str[i] <= 'Z') result += (char)(str[i] + 32);
    else result +=str[i];
  }
  return result;
}

string str = Input("Введите строку: ");
System.Console.WriteLine(ToLower(str));