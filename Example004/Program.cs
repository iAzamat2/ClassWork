/*5. Напишите программу вычисления значения 
функции возведения числа в квадрат.*/

// Функция с возвратом результата
int Sqr(int a)
{
    return a * a;
}

// Процедура без возврата результата
void Sqrl(int a)
{
    Console.WriteLine("Квадрат числа равен(процедура): "+(a * a));
}

Console.WriteLine("Введите число ");
int c = Convert.ToInt32(Console.ReadLine());
// Вызов фунции
Console.WriteLine("Квадрат числа равен(функция): " + Sqr(c));
// Вызов процедуры
Sqrl(c);