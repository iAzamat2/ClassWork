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



        public void SpiralFillArray(int[,] array)
        {

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int row = 0;
            int column = 0;
            int changeRow = 0;
            int changeColumn = 1;
            int steps = columns;
            int turn = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[row, column] = i + 1;
                steps--;
                if (steps == 0)
                {
                    steps = columns * (turn % 2) + rows * ((turn + 1) % 2) - 1 - turn / 2;
                    (changeRow, changeColumn) = (changeColumn, -changeRow);
                    // int temp = changeRow;
                    // changeRow = changeColumn;
                    // changeColumn = -temp;
                    turn++;
                }
                row += changeRow;
                column += changeColumn;
            }


        }



        public int SumNumber(int number, int sum)
        {
            if (number == 0) return sum;
            sum += number % 10;
            number /= 10;
            return SumNumber(number, sum);
        }



        public int PowRec(int a, int b, int result = 1)
        {
            if (b == 0) return result;
            result *= a;
            b--;
            return PowRec(a, b, result);
        }



    }
}