// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Метод ввода числа с экрана
int GetNumber(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Метод получения случ. значений массива
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];//объявляем массив
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);//заполняем случ. числами
    }
    return array;
}

//Метод 
void Print(int[] arr)
{
    // int length = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    return;
}
 int size = GetNumber("Длина массива: ");
 int min = GetNumber("начальный диапазон: ");
 int max = GetNumber("Конечный диапазон: ");
 int[] array = GetArray(size, min, max);//заполнение массива случ. числами
 Print(array);