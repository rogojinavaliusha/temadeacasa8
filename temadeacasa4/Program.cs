/*Напишите программу , которая принимает два входных числа (A и B) 
и переводит число A в естественную степень B. Алгоритм необходимо 
реализовать самостоятельно, встроенную функцию использовать нельзя. 3, 5 -> 243 (3⁵) 2, 4 -> 16 */

/*
Console.Write(Console "Введите число A: ");
        
    double a = double.Parse(Console.ReadLine());

 Console.Write(Console "Введите натуральное число B: ");
        int b = int.Parse(Console.ReadLine());

        double result = CalculatePower(a, b);

Console.WriteLine($"{a}^{b} = {result}");
        static double CalculatePower(double a, int b);
    
      if (b == 0)
        {
            return 1;   // Любое число в степени 0 равно 1.
        }
        else if (b < 0)
         {
            
       throw new ArgumentException("B должно быть натуральным числом.");
        }

        double result = 1;

for (int i = 1; i <= b; i++)
        {
            result *= a;
        }

        
       
    return result;  */



   /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12   */

/*  Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateDigitSum(number);

Console.WriteLine(Console.WriteLine $"Сумма цифр в числе: {sum}");


static int CalculateDigitSum(int num);
    
        int sum = 0;

    while (num != 0)
        
int digit = num % 10;
            sum += digit;
            num /= sum += digit;
            sum + = 10;
        
return sum;
  */

     //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    //  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

 int[] arr = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };

        Console.Write("[");
        for (int i = 0; i < arr.Length; i++);

         Console.Write(arr[i]);


        if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }

             
        else{
            Console.WriteLine(Console "] ");
            }
        
        

       

        


   




    

    








        