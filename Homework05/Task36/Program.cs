//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//Метод, заполняющий массив
void FillArray (int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
} 

//Метод, выводящий массив на экран
string PrintArray(int[] array)
{
  string result = "[ ";
  for(int i = 0; i < array.Length; i++)
  {
    result += ($"{array[i]} ");
  }
  return result + "]";
}

//Метод суммирования значений элементов массива с нечетными индексами
int SumOddIndexElements (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
    return sum;
}

//Клиентский код
int count_of_elements = 8;
int min_value_of_array = -99;
int max_value_of_array = 100;

int[] my_array = new int[count_of_elements];
FillArray(my_array, min_value_of_array, max_value_of_array);
Console.WriteLine(PrintArray(my_array));
Console.WriteLine(SumOddIndexElements(my_array));