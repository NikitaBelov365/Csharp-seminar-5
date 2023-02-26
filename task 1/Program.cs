// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integers pls");
    return 0;
}

int[] ArrayCreation(int arraySize)
{
    int[] array = new int[arraySize];
    return array;
}

void ArrayFill(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 9);
    }
}

void ArrayPrint(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($", " + array[i]);
    }
    System.Console.WriteLine();
}

int PositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i]>0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int NegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {        
        if(array[i]<0)
        {
            sum -= array[i];
        }
    }
    return sum;
}

int input = InputArraySize("Input array size:");
int[] array = ArrayCreation(input);
ArrayFill(array);
ArrayPrint(array);
System.Console.WriteLine($"Positive sum = {PositiveSum(array)}, negative sum = {NegativeSum(array)}");
