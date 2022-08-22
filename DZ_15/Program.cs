//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber >5) Console.WriteLine("да");
else Console.WriteLine("нет");
