/*Напишите программу, которая на вход принимает позиции элемента в двухмерном массиве, и возвращает значение этого значениея
или же указание , что такого элемента нет.*/

Console.WriteLine("Let's define 2Darray."); 
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int[m,n];

Console.Write("Enter the ROW index: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the COLUMN index: ");
int column = Convert.ToInt32(Console.ReadLine());

Create2DArray(numbers);
Print2DArray(numbers);

if (row < numbers.GetLength(0) && column < numbers.GetLength(1)) 
{
    Console.WriteLine(numbers[row, column]);
}
else 
{
    Console.WriteLine($"{row}{column} -> There is no such number in the array!");
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}



