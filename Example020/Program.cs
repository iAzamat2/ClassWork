using FunctionsOfArray;
using Tasks;


FunctionsOfArrayClass ar = new FunctionsOfArrayClass();
tasks ts = new tasks();



/*
Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом 
месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

void Task39()
{
    int size = new Random().Next(5, 11);
    int[] array = new int[size];

    ar.AutoFillArray(array, 0, 9);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    ts.Reverse(array);
    ar.PrintArray(array);
}





/*
Задача 40: Напишите программу, которая принимает на вход три 
числа и проверяет, может ли существовать треугольник со 
сторонами такой длины.

*/

void Task40()
{
    int[] array = new int[3];
    ar.AutoFillArray(array, 1, 100);
    ar.PrintArray(array);
    ts.Th0(array[0], array[1], array[2]);
}





/*
Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

void Task42()
{
    Console.Write("Введите число, которое нужно перевести в двоичную систему счисления: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ts.DecToBin(number));
}





/*
Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/

void Task44()
{
    // f(1) = 1
    // f(2) = 1
    // f(n) = f(n-1) + f(n-2)

    Console.Write("Введите число N: ");
    int n = Convert.ToInt16(Console.ReadLine());

    double[] array = new double[n];
    array[0] = 0;
    array[1] = 1;

    ts.Fibonacci(array);
    ar.PrintArrayReal(array);
}





/*
Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного 
копирования.

*/

void Task45()
{
    int size = 12;
    int[] array = new int[size];
    int[] arraycopy = new int[size];

    ar.AutoFillArray(array);
    Console.WriteLine("Сгенерированный массив: ");
    ar.PrintArray(array);
    ts.CopyArray(array, arraycopy);
    Console.WriteLine("Скопированный массив: ");
    ar.PrintArray(arraycopy);
}





//Task39();
//Task40();
//Task42();
//Task44();
//Task45();
