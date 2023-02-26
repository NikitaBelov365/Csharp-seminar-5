// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void ArrayChange(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = -array[i];
    }
}

int []array = ArrayCreation(InputArraySize("Input array size"));
ArrayFill(array);
ArrayPrint(array);
ArrayChange(array);
ArrayPrint(array);