/*Знакомство с языками программирования. Семинар 3.

Задача 1. Рассчитать значение y при заданном x по формуле
y= sin^2(x) при x>0,
y= 1-2*sin(x^2) в противном случае

*/

void Task01()
{

    Console.Write("Введите значение x в градусах: ");
    double x = Convert.ToInt32(Console.ReadLine());

    double y = 0;
    double result = 0;



    double ConvertToRadians(double angle)
    {
        return (Math.PI / 180) * angle;
    }



    if (x > 0)
    {
        y = Math.Pow(Math.Sin(ConvertToRadians(x)), 2);
    }
    else
    {
        y = 1 - (2 * Math.Sin(ConvertToRadians(Math.Pow(x, 2))));
    }



    result = Math.Round(y, 3); // округление до 3 символов
    Console.WriteLine($"y = {result}");

}





/*
Задача 2. Дано трёхзначное число N. Определить кратна ли трём
сумма всех его цифр.

*/

void Task02()
{

    Console.Write("Введите трёхзначное число N: ");
    int n = Convert.ToInt16(Console.ReadLine());



    SumOfNumbers(n);



    void SumOfNumbers(int number2)
    {
        int summa = 0;
        string text = number2.ToString();

        while (number2 > 0)
        {
            summa += (number2 % 10);
            number2 /= 10;
        }

        if (summa % 3 == 0)
        {
            Console.WriteLine($"Сумма цифр числа {text} равна {summa} и кратна 3");
        }
        else
        {
            Console.WriteLine($"Сумма цифр числа {text} равна {summa} и не кратна 3");
        }

    }



}




/*
Задача 3. Дано трёхзначное число N. Определить, есть ли среди его
цифр 4 или 7.

*/

void Task03()
{

    Console.Write("Введите трёхзначное число N: ");
    int n = Convert.ToInt16(Console.ReadLine());

    bool test1 = false; //4
    bool test2 = false; //7



    TestNumber(n);



    void TestNumber(int number2)
    {

        string text = number2.ToString();

        while (number2 > 0)
        {
            int a = (number2 % 10);
            number2 /= 10;
            if (a == 4)
            {
                test1 = true;
            }
            else if (a == 7)
            {
                test2 = true;
            }

        }



        if ((test1 == true) && (test2 == true))
        {
            Console.WriteLine($"Число: {text} содержит 4 и 7");
        }

        else if (test1 == true)
        {
            Console.WriteLine($"Число: {text} содержит 4");
        }

        else if (test2 == true)
        {
            Console.WriteLine($"Число: {text} содержит 7");
        }

        else
        {
            Console.WriteLine($"Число: {text} не содержит 4 или 7");
        }

    }



}





/*
Задача 4. Дан массив длиной 10 элементов. Заполнить его
последовательно числами от 1 до 10.

*/

void Task04()
{

    int size = 10;
    int[] numbers = new int[size];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i + 1;
    }



    PrintArray(numbers);



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
Задачи повышенной сложности:
Задача 1. На ввод подаётся номер четверти. Создаются 3
случайные точки в этой четверти. Определите самый оптимальный
маршрут для торгового менеджера, который выезжает из центра
координат.

*/

void Task11()
{

    Console.Write("Введите номер четверти: ");
    int n = Convert.ToInt16(Console.ReadLine());

    int prost2D = 2;
    int pointcount = 4;
    int[,] points = new int[prost2D, pointcount];
    double[,] matrix = new double[pointcount, pointcount];
    double[] minimum = new double[4];
    int[] traektor = new int[4];

    switch (n)
    {
        case 1: PointGenerator(points, 1, pointcount); break;
        case 2: PointGenerator(points, 2, pointcount); break;
        case 3: PointGenerator(points, 3, pointcount); break;
        case 4: PointGenerator(points, 4, pointcount); break;
        default: Console.WriteLine("Ошибка ввода!"); break;
    }



    PrintArray(points, prost2D, pointcount);



    for (int i = 0; i < pointcount; i++)
    {
        for (int j = 0; j < pointcount; j++)
        {
            matrix[i, j] = Distance(points, i, j);
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }



    double min = 100001;
    for (int i = 1; i < 4; i++)
    {

        double minMatrix = 0;
        minMatrix = matrix[0, i];
        if (minMatrix < min)
        {
            min = minMatrix;
            minimum[0] = minMatrix;
            traektor[1] = i;
        }

    }



    double min2 = 100001;
    for (int i = 1; i < 4; i++)
    {

        if ((matrix[traektor[1], i] < min2) && (traektor[1] != i))
        {
            min2 = matrix[traektor[1], i];
            minimum[1] = matrix[traektor[1], i];
            traektor[2] = i;
        }
    }



    {
        for (int i = 0; i <= 3; i++)
        {
            if (i != traektor[0] && i != traektor[1] && i != traektor[2])
            {
                traektor[3] = i;
            }
        }
        minimum[2] = matrix[traektor[2], traektor[3]];
    }



    string[] traektorName = new string[4];

    for (int i = 0; i < 4; i++)
    {
        int mins = traektor[i];
        switch (mins)
        {
            case 0:
                traektorName[i] = "O"; break;
            case 1:
                traektorName[i] = "A"; break;
            case 2:
                traektorName[i] = "B"; break;
            case 3:
                traektorName[i] = "C"; break;
        }

    }



    double sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += minimum[i];
    }



    Console.WriteLine();
    Console.WriteLine($"Самый оптимальный маршрут проходит через точки: {traektorName[0]} => {traektorName[1]} => {traektorName[2]} => {traektorName[3]}");
    Console.WriteLine($"Длина пути составит: {sum}");

    //Console.WriteLine(minimum[0] + " " + minimum[1] + " " + minimum[2]);
    //Console.WriteLine(traektor[0] + " " + traektor[1] + " " + traektor[2] + " " + traektor[3]);



    int[,] PointGenerator(int[,] array, int number, int pointcounts)
    {

        for (int j = 1; j < pointcounts; j++)
        {
            Random random = new Random();
            switch (number)
            {
                case 1: array[0, j] = random.Next(1, 10001); array[1, j] = random.Next(1, 10001); break;
                case 2: array[0, j] = random.Next(-10000, 0); array[1, j] = random.Next(1, 10001); break;
                case 3: array[0, j] = random.Next(-10000, 0); array[1, j] = random.Next(-10000, 0); break;
                case 4: array[0, j] = random.Next(1, 10001); array[1, j] = random.Next(-10000, 0); break;
                default: array[0, j] = random.Next(1, 10001); array[1, j] = random.Next(1, 10001); break;
            }
        }

        return array;
    }



    void PrintArray(int[,] array0, int prost, int pointcounts)
    {
        string[] listname = { "O", "A", "B", "C" };

        for (int j = 0; j < pointcounts; j++)
        {
            Console.Write($"{listname[j]} ({array0[0, j]}, {array0[1, j]}); ");
        }

        Console.Write("\b\b ");
        Console.WriteLine();

    }



    double Distance(int[,] array, int pointBegin, int pointEnd)
    {
        double res = Math.Sqrt(Math.Pow((array[0, pointEnd] - array[0, pointBegin]), 2) + Math.Pow((array[1, pointEnd] - array[1, pointBegin]), 2));
        double result = Math.Round(res, 0);
        return result;
    }



}





/*
Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и
CD?

*/

void Task12()
{

}





/*
Задача 3. Найти в какой четверти лежит точка пересечения из
задачи 2 (если вектора пересекаются).

*/

void Task13()
{

}





/*
Задача 4. Дан массив средних температур (массив заполняется
случайно) за последние 10 лет. На ввод подают номер месяца и год
начала и конца.
Определить самые высокие и низкие температуры для лета, осени,
зимы и весны в заданном промежутке. Если таких температур нет,
сообщить, что определить не удалось.

*/

void Task14()
{

}





/*
Задача 5. На вход подаётся число n > 4, указывающее длину
пароля. Создайте метод, генерирующий пароль заданной длины. В
пароле обязательно использовать цифру, букву и специальный знак.

*/

void Task15()
{

}





/*
Задача 6. Из центра координат к точке А(x, y) проведён отрезок АО.
Напишите программу, определяющую наименьший угол наклона
отрезка AO к оси X.

*/

void Task16()
{

}





/*
Задача 7. Массив из ста элементов заполняется случайными
числами от 1 до 100. Удалить из массива все элементы,
содержащие цифру 3. Вывести в консоль новый массив и
количество удалённых элементов.

*/

void Task17()
{

}





/*
Задача 8. Напишите программу, который выводит на консоль
таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.

*/

void Task18()
{

}





/*
Задача 9. Дана игра со следующими правилами. Первый игрок
называет любое натуральное число от 2 до 9, второй умножает его
на любое натуральное число от 2 до 9, первый умножает результат
на любое натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого
впервые получится число больше 1000. Запрограммировать
консольный вариант игры

*/

void Task19()
{

}





//Task01();
//Task02();
//Task03();
//Task04();
Task11();