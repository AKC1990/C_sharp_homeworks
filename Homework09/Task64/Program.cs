// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void DescentNums(int N)
{
    if(N < 1) return;
    Console.Write($"{N} ");
    N--;
    DescentNums(N);
}

int N = 15;
DescentNums(N);
