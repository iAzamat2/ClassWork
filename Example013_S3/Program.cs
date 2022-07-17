/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

void Task17()
{
    /* Console.WriteLine("Введите x: ");
     int x = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите y: ");
     int y = Convert.ToInt32(Console.ReadLine());*/
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"Точка с координатами ({x}, {y})");

    if (x > 0 && y > 0) { Console.WriteLine("Точка лежит в 1-ой четверти"); }
    else if (x < 0 && y > 0) { Console.WriteLine("Точка лежит в 2-ой четверти"); }
    else if (x < 0 && y < 0) { Console.WriteLine("Точка лежит в 3-ой четверти"); }
    else if (x > 0 && y < 0) { Console.WriteLine("Точка лежит в 4-ой четверти"); }
    else Console.WriteLine("Точка лежит на координатной прямой");
}



/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек в этой четверти (x и y).
*/

void Task18()
{
    Random random = new Random();
    int n = random.Next(0, 5);
    Console.WriteLine($"Четверть {n}");
    {
        switch (n)
        {
            case 1:
                Console.WriteLine("x > 0, y > 0");
                break;
            case 2:
                Console.WriteLine("x < 0, y > 0");
                break;
            case 3:
                Console.WriteLine("x < 0, y < 0");
                break;
            case 4:
                Console.WriteLine("x > 0, y < 0");
                break;
            default:
                Console.WriteLine("Ошибка! ");
                break;
        }


    }
}



/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
*/

void Task21()
{
    Random random = new Random();
    int x1 = random.Next(-10, 11);
    int y1 = random.Next(-10, 11);
    int x2 = random.Next(-10, 11);
    int y2 = random.Next(-10, 11);
    Console.WriteLine($"Первая точка с координатами ({x1}, {y1})\nВторая точка с координатами ({x2}, {y2})");
    double res = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
    double result = Math.Truncate(1000 * res) / 1000; // округление до 3 символов
    Console.WriteLine($"Расстояние между точками {result}");

}



/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void Task22()
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt16(Console.ReadLine());
    int i = 1;
    int sqr = 1;
    while (i <= N)
    {
        Console.Write(sqr + " ");
        i += 1;
        sqr = (int)Math.Pow(i, 2);
    }
    Console.WriteLine();
}



//Task17();
//Task18();
//Task21();
Task22();