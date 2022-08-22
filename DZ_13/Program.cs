//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string? number = Console.ReadLine();
int x = Convert.ToInt32(number);
if (x>99) Console.WriteLine("третья цифра: " + number[2]);
else Console.WriteLine("третьей цифры нет");