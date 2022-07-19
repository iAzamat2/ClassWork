/*Знакомство с языками программирования. Семинар 1.

Задача 1. Пользователь вводит число N (N > 0). Программа должна
вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1

*/

void Task1()
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt16(Console.ReadLine());
    int number = 1;
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{number}, ");
        }
        Console.Write("\b\b \n");
    }
    else
    {
        Console.WriteLine("Ошибка! (N>0)");
    }
}





/*
Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран
сколько раз число a поместиться в числе b.

*/

void Task2()
{
    Console.Write("Введите число a: ");
    int a = Convert.ToInt16(Console.ReadLine());

    Console.Write("Введите число b: ");
    int b = Convert.ToInt16(Console.ReadLine());

    int result = -1;

    if (a < b)
    {
        result = b / a;
    }
    else
    {
        Console.WriteLine($"Ошибка! a >= b");
    }

    if (result != -1)
    {
        Console.WriteLine($"Число a = {a} поместиться в числе b = {b}: => {result} раз(а)");
    }

}





/*
Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их
от большего к меньшему.

*
* *
* * *

*/

void Task3()
{

    Console.Write($"Введите количество спортсменов: ");
    int size = Convert.ToInt16(Console.ReadLine());
    int[] heightList = new int[size];


    FillArray(heightList);

    Console.WriteLine($"Введенные данные:");
    PrintArray(heightList);

    SortArrayMaxToMin(heightList);

    Console.WriteLine($"Отсортированные данные:");
    PrintArray(heightList);



    int[] SortArrayMaxToMin(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }



    int[] FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите рост {i + 1} спортсмена: ");
            array[i] = Convert.ToInt16(Console.ReadLine());
        }
        return array;
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



}





/*
Задача 4. Дано N секунд. 
Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34

*/

void Task4()
{
    Console.Write($"Введите количество секунд (N): ");
    int sec = Convert.ToInt32(Console.ReadLine());

    int h = (sec % (24 * 60 * 60)) / 3600;
    int m = (sec % (60 * 60)) / 60;
    int s = (sec % (60 * 60)) % 60;


    Console.WriteLine(DateFormat(h, m, s));



    string DateFormat(int hh, int mm, int ss)
    {
        string formatDate = String.Empty;
        string formathh = String.Empty;
        string formatmm = String.Empty;
        string formatss = String.Empty;

        formathh = (hh < 10) ? ("0" + hh) : (hh.ToString());
        formatmm = (mm < 10) ? ("0" + mm) : (mm.ToString());
        formatss = (ss < 10) ? ("0" + ss) : (ss.ToString());

        formatDate = $"{formathh}:{formatmm}:{formatss}";

        return formatDate;

    }



}



//Task1();
//Task2();
//Task3();
//Task4();