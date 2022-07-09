// Проверка равно ли первое число квадрату второго числа
Console.WriteLine("Введите первое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int a = Convert.ToInt32(Console.ReadLine());
int res = b * b;
Console.WriteLine((a == res) ? "Да" : "Нет");