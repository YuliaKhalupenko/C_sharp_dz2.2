﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();

Console.WriteLine("Введите 3хзначное число: ");
int a = int.Parse(Console.ReadLine()!);


if(a > 99 && a < 1000) 
{
Console.WriteLine($"Вторая цифра числа {a} = {a /10 % 10}");
}

else Console.WriteLine("это число не 3хзначное");