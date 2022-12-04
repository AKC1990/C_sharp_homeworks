// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
return AckermannFunction(M, N);
}

//Клиентский код
Console.WriteLine("Enter number M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({M},{N}) = {AckermannFunction(M, N)}");