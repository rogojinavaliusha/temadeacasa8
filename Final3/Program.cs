﻿/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine(Console.WriteLineConsole $"A({m}, {n}) = {result}");

static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else{
        
    }

}