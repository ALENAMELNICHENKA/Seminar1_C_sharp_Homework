// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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


// Метод рассчета разницы м/у min и max 
int diffMinMax(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }

    }
    Console.WriteLine($"Минимальное число: {min}");
    Console.WriteLine($"Максимальное число: {max}");
    Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");
    return max - min;

}

int[] array = GetArray(4, 0, 100);
Print(array);
Console.WriteLine();
int dif = diffMinMax(array);