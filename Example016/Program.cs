/*Знакомство с языками программирования. Семинар 2.

Задача 1. Написать программу, которая определяет, является ли треугольник 
со сторонами a, b, c равнобедренным.

Расширена до определения типа треугольника

*/

void Task1()
{

    // Защита от ввода неверных данных
    int Defense(string txt)
    {
        int i;
        do
        {
            do
            {
                Console.Write($"Введите длину стороны {txt} > 0: ");
            } while (!int.TryParse(Console.ReadLine(), out i));


        } while (i <= 0);
        return i;
    }

    int MaxOfArray(int[] mas)
    {
        int maxPos = 0;
        int index = 1;
        int max = mas[0];

        while (index < mas.Length)
        {
            if (mas[index] > max)
            {
                max = mas[index];
                maxPos = index;
            }
            index++;
        }
        return maxPos;
    }

    void Th0(int d, int e, int f)
    {
        bool test = true;
        // Неравенство треугольника
        if ((d > e + f) || (e > d + f) || (f > d + e))
        {
            Console.WriteLine($" [ Ошибка! ] Было введено: {d}, {e} и {f}. Эти стороны не определяют треугольник.\n Не выполняется неравенство треугольника");
            test = false;
        }

        string triangletype1 = "";
        // по стороне
        if ((d != e) && (d != f))
        {
            triangletype1 = $" [ Успех:) ] Было введено: {d}, {e} и {f}. Этот треугольник разносторонний и ";
        }

        else if ((d == e) && (d == f))
        {
            triangletype1 = $" [ Успех:) ] Было введено: {d}, {e} и {f}. Этот треугольник равносторонний (правильный) и ";
        }

        else if ((d == e) || (d == f))
        {
            triangletype1 = $" [ Успех:) ] Было введено: {d}, {e} и {f}. Этот треугольник равнобедренный и ";
        }


        int[] array = { d, e, f };
        int indMax = MaxOfArray(array);
        int sqrM = -1;
        int sqrN = -1;
        int sqrK = -1;
        switch (indMax)
        {
            case 0:
                sqrM = d * d; sqrN = e * e; sqrK = f * f;
                break;
            case 1:
                sqrM = e * e; sqrN = d * d; sqrK = f * f;
                break;
            case 2:
                sqrM = f * f; sqrN = d * d; sqrK = e * e;
                break;

        }

        string triangletype2 = "";
        if ((sqrM == sqrN + sqrK))
        {
            triangletype2 = $"прямоугольный";
        }

        else if ((sqrM < sqrN + sqrK))
        {
            triangletype2 = $"остроугольный";
        }

        else if ((sqrM > sqrN + sqrK))
        {
            triangletype2 = $"тупоугольный";
        }

        if (test == true)
        {
            Console.WriteLine(triangletype1 + triangletype2);
        }

    }



    Console.WriteLine(" Программа определит тип треугольника по введенным сторонам :) ");
    int a = Defense("a");
    int b = Defense("b");
    int c = Defense("c");
    Th0(a, b, c);



}





/*
Задача 2. 
На вход подаются год, номер месяца и день рождения человека. 
Определить возраст человека на момент 1 июля 2022 года.

*/

void Task2()
{

    int size = 3;
    int[] Date = new int[size];
    int[] DateCheck = { 2022, 7, 1 };


    FillArray(Date);
    Console.WriteLine("Введенные данные:");
    PrintArray(Date);
    Console.WriteLine($"Ваш возраст: {CheckAge(Date, DateCheck)}");





    int CheckAge(int[] Date0, int[] DateCheck0)
    {
        int age = 0;
        bool agetest = false;

        if (Date0[1] < DateCheck0[1])
        {
            agetest = true;
        }
        else if ((Date0[1] == DateCheck0[1]) && (Date0[2] <= DateCheck0[2]))
        {
            agetest = true;
        }

        if (agetest == true)
        {
            age = DateCheck0[0] - Date0[0];
        }
        else
        {
            age = (DateCheck0[0] - 1) - Date0[0];
        }

        return age;
    }



    void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }



    int[] FillArray(int[] array)
    {
        string[] DateName = { "год", "номер месяца", "день" };
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите {DateName[i]} рождения");
            array[i] = Convert.ToInt16(Console.ReadLine());
        }
        return array;
    }



}





/*
Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб.
Через каждый месяц размер вклада увеличивается на 1.5% от
имеющейся суммы. Определить размер депозита через n месяцев.

*/

void Task3()
{

    Console.WriteLine($"Введите число месяцев с момента открытия счета (n)");
    int n = Convert.ToInt16(Console.ReadLine());

    double initialDeposit = 1000;
    double result = Math.Truncate(100 * procent(n, initialDeposit)) / 100; // округление до 2 символов
    Console.WriteLine($"Размер депозита через {n} месяцев равен: {result}");





    double procent(int n0, double deposit0)
    {
        double proc = 0;
        for (int i = 1; i <= n0; i++)
        {
            proc = deposit0 * 0.015;
            deposit0 += proc;
        }

        return deposit0;

    }



}





/*
Задача 4. Дано натуральное число, в котором все цифры различны.
Определить, какая цифра расположена в нем левее: максимальная
или минимальная.

*/

void Task4()
{

    Console.WriteLine("Введите число:");
    string ntext = String.Empty;
    ntext = Console.ReadLine();
    long n = Convert.ToInt64(ntext);



    int size = NumberCount(n);
    int[] numbers = NumToArray(n, size);
    MaxMinPos(numbers, ntext);





    void MaxMinPos(int[] array, string text)
    {

        int maxPos = 0;
        int minPos = 0;
        int max = array[0];
        int min = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxPos = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minPos = i;
            }
        }

        Console.WriteLine(maxPos > minPos ? $"Минимум: {min} левее максимума: {max}" : $"Максимум: {max} левее минимума: {min}");

    }



    // Доп. методы:
    int NumberCount(long number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count += 1;
        }
        return count;
    }



    int[] NumToArray(long number2, int size2)
    {
        int[] numbersArray = new int[size2];
        for (int i = size2 - 1; i >= 0; i--)
        {
            numbersArray[i] = (int)(number2 % 10);
            number2 /= 10;
        }

        return numbersArray;

    }



}





//Task1();
//Task2();
//Task3();
//Task4();