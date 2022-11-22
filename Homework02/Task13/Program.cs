// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = 164580;

if (number >= 100)

{
    while (number >= 1000)
    {
        number = number / 10;
    }

    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("There is no the third number");
}

