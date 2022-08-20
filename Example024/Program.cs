using FunctionsOfArray;

FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



/*
Задача 58. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

void Task58()
{
    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    int[,] array = new int[m, n];

    ar.SpiralFillArray(array);
    ar.PrintArray(array);
}





/*
Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/

void Task63()
{
    void Recursion(int number, int counter = 1)
    {
        if (counter > number) return;
        Console.WriteLine(counter);
        counter++;
        Recursion(number, counter);
    }
    Recursion(5);
}





/*
Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

*/

void Task65()
{
    Random random = new Random();
    int m = random.Next(1, 100);
    int n = random.Next(m, 100);

    Console.WriteLine($"M = {m}, N = {n}");
    Recursion(m, n);

    void Recursion(int m1, int n1)
    {
        if (m1 > n1) return;
        Console.WriteLine(m1);
        m1++;
        Recursion(m1, n1);
    }
}





/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

*/

void Task67()
{
    Random random = new Random();
    int number = random.Next(1, 10000);
    int sum = 0;

    Console.WriteLine($"Сгенерированное число: {number}");
    Console.WriteLine($"Сумма цифр числа {number} равна {ar.SumNumber(number, sum)}");

}





/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

*/

void Task69()
{
    int a = 3;
    int b = 3;
    int result = ar.PowRec(a, b);
    Console.WriteLine($"{a}^{b} = {result}");
}





//Task58();
//Task63();
//Task65();
//Task67();
//Task69();