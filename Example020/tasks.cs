using FunctionsOfArray;

namespace Tasks
{
    public class tasks
    {


        FunctionsOfArrayClass ar = new FunctionsOfArrayClass();



        // Task 39
        public void Reverse(int[] array0)
        {
            int size = array0.Length;
            int halfSize = size / 2;
            int maxIndex = size - 1;

            for (int i = 0; i < halfSize; i++)
            {
                // кортеж
                (array0[i], array0[maxIndex - i]) = (array0[maxIndex - i], array0[i]);
                // int temp = array0[i];
                // array0[i] = array0[maxIndex - i];
                // array0[maxIndex - i] = temp;
            }
        }



        // Task40
        public void Th0(int d, int e, int f)
        {
            bool test = true;
            // Неравенство треугольника
            if ((d > e + f) || (e > d + f) || (f > d + e))
            {
                test = false;
            }

            if (test == true)
            {
                Console.WriteLine($" [ Успех! ] Было введено: {d}, {e} и {f}. Эти стороны определяют треугольник.");
            }
            else
            {
                Console.WriteLine($" [ Ошибка! ] Было введено: {d}, {e} и {f}. Эти стороны не определяют треугольник.\n Не выполняется неравенство треугольника");
            }
        }



        // Task 42
        public int DecToBin(int number)
        {
            int result = 0;
            int bias = 1;

            while (number > 0)
            {
                result += number % 2 * bias;
                bias *= 10;
                number /= 2;

            }

            return result;
        }



        // Task 44
        public void Fibonacci(double[] array0)
        {
            for (int i = 2; i < array0.Length; i++)
            {
                array0[i] = array0[i - 2] + array0[i - 1];
            }
        }



        // Task 45
        public void CopyArray(int[] array0, int[] array1)
        {
            for (int i = 0; i < array0.Length; i++)
            {
                array1[i] = array0[i];
            }
        }



    }
}