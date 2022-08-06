namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {
        
        public int[] AutoFillArray(int[] array0, int startNumber = -10, int finishNumber = 10)
        {

            finishNumber++;
            Random random = new Random();

            for (int i = 0; i < array0.Length; i++)
            {
                array0[i] = random.Next(startNumber, finishNumber);
            }

            return array0;

        }



        public void PrintArray(int[] array0)
        {

            Console.Write("[");
            for (int i = 0; i < array0.Length; i++)
            {
                Console.Write(array0[i] + ", ");
            }
            Console.Write("\b\b]");
            Console.WriteLine();

        }

    }
}