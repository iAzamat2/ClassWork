/*
Знакомство с языками программирования. Семинар 4.

Задача 1. На вход подаётся натуральное десятичное число.
Проверьте, является ли оно палиндромом в двоичной записи.

27 ==> 11011
21 ==> 10101

*/

void Task01()
{

    Console.Write("Введите число: ");
    string ntext = String.Empty;
    ntext = Console.ReadLine();
    long nDec = Convert.ToInt64(ntext);
    long n = Int64.Parse(DectoBin(nDec));

    int size = NumberCount(n);
    int[] numbers = NumToArray(n, size);
    Console.WriteLine($"{nDec} ==> {n}");
    Palindrome(numbers, DectoBin(nDec));



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



    void Palindrome(int[] array, string text)
    {
        bool test = true;
        int sizeArray = array.Length;

        for (int i = 0; i < sizeArray / 2; i++)
        {
            if (array[i] != array[sizeArray - i - 1])
            {
                test = false;
                break;
            }
        }

        if (test == true)
        {
            Console.WriteLine($"{text} - палиндром");
        }
        else
        {
            Console.WriteLine($"{text} - не палиндром");
        }

    }



    string DectoBin(long a)
    {
        long b;
        long c = a;
        String temp = "";
        while (a != 0)
        {
            b = a % 2;
            temp = b + temp;
            a = a / 2;
        }
        return temp;
    }



}





/*
Задача 2. Напишите метод, который заполняет массив случайным
количеством (от 1 до 100) нулей и единиц. Размер массива должен
совпадать с квадратом количества единиц в нём.

*/

void Task02()
{

    Random random = new Random();

    int oneCount = random.Next(1, 11);

    int size = (int)Math.Pow(oneCount, 2);

    int[] array = new int[size];



    for (int i = 1; i <= oneCount; i++)
    {
        int pos = random.Next(0, size);
        if (array[pos] == 0)
        {
            array[pos] = 1;
        }
        else
        {
            i--;
        }
    }



    Console.WriteLine($"Количество единиц в массиве: {oneCount}");
    PrintArray(array);



    void PrintArray(int[] array0)
    {
        Console.Write("[");
        for (int i = 0; i < array0.Length; i++)
        {
            Console.Write(array0[i] + ", ");
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }



}





/*
Задача 3. Массив на 100 элементов задаётся случайными числами
от 1 до 99. Определите самый часто встречающийся элемент в
массиве. Если таких элементов несколько, вывести их все.

*/

void Task03()
{

    int size = 100;
    int[] array = new int[size];

    AutoFillArray(array);
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: ");
    PrintArray(array);
    //Console.WriteLine();
    //Console.WriteLine("Отсортированный массив: ");
    //SortArray(array);
    //PrintArray(array);



    // =============== //



    int[] list = new int[size];

    int count;
    int len = 0;
    int maxcount = 1;

    for (int i = 0; i < size; i++)
    {
        count = 0;
        for (int j = i; j < size; j++)
            if (array[i] == array[j])
            {
                count++;
            }
        if (count == maxcount)
        {
            list[len] = i;
            len++;
        }
        if (count > maxcount)
        {
            maxcount = count;
            len = 1;
            list[0] = i;
        }

    }



    Console.WriteLine();
    Console.WriteLine($"Cамые часто встречающееся элементы в массиве: ( {maxcount} раз(а) )");

    for (int i = 0; i < len; i++)
    {
        Console.Write((array[list[i]]) + " ");
    }
    Console.WriteLine();



    // ============================= //



    int[] AutoFillArray(int[] array0)
    {
        for (int i = 0; i < array0.Length; i++)
        {
            Random random = new Random();
            array0[i] = random.Next(1, 100);
        }
        return array0;
    }



    void PrintArray(int[] array0)
    {
        Console.Write("[");
        for (int i = 0; i < array0.Length; i++)
        {
            Console.Write(array0[i] + ", ");
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }



    int[] SortArray(int[] array0)
    {
        int temp;
        for (int i = 0; i < array0.Length - 1; i++)
        {
            for (int j = i + 1; j < array0.Length; j++)
            {
                if (array0[i] > array0[j])
                {
                    temp = array0[i];
                    array0[i] = array0[j];
                    array0[j] = temp;
                }
            }
        }
        return array0;
    }



}



            

/*
Создание игры:
Задача 1*. С помощью команд очистки консоли и печати
реализовать игру-бродилку в консоли.
https://docs.microsoft.com/ru-ru/dotnet/api/system.console.clear?view=n
et-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposi
tion?view=net-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.console.readkey?view
=net-6.0
https://docs.microsoft.com/ru-ru/dotnet/api/system.consolekey?view=net
-6.0

*/

void Task11()
{

}





/*
Задача 2*. Создать игру лабиринт

*/

void Task12()
{

}





//Task01();
//Task02();
Task03();