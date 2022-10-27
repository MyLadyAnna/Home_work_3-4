// Напишите программу, которая задаёт массив из n элементов и выводит их на экран.


void RandomArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(0, 20);
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
Console.Write("Введите длину массива: ");
int arrayLength = int.Parse(Console.ReadLine() ?? "0");

RandomArray(arrayLength);

