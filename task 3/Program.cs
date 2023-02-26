// Задача 2: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


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
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", " + array[i]);
    }
    System.Console.WriteLine();
}

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Input integer pls");
    return 0;
}

void ArrayCheck(int[] array, int number)
{
    int status = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            status = 1;
        }
    }
    if(status == 1)
    {
        System.Console.WriteLine($"There is {number} in this array");
    }
    else
    {
        System.Console.WriteLine($"There is no {number} in this array");
    }
}

int []array = ArrayCreation(InputArraySize("Input array size"));
ArrayFill(array);
ArrayPrint(array);
int number = InputInt("Input some number from -9 to 9");
ArrayCheck(array, number);