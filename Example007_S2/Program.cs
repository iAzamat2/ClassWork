/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

void Zadacha11()
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine(number);
    int digit1 = number % 10;
    //int digit2 = number / 10 % 10;
    int digit3 = number / 100;
    int a = (digit3 * 10) + digit1;
    Console.WriteLine(a);
}

Zadacha11();