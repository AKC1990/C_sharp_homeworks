// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 2;
int b = 3;
int c = 7;

if (a > b)
{
    if (a > c)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(c);
    }
}
else
{
    if (b > c)
    {
        Console.Write(b);
    }
    else
    {
        Console.Write(c);
    }
}