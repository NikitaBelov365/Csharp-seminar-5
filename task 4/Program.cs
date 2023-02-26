// Задача 3: Задайте одномерный массив из 10 случайных чисел 
// в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 


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
        array[i] = rnd.Next(0, 200);
    }
}

void ArrayPrint(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", " + array[i]);
    }
    System.Console.WriteLine();
}

int AmmountOFTwoDigitElementsOfArray(int[] array)
{
    int ammount=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>9 && array[i]<100)
        {
            ammount ++;
        }
    }
    return ammount;

}

int []array = ArrayCreation(InputArraySize("Input array size"));
ArrayFill(array);
ArrayPrint(array);
System.Console.WriteLine($"There is {AmmountOFTwoDigitElementsOfArray(array)} two digit elements in this array");
