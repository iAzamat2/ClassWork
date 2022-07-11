/*
Задача 1. Написать программу, которая определяет, является ли треугольник 
со сторонами a, b, c равнобедренным.

Расширена до определения типа треугольника

*/


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

    else if ((test == true) && (d == e) && (d == f))
    {
        triangletype1 = $" [ Успех:) ] Было введено: {d}, {e} и {f}. Этот треугольник равносторонний (правильный) и ";
    }

    else if ((test == true) && (d == e) || (d == f))
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

    if(test == true)
    {
         Console.WriteLine(triangletype1+triangletype2);
    }

}

void Zadacha01()
{

    Console.WriteLine(" Программа определит тип треугольника по введенным сторонам :) ");
    int a = Defense("a");
    int b = Defense("b");
    int c = Defense("c");
    Th0(a, b, c);

}

Zadacha01();