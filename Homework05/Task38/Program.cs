// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//Метод, заполняющий массив вещественными числами
void FillArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (Math.Round((Random.Shared.NextDouble()), 3) * 90) + 10; //данные сложности обусловлены необходимостью получения вещественных чисел с двумя знаками после запятой
    }
} 

//Метод, выводящий массив на экран
string PrintArray(double[] array)
{
  string result = "[ ";
  for(int i = 0; i < array.Length; i++)
  {
    result += ($"{array[i]} ");
  }
  return result + "]";
}

//Метод определения минимального элемента массива
double FindMinElement (double [] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i+=1)
    {
        if(min > array[i]) min = array[i];
    }
    return min;
}

//Метод определения максимального элемента массива
double FindMaxElement (double [] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i+=1)
    {
        if(max < array[i]) max = array[i];
    }
    return max;
}

//Метод подсчета разницы между минимальным и максимальным элементами массива
double CountOfDifference (double [] array)
{
  return FindMaxElement(array) - FindMinElement(array);
}

//Клиентский код
int count_of_elements = 4;

double[] my_array = new double[count_of_elements];
FillArray(my_array);
Console.WriteLine(PrintArray(my_array));
Console.WriteLine($" max = {FindMaxElement(my_array)}");
Console.WriteLine($" min = {FindMinElement(my_array)}");
Console.WriteLine($" diff = {CountOfDifference(my_array)}");