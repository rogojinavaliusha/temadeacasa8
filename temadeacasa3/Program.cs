/*Напишите программу , которая принимает входное число (N) и выдает таблицу кубов чисел от 1 до N. 5 -> 1 | 1 2 | 8 3 | 27 4 | 64 5 | 125   */


Console.Write("Введите число N: ");
    
    int N = int.Parse(Console.ReadLine());

 Console.WriteLine("Число | Куб числа");
    
 Console.WriteLine(Console.WriteLine,"-------------");   

 for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i,5} | {cube,3}");
        }


