// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

// Метод, считывающий число от пользователя из консоли
int GetNumber(string text)
{
  Console.Write(text);
  int value = int.Parse(Console.ReadLine());
  return value;
}

// Метод, создающий новый массив из n элементов
int[] CreateArray(int n)
{
    return new int[n];
}

// Метод, заполняющий массив числами от пользователя
void Fill(int[] Array, int min, int max)
  {
    int size = Array.Length;
    for (int i = 0; i < size; i++)
    {
      Array[i] = GetNumber($"Array[{i}]: ");
    }
  }

// Метод, печатающий массив
string PrintArray(int[] numbers)
{
    string result = "[ ";
    int size = numbers.Length;
    for(int i = 0; i < size; i++)
    {
        result += ($"{numbers[i]} ");
    }
    return result + "]";
}

//Клиентский код
int[] array = CreateArray(8);
Fill(array, 1, 10);
Console.WriteLine(PrintArray(array));
