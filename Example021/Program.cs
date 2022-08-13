using FunctionsOfArray;


FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



/*
Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.

*/

void Task1()
{
    String IntToBin(int init)
    {
        return (init == 0) ? String.Empty : IntToBin(init / 2) + ((init % 2 == 0) ? "0" : "1");
    }

    Console.WriteLine(IntToBin(5));
}





/*
Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

*/

void Task2()
{
    void CountVowels(string text)
    {
        text = text.ToLower().Replace(" ", "");
        char[] symbols = text.ToCharArray(0, text.Length);

        int count = 0;
        int IsvowelCount2(char[] symbols, int index = 0)
        {
            if (index < symbols.Length)
            {
                count += IsvowelCount(symbols, index);
                IsvowelCount2(symbols, index + 1);
            }
            return count;
        }

        IsvowelCount2(symbols);
        Console.WriteLine($"В поговорке {count} гласных букв");

        int IsvowelCount(char[] one, int index)
        {
            char[] vowels = { 'а', 'у', 'о', 'ы', 'э', 'я', 'ю', 'ё', 'и', 'е' };
            int k = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (one[index] == vowels[i])
                {
                    k = 1;
                }
            }
            return k;
        }
    }
    CountVowels("без труда не выловишь и рыбку из пруда");
}





/*
Задача 3. Дано число N. 
Используя только операцию деления и рекурсию, 
определите, что оно является степенью числа 3.

*/

void Task3()
{
    void PrintMessage(int number)
    {
        int count = 0;
        bool PowerOfThree(int init)
        {
            bool result = false;
            int ost = init % 3;
            if (ost == 0 && init >= 3)
            {
                init = init / 3;
                PowerOfThree(init);
                count++;
                result = true;
            }
            return result;
        }

        if (PowerOfThree(number) == true)
        {
            Console.WriteLine($"Число {number} является степенью числа 3:\n3^{count} = {number}");
        }
        else
        {
            Console.WriteLine($"Число {number} не является степенью числа 3");
        }
    }



    PrintMessage(59048);
    PrintMessage(59049);
    PrintMessage(27);
}





/*
Задача 1*. Создайте программу, показывающую текущее время. Для вывода чисел используйте двумерные массивы.
        15:12
https://docs.microsoft.com/ru-ru/dotnet/api/system.datetime?view=net-6.0

*/

void Task4()
{
    ar.FillTimeArray();
}





//Task1();
//Task2();
//Task3();
Task4();