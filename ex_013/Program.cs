﻿// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input any integer number: ");
int number = int.Parse(Console.ReadLine());
if (number > 100)
{
    while (number / 10 >= 100)
    {
        number = number / 10;
    }
    int remainder = number % 10;
    Console.WriteLine($"{remainder}");
}
else 
    {
        Console.WriteLine("There is no third digit");
    }