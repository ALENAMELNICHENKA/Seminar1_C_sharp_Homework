//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


// Метод вывода суммы чисел в числе, стоящих на нечётных позициях, т.е. индекс [1], [3] и т.д.
int SumNumbers(int[] array)
{
    int SumNum = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        SumNum+= array[i];
            
    }
    Console.WriteLine($"сумма нечётных позиций в массиве -> {SumNum} ");
    return SumNum;
}

Console.Clear();
int[] array = GetArray(4, -10, 10);
Print(array);
Console.WriteLine();
int SumNumber = SumNumbers(array);
