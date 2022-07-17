/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/

void Task24()
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма равна: {sum}");
}



/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
*/

void Task26()
{
    Random random = new Random();
    int number = 12345678;
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count += 1;
    }
    Console.WriteLine($"Количество цифр: {count}");

}



/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/

void Task28()
{
    int factorial = 1;
    Console.Write("Введите число N: ");
    int n = Convert.ToInt16(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"{n}! = {factorial}");
}



/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/

void Task30()
{
    Random random = new Random();
    int size = 8;
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}



/*
Даны два массива. В первом массиве записано количество мячей, забитых футбольной командой в той или иной игре,
во втором — количество пропущенных мячей в этой же игре. 
а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
б) Определить количество выигрышей данной команды. 
в) Определить  количество  выигрышей  и  количество  проигрышей  данной   команды. 
г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды. 
д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей  была большей или равной трем. 
е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0).
*/

void Football()
{
    Random random = new Random();
    int size = random.Next(6, 10);
    int[] scored = new int[size];
    int[] conceded = new int[size];

    FillArray(scored);
    FillArray(conceded);

    Console.WriteLine("Забитые мячи");
    PrintArray(scored);
    Console.WriteLine();
    Console.WriteLine("Пропущенные мячи");
    PrintArray(conceded);

    //а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
    //д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей  была большей или равной трем. 

    int wins = 0;
    int loses = 0;
    int draw = 0;
    int scores = 0;
    int goalMissRateCount=0;
    Console.WriteLine();
    for (int i = 0; i < scored.Length; i++)
    {
        int goal = scored[i];
        int miss = conceded[i];
        if(goal-miss>=3)
        {
            goalMissRateCount++;
        }
        Console.Write($"{goal} : {miss}");
        if (goal > miss)
        {
            Console.WriteLine(" - победа");
            wins++;
            scores += 3;
        }
        else if (goal < miss)
        {
            Console.WriteLine(" - поражение");
            loses++;
        }
        else
        {
            Console.WriteLine(" - ничья");
            draw++;
            scores += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Побед - {wins}, поражений - {loses}, ничьих - {draw}");
    Console.WriteLine($"Набрано очков: {scores}");
    Console.WriteLine($"В {goalMissRateCount} играх разность забитых и пропущенных мячей была большей или равной трем");







    void FillArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 10);
        }
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}



//Task24();
//Task26();
//Task28();
//Task30();
Football();


