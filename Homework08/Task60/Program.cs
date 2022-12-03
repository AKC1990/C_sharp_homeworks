// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Метод, проверяющий вхождение генерируемого числа в массив уникальных чисел
bool isExists (int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) return true;
    }
    return false;
}

//

int countOfRows = 2;                                                             //
int countOfColumns = 2;                                                          // Задаем размеры трехмерного массива
int countOfSides = 2;                                                            //

int[,,] matrix = new int[countOfRows, countOfColumns, countOfSides];
int [] totalArray = new int[countOfRows * countOfColumns * countOfSides];        //Создаем одномерный массив уникальных значений для дальнейшей проверки на уникальность значений

int minValue = 1;                                                                // Задаем минимальное значение генерируемого числа
int maxValue = 20;                                                               // Задаем максимальное значение генерируемого числа

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2);)
        {
            int num = new Random().Next(minValue, maxValue);                    //  Вводим переменную num для получения сгенерированного числа и дальнейшей проверки его уникальности 
            if (isExists(num, totalArray) == false)                             //  Запускаем проверку, если num отсутствует в массиве totalArray,  
                {                                                               //
                    matrix[i,j,k] = num;                                        //  то присваиваем соответствующему индексу в матрице значение num
                    Console.WriteLine($"{matrix[i,j,k]}({i},{j},{k})");         //  и выводим на экран число и его позицию в матрице
                    totalArray[(matrix.GetLength(1) * matrix.GetLength(2) * i ) + ( matrix.GetLength(2) * j ) + k] = num;        //  Присваиваем соответствующему индексу массива уникальных значений значение num. 
                    k++;                                                                                                         //  На 38 в квадратных скобках получилась сложная формула подсчета индекса массива 
                }                                                                                                                // уникальных значений, но зато рабочая))
        }
    }
} 


