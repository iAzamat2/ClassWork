// Определить какой день недели, по введеному числу и первый день месяца это понедельник
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if ((a >= 1) & (a <= 31))
{
    b = a % 7;
}

switch (b)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 0:
        Console.WriteLine("Воскресенье");
        break;

    default:
        Console.WriteLine("Ошибка");
        break;
}

