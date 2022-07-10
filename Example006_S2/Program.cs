void Zadacha9()
{
    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    int digitOnes = number/10;
    int digitTens = number%10;
    Console.WriteLine((digitOnes>digitTens? $"Наибольшая цифра числа: {digitOnes}":$"Наибольшая цифра числа: {digitTens}"));
}

Zadacha9();