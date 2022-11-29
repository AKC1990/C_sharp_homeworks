// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя

void SquareNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b ; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{a} ^ {b} = {result}");
}

SquareNumber(5, 3);