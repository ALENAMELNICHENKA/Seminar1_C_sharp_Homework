// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int numTest = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(numTest);
Console.WriteLine("вторая цифра числа -> " + stringNumber[1]);
