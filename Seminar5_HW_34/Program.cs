// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2


//Метод получения случ. значений массива
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}


//Метод вывода массива в консоль
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    return;
}

//Метод проверки на чётность
int TestEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"количество чётных чисел в массиве -> {count} ");
    return count;
}


Console.Clear();
int[] array = GetArray(5, 100, 1000);
Print(array);
Console.WriteLine();
int CountNum = TestEvenNum(array);
