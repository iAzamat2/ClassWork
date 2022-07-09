// Вывести квадрат числа
int result;
Console.WriteLine("Введите число, квадрат которого нужно вычислить");
int number = Convert.ToInt32(Console.ReadLine());
result = number * number;
Console.WriteLine($"{number}^2 = {result}");
//Console.WriteLine("Квадрат числа равен "+result);