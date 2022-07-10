/*
Задача 1. Написать программу, которая определяет, является ли треугольник 
со сторонами a, b, c равнобедренным.
*/

// Неравенство треугольника
bool Th1(int d, int e, int f)
{
    if ((d > e + f) || (e > d + f) || (f > d + e))
    {
        return false;
    }
    else
    {
        return true;
    }
}
// Определение равнобедренного треугольника
bool Th2(int d, int e, int f)
{
    if ((d == e) || (d == f))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void Zadacha01()
{
    Console.WriteLine("Введите длину стороны a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину стороны b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длину стороны c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    bool test1 = Th1(a, b, c);
    bool test2 = Th2(a, b, c);
    if ((test1 == true) && (test2 == true))
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} является равнобедренным");
    }
    else
    {
        if (test1 == false)
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} не является равнобедренным.\nНевыполняется неравенство треугольника");
        }
        else if (test2 == false)
        {
            Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} не является равнобедренным.\nТреугольник не равнобедренный по определению");
        }
    }

}


Zadacha01();