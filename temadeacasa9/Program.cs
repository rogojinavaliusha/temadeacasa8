/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


        static void Main(string[] args)
        {
            int[,] array = {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
            };

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            Console.WriteLine("Исходный двумерный массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Упорядочиваем элементы каждой строки по убыванию
            for (int i = 0; i < rows; i++)
            {
                int[] rowArray = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    rowArray[j] = array[i, j];
                }

                Array.Sort(rowArray, (a, b) => -a.CompareTo(b));

                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rowArray[j];
                }
            }

            Console.WriteLine("Упорядоченный по убыванию двумерный массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                    Console.WriteLine();
            }
        }
    
    




