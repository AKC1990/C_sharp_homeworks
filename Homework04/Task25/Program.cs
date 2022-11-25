// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 5);
int result = 1;
for (int i = 1; i < b + 1; i++)
{
    result *= a;
}
Console.WriteLine($"{a} ^ {b} = {result}");