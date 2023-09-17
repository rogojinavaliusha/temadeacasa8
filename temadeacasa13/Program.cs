/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int n = 4; // Размер массива (4x4)
            int[,] array = new int[n, n];

            int currentValue = 1;
            int left = 0, right = n - 1, top = 0, bottom = n - 1;

            while (left <= right && top <= bottom)
            {
                // Заполняем верхнюю строку слева направо
                for (int i = left; i <= right; i++)
                {
                    array[top, i] = currentValue++;
                }
                top++;

                // Заполняем правый столбец сверху вниз
                for (int i = top; i <= bottom; i++)
                {
                    array[i, right] = currentValue++;
                }
                right--;

                // Заполняем нижнюю строку справа налево
                for (int i = right; i >= left; i--)
                {
                    array[bottom, i] = currentValue++;
                }
                bottom--;

                // Заполняем левый столбец снизу вверх
                for (int i = bottom; i >= top; i--)
                {
                    array[i, left] = currentValue++;
                }
                left++;
            }

            // Выводим массив
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]:D2} ");
                }
                Console.WriteLine();
            }
            
