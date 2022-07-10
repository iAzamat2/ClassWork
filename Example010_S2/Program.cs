/*
16. Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/

void Zadacha16()
{
    Console.WriteLine("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int sqra = a * a;
    int sqrb = b * b;
    if (a == sqrb)
    {
        Console.WriteLine($"{a} = {b}^2 => первое число является квадратом второго числа");
    }
    else if (b == sqra)
    {
        Console.WriteLine($"{a}^2 = {b} => второе число является квадратом первого числа");
    }
    else
    {
        Console.Write($"{a}^2 = {sqra}, {b}^2 = {sqrb}\n{sqra} != {sqrb} => число {a} не является квадратом числа {b}, а также число {b} не является квадратом числа {a}");
    }

}
Zadacha16();