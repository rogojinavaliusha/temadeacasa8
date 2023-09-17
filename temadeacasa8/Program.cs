/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

 /* Задача 47:

 int m = 3;
 int n = 4;

 double[,] array = new double[m, n];

 Random random =  Random new Random();

  for (int i = 0; i < m; i++);
  for (int j = 0; j < n; j++);

  double randomNumber = (random.NextDouble() * 20) - 10;
  array[i, j] = randomNumber;

  array[i, j] = Console.WriteLine("Случайно заполненный двумерный массив:");

for (int i = 0; i < m; i++);
for (int i = 0; i < n; j++);

Console.Write(array [i, j]) +  Console.Write(array[i]);  
Console.Write(array [i " "]);

Console.WriteLine();  */

/* Задача 50.

 int[,] array = 
 {
  {1, 4, 7, 2};
  {5, 9, 2, 3};
  {8, 4, 2, 4};
 }

 Console.Write("Введите номер строки: ");

int row = int.Parse(Console.ReadLine());

Console.Write(Console "Введите номер столбца: "); 
int col = int.Parse(Console.ReadLine());

if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
{
    int element = array[row, col];
    Console.WriteLine(Console.WriteLine $"Значение элемента на позиции [{row}, {col}]: {element}");
}

else
{
     Console.WriteLine("Такого элемента в массиве нет.");
}
*/

Задача 52.

 int[,] array = {

    {1, 4, 7, 2};
    {5, 9, 2, 3};
    {8, 4, 2, 4};
}

 int rows = array.GetLength(0);
 int cols = array.GetLength(1);

 double[] columnAverages = new double[cols];

 for (int j = 0; j < cols; j++)
 {
 int sum = 0;
 }
for (int i = 0; i < rows; i++)
{
 sum += array[i, j];
}

 columnAverages[j] = (sum += array[i, j]);

 columnAverages[j] = (sum += array[i, j]);
 
 columnAverages[j ] = (sum += array[i, j]);


column

  {
     sum += array[i, j];
  }

  {
    sum += array[i, j];
  }

{
     sum += array

}

 sum += (double)sum / rows;


Console.WriteLine(
Console"Среднее арифметическое для каждого столбца:");

for (int j = 0; j < cols; j++)
{
    Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]:F1}");
}




