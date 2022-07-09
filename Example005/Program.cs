// Вывести все числа из отрезка [-N, N]
void Zadacha7()
{
    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    N = Math.Abs(N);
    //int a = -N; int b = N;
    for (int i = -N; i <= N; i++)
    {
        Console.Write(i + " ");

    }
    Console.WriteLine();
}

Zadacha7();
