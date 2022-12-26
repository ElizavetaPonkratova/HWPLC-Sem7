/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


try 
{
    Console.WriteLine("Enter m: ");
    double m = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter n: ");
    double n = Convert.ToDouble(Console.ReadLine());
    double[,] arr = Create2DArray(m,n);
    Print2DArray(arr);
}
catch (Exception)
{
    Console.WriteLine("Not correct info!");
}

void Print2DArray(double [,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] Create2DArray(double m, double n)
{
    double[,] array = new double[(int) m, (int) n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble (random.Next(-100,100))/10;
        }
    }

    return array;
}


    

