int Input(string message)
{
System.Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int[,] Getmatrix(int len1, int len2, int a, int b)
{
int[,] matrix = new int[len1, len2];
b++; // Генерировать будем до b включительно
Random rand = new Random();
for (int i = 0; i < len1; i++)
{
for (int j = 0; j < len2; j++)
{
matrix[i, j] = rand.Next(a, b);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write("{0, 3} ", matrix[i, j]);
}
System.Console.WriteLine();
}
}

// возвращает true если num уже присутствует в первых len элементах массива и false если нет
bool InArray(int[] arr, int len, int num)
{
for (int i = 0; i < len; i++)
{
if (num == arr[i]) return true;
}
return false;
}

int GetInd(int[,] arr, int num)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
if (num == arr[i,0]) return i;
}
return -1;
}

int[,] GetDictionary(int[,] matrix)
{
int[] uniq = new int[matrix.Length]; // массив уникальных элементов
int count = 0;
foreach (int el in matrix)
{
if (!InArray(uniq, count, el))
{
uniq[count++] = el;
}
}

int[,] dict = new int[count,2];
for (int i = 0; i < count; i++)
{
dict[i, 0] = uniq[i];
}

foreach (int el in matrix)
{
dict[GetInd(dict, el),1]++;
}

return dict;
}

void BubbleSort(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
for (int j = 0; j < arr.Length-1; j++)
{
if (arr[j] > arr[j+1])
{
// swap
int tmp = arr[j];
arr[j] = arr[j+1];
arr[j+1] = tmp;
}
}
}
}

int CountUniq(int[] arr)
{
int count = 1;
int lastUniq = arr[0];
foreach (int el in arr)
{
if (el != lastUniq){
lastUniq = el;
count++;
}
}
return count;
}

int[,] GetDictionary2(int[,] matrix)
{
int[] arr = new int[matrix.Length];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
arr[i * matrix.GetLength(1) + j] = matrix[i,j];
}
}

BubbleSort(arr);
int uniqCount = CountUniq(arr);

int[,] dict = new int [uniqCount,2];
dict[0,0] = arr[0];
int current = 0;
// int curentElem = arr[0];
foreach (int el in arr)
{
if (el == dict[current,0])
{
dict[current,1]++;
}
else
{
current++;
dict[current,0] = el;
dict[current,1]++;
}
}


return dict;
}

void PrintDictionary(int[,] dict)
{
// 6 встречается 2 раза
for (int i = 0; i < dict.GetLength(0); i++)
{
System.Console.WriteLine($"{dict[i,0]} встречается {dict[i,1]} раз");
}
}

int m = Input("Введите кол-во строк: "),
n = Input("Введите кол-во стобцов: ");

int[,] arr = Getmatrix(m, n, 0, 9);
PrintMatrix(arr);

int[,] dict1 = GetDictionary(arr);
int[,] dict2 = GetDictionary2(arr);
System.Console.WriteLine("Словарик: ");
// PrintMatrix(dict);
PrintDictionary(dict1);
System.Console.WriteLine("-----------------");
PrintDictionary(dict2);