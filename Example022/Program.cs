using FunctionsOfArray;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();

/*
Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

*/

void Task46()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    ar.FillArray(array);
    ar.PrintArray(array);
}





/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: A = i+j. 
Выведите полученный массив на экран.

*/

void Task48()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    ar.PrintArray(array);
}





/*
Задача 49: Задайте двумерный массив. Найдите элементы, у 
которых оба индекса чётные, и замените эти элементы на их 
квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

*/

void Task49()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    ar.FillArray(array, 1, 9);
    ar.PrintArray(array);
    Console.WriteLine();
    SqrEven(array);
    ar.PrintArray(array);

    void SqrEven(int[,] array)
    {
        for (int i = 0; i < rows; i += 2)
        {
            for (int j = 0; j < columns; j += 2)
            {
                if (i % 2 == 0 && j % 2 == 0)
                {
                    array[i, j] = (int)Math.Pow(array[i, j], 2);
                }
            }
        }
    }
}





/*
Задача 51: Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/


void Task51()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    ar.FillArray(array);
    ar.PrintArray(array);
    SumDiag(array);

    void SumDiag(int[,] array)
    {
        int sum = 0;
        int minindex = (rows < columns) ? rows : columns;
        Console.Write($"Сумма элементов главной диагонали: ");
        for (int i = 0; i < minindex; i++)
        {
            Console.Write(array[i, i]+"+");
            sum += array[i, i];
        }
        Console.Write($"\b = {sum}\n");
    }
}


//Task46();
//Task48();
//Task49();
//Task51();
