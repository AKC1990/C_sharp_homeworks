// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int Sum(int min, int max)
{
    if (min > max) return 0;
    int sum = min + Sum(min+1, max);
    min ++;
    return sum;
}

int M = 5;
int N = 10;
int result = Sum(M, N);
Console.WriteLine(result);