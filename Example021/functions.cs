namespace FunctionsOfArray
{
    public class FunctionsOfArrayClass
    {

        int[] GetTime(int[] array)
        {
            string str = DateTime.Now.ToString("HH:mm");
            str = str.Replace(":", "");
            char[] CharArray = str.ToCharArray(0, str.Length);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(CharArray[i].ToString());
            }
            return array;
        }



        void GetGraphTime(int[,] array, int index)
        {
            int[][,] pic =
                {
            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                    },
            new int[,]
                    {
                        { 0, 0, 1, 0, 0},
                        { 1, 1, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 1, 1, 1, 1, 1},
                    },

            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 0, 0, 0, 1, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 1, 0, 0, 0},
                        { 1, 0, 0, 0, 0},
                        { 1, 1, 1, 1, 1},
                    },
            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 0, 0, 0, 0, 1},
                        { 0, 0, 1, 1, 0},
                        { 0, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                    },
            new int[,]
                    {
                        { 1, 0, 0, 0, 0},
                        { 1, 0, 0, 0, 0},
                        { 1, 0, 0, 0, 0},
                        { 1, 0, 1, 0, 0},
                        { 1, 1, 1, 1, 1},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                    },
            new int[,]
                    {
                        { 1, 1, 1, 1, 1},
                        { 1, 0, 0, 0, 0},
                        { 1, 0, 0, 0, 0},
                        { 1, 1, 1, 1, 0},
                        { 0, 0, 0, 0, 1},
                        { 0, 0, 0, 0, 1},
                        { 1, 1, 1, 1, 0},
                    },
            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 0},
                        { 1, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                    },
            new int[,]
                    {
                        { 1, 1, 1, 1, 1},
                        { 0, 0, 0, 0, 1},
                        { 0, 0, 0, 1, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                        { 0, 0, 1, 0, 0},
                    },
            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                    },
            new int[,]
                    {
                        { 0, 1, 1, 1, 0},
                        { 1, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 1},
                        { 0, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 1},
                        { 0, 1, 1, 1, 0},
                    }};

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = pic[index][i, j];
                }
            }
        }



        void PrintImage(int[,] image)
        {
            image[2, 13] = 1;
            image[4, 13] = 1;
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    if (image[i, j] == 0) Console.Write($" ");
                    else Console.Write($"@");
                }
                Console.WriteLine();
            }
        }



        public void FillTimeArray()
        {
            int size = 4;
            int[] timeArray = new int[size];
            GetTime(timeArray);

            int[,] graphNumber = new int[7, 5];
            int[,] array = new int[7, 27]; //7 27

            for (int k = 0; k < size; k++)
            {
                int sdvig = -1;
                switch (k)
                {
                    case 0: sdvig = 0; break;
                    case 1: sdvig = 6; break;
                    case 2: sdvig = 16; break;
                    case 3: sdvig = 22; break;

                }

                GetGraphTime(graphNumber, timeArray[k]);

                for (int i = 0; i < graphNumber.GetLength(0); i++)
                {
                    for (int j = 0; j < graphNumber.GetLength(1); j++)
                    {
                        array[i, j + sdvig] = graphNumber[i, j];
                    }
                }

            }
            PrintImage(array);
        }


    }
}
