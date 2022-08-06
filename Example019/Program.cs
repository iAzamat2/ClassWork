using FunctionsOfArray;
using Tasks;


FunctionsOfArrayClass ar = new FunctionsOfArrayClass();
tasks ts = new tasks();



/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

*/

void Task31()
{

    int size = 12;
    int[] array = new int[size];

    ar.AutoFillArray(array, -9, 9);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    Console.WriteLine($"Сумма положительных чисел равна: {ts.SumArray(array, true)}");
    Console.WriteLine($"Сумма отрицательных чисел равна: {ts.SumArray(array, false)}");



}





/*
Задача 32: Напишите программу замены элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

*/

void Task32()
{

    int size = 12;
    int[] array = new int[size];

    ar.AutoFillArray(array);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    Console.WriteLine("Отсортированный массив: ");
    ts.ReplaceArray(array);
    ar.PrintArray(array);

}





/*
Задача 33: Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да

*/

void Task33()
{

    int size = 12;
    int[] array = new int[size];

    ar.AutoFillArray(array);

    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(ts.InArray(array, n));



}





/*
Задача 35: Задайте одномерный массив из 10 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

void Task35()
{

    int size = 123;
    int[] array = new int[size];
    int startRange = 10;
    int endRange = 99;


    ar.AutoFillArray(array, -99, 99);

    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);

    Console.WriteLine($"Количество элементов массива, значения которых лежат на отрезке [{startRange}, {endRange}]: {ts.CountInRange(array, startRange, endRange)}");


}





/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

*/

void Task37()
{

    int size = 7;
    int[] array = new int[size];

    ar.AutoFillArray(array, 0, 9);

    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);

    ts.MultNumArray(array, size);


}





//Task31();
//Task32();
//Task33();
//Task35();
//Task37();
