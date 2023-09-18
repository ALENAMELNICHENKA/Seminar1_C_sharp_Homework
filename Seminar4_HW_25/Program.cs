// SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// Метод читает данные от пользователя

int GetNumber(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Метод возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
ToDegree(numberA, numberB);