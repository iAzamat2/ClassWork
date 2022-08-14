using FunctionsOfArray;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/

void Task53()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    ar.cls();
    ar.FillArray(array);
    Console.WriteLine("Исходная матрица:");
    ar.PrintArray(array);
    ar.ChangeArray(array);
    Console.WriteLine();
    Console.WriteLine("Измененная матрица:");
    ar.PrintArray(array);
}





/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя.

*/

void Task55()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.cls();
    ar.FillArray(array);
    Console.WriteLine("Исходная матрица:");
    ar.PrintArray(array);

    if (rows == columns)
    {
        ar.ChangeRowsColumnsArray(array);
        Console.WriteLine();
        Console.WriteLine("Измененная матрица:");
        ar.PrintArray(array);
    }
    else
    {
        Console.WriteLine("Это невозможно. Число строк не совпадает с числом столбцов.");
    }
}





/*
Задача 57: Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент 
входных данных.

Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }  0 встречается 2 раза 
                            1 встречается 1 раз 
                            2 встречается 1 раз 
                            8 встречается 1 раз 
                            9 встречается 3 раза
1, 2, 3 
4, 6, 1 
2, 1, 6
                            1 встречается 3 раза 
                            2 встречается 2 раз 
                            3 встречается 1 раз 
                            4 встречается 1 раз 
                            6 встречается 2 раза

*/

void Task57()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.FillArray(array, 0, 9);
    ar.PrintArray(array);

    int[] counters = new int[10];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            counters[array[i, j]]++;
        }
    }

    for (int k = 0; k < counters.Length; k++)
    {
        if (counters[k] != 0)
        {
            Console.WriteLine($"{k} встречается {counters[k]} раз(а)");
        }
    }
}





/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Наименьший элемент 1, на выходе получим 
следующий массив:
9 2 3
4 2 4
2 6 7

*/

void Task59()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    ar.cls();
    ar.FillArray(array, 1, 9);
    Console.WriteLine("Исходная матрица:");
    ar.PrintArray(array);

    int min = array[0, 0];
    int min_i = 0;
    int min_j = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Значение минимального элемента равно: {min} на позиции: ({min_i}, {min_j})");

    int[,] arraySecond = new int[rows - 1, columns - 1];
    int rowsSecond = arraySecond.GetLength(0);
    int columnsSecond = arraySecond.GetLength(1);
    int bias_i = 0;
    int bias_j = 0;

    for (int i = 0; i < rowsSecond; i++)
    {
        if (i == min_i) bias_i++;
        bias_j = 0;
        for (int j = 0; j < columnsSecond; j++)
        {
            if (j == min_j) bias_j++;
            arraySecond[i, j] = array[i + bias_i, j + bias_j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Измененная матрица:");
    ar.PrintArray(arraySecond);
}





//Task53();
//Task55();
//Task57();
//Task59();
