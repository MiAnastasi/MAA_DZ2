﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// 10. 1 
// string? number = Console.ReadLine();
// Console.WriteLine(number[1] + "");

// 10.2 
int number = Convert.ToInt32(Console.ReadLine());
int result = (number/10) % 10;
Console.WriteLine($"Вторая цифра числа: {result}");