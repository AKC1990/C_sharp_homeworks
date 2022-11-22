// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 3;
int b = 5;

if (a == b)
{
    Console.Write("Equal numbers. Please, enter the same numbers");
}
else
    if (a > b)
    {
        Console.Write("max = ");
        Console.Write(a);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(b);
    }