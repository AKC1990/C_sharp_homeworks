// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
int SumOfNumbers(int number)
{
    int a = number;
    int result = 0;
    while(a > 0)
    {
        result += a % 10;
        a /= 10;        
    }
    return result;
}

Console.WriteLine(SumOfNumbers(2022));

