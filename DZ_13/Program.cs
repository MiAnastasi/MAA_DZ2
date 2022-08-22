//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string? number = Console.ReadLine();
int thidnumber = Convert.ToInt32(number);
if (thidnumber>99) Console.WriteLine("третья цифра: " + number[2]);
else Console.WriteLine("третьей цифры нет");