/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/

void Zadacha12()
{
    Console.WriteLine("Введите первое число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int test=B % A;
    Console.WriteLine((test) == 0 ? $"Число {B} кратно {A}" : $"Остаток от деления: {(test)}");
}
Zadacha12();