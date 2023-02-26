// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.


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

int[] RefilledArray(int []array)
{
    int[] newArray = new int[array.Length/2+array.Length%2];
    for (int i = 0; i < (array.Length/2+array.Length%2); i++)
    {
        newArray[i] = array[i]*array[array.Length-i-1];
    }
    return newArray;
}

int []array = ArrayCreation(InputArraySize("Input array size"));
ArrayFill(array);
ArrayPrint(array);
int[] newArray = RefilledArray(array);
ArrayPrint(newArray);