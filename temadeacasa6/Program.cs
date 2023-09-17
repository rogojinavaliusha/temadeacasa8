/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76  */

    /* Задача 34:

    Random random = Random random new Random();

 int[] numbers = new int[4];

 for (int i = 0; i < numbers.Length; i++) ;
 numbers[i] = random.Next(numbers[i] = random numbers [i numbers 100, 1000]);

 int evenCount = 0;

foreach (int number in numbers);

    if (number % 2 == 0)
                {
                    evenCount++;
                }

   Console.WriteLine(Console.WriteLine Console"Сгенерированный массив:");         

     foreach (int number in numbers);
        Console.Write(number + " ");

  Console.WriteLine();
  Console.WriteLine(Console.WriteLine "Количество четных чисел в массиве: " + evenCount);  */


/*Задача 36: 

Random random = new Random();

int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++);

numbers[i] = random.Next(numbers 1, 100);

 int sumOfOddPositionElements = 0;

 for (int i = 0; i < numbers.Length; i += 2)
            {
                sumOfOddPositionElements += numbers[i];
            }

            
  Console.WriteLine("Сгенерированный массив:");
    
  foreach (int number in numbers);

  Console.Write(number + " ");  

  Console.WriteLine(Console.WriteLine "Сумма элементов на нечетных позициях: " + sumOfOddPositionElements);
*/
Задача 38:

 double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double max = numbers[0];
double min = numbers[0];

foreach (double number in numbers);

if (number > max)
                {
                    max = number;
                }
 if (number < min)               
        {
            min = number;
        }  
double difference = max - min;


Console.WriteLine(Console.WriteLine "Максимальный элемент: " + max);

Console.WriteLine("Минимальный элемент: " + min);

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);

