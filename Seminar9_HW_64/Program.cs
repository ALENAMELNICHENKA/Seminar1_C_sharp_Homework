// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// Чтение данных из консоли
int GetNumber(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}


// Функция рекурсии
string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return num + " " + LineGenRec(num - 1);
    }
}

int number = GetNumber("Введите натуральное число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);
