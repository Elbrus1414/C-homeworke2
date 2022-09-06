// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
// ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
int num = int.Parse(Console.ReadLine());
// if (num >= 1 && num <= 7)  // && num <= 7
   if  (num == 1) { Console.WriteLine("Рабочий день"); }
if (num == 2)
{ Console.WriteLine("Рабочий день"); }
if (num == 3)
{ Console.WriteLine("Рабочий день"); }
if (num == 4)
{ Console.WriteLine("Рабочий день"); }
if (num == 5)
{ Console.WriteLine("Рабочий день"); }
if (num == 6)
{ Console.WriteLine("Выходной день"); }
if (num == 7)
{ Console.WriteLine("Выходной день"); }
// else Console.WriteLine("Введённая цифра некорректна");



