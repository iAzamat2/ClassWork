namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {
        public void cls()
        {
            Console.Clear();
        }



        public void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
        {
            finishNumber++;
            Random random = new Random();
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }



        public void ChangeArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int row = rows - 1;

            for (int j = 0; j < columns; j++)
            {
                (array[0, j], array[row, j]) = (array[row, j], array[0, j]);
            }
        }



        public void ChangeRowsColumnsArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < columns; j++)
                {
                    (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
                }
            }
        }



        public void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}