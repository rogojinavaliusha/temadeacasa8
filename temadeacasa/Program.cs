/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да */

 static void Main(string[] args)
    {

 Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

   static bool IsPalindrome(int num)
    {
        // Разделим число на отдельные цифры
        int digit1 = num / 10000;
        int digit2 = (num / 1000) % 10;
        int digit3 = (num / 100) % 10;
        int digit4 = (num / 10) % 10;
        
       
int digit5 = num % 10;

// Проверим, является ли число палиндромом

    return digit1 == digit5 && digit2 == digit4;
 }

    }