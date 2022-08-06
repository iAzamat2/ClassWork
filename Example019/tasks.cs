using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {


        FunctionsOfArrayClass ar = new FunctionsOfArrayClass();


        // Task 31
        public int SumArray(int[] array0, bool isPositiv = true)
        {

            int sum = 0;
            if (isPositiv == true)
            {

                for (int i = 0; i < array0.Length; i++)
                {
                    if (array0[i] > 0) sum += array0[i];
                }

            }

            else if (isPositiv == false)
            {

                for (int i = 0; i < array0.Length; i++)
                {
                    if (array0[i] < 0) sum += array0[i];
                }

            }

            return sum;

        }


        // Task 32
        public void ReplaceArray(int[] array0)
        {

            for (int i = 0; i < array0.Length; i++)
            {
                array0[i] = -array0[i];
            }

        }



        // Task 33
        public string InArray(int[] array0, int number)
        {
            bool test = false;
            string result = $"Нет, заданное число - [{number}] отсутствует в массиве";
            for (int i = 0; i < array0.Length; i++)
            {
                if (array0[i] == number && test != true)
                {
                    result = $"Да, заданное число - [{number}] присутствует в массиве";
                    test = true;
                }

            }
            return result;
        }



        // Task 35
        public int CountInRange(int[] array0, int start, int end)
        {
            int count = 0;
            for (int i = 0; i < array0.Length; i++)
            {
                if (array0[i] >= start && array0[i] <= end)
                {
                    count++;
                }
            }
            return count;
        }



        // Task 37
        public void MultNumArray(int[] array, int size)
        {

            int halfSize = size / 2;
            int maxIndex = size - 1;
            int[] result = new int[halfSize + size % 2];
            for (int i = 0; i < halfSize; i++)
            {
                result[i] = array[i] * array[maxIndex - i];
                Console.WriteLine($"{array[i]} * {array[maxIndex - i]} = {array[i] * array[maxIndex - i]}");
            }
            
            if (size % 2 == 1)
            {
                result[halfSize] = array[halfSize];
                Console.WriteLine("Средний элемент: " + array[halfSize]);
            }
            ar.PrintArray(result);

        }



    }
}