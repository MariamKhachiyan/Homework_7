/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Console.WriteLine("Enter first dimension:");
int rows= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second dimension:");
int columns= Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-100, 100) / 10;
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}




Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет



int n = 9;
int m = 9;
int[,] arr = new int[n, m];
Random random = new Random();

Console.WriteLine("Source array: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Enter row: ");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter column: ");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;

if (rows < 0 || rows >= n || columns < 0 || columns >= m)
{
    Console.WriteLine("Element  dosen't exist.");
}
else
{
        Console.WriteLine($"Value of element = {arr[rows, columns]}");
}


Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


/* int numRows = 5;
int numColumns = 5;

int[,] array = CreateRandom2dArray(numRows, numColumns);

Console.WriteLine("Source array:");
Print2dArray(array);

CalculateColumnAverages(array);

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
        array[i, j] = random.Next(-10, 11);
       }
    }

return array;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }    
}


void CalculateColumnAverages(int[,] array)
{

    int numRows = array.GetLength(0);
    int numColumns = array.GetLength(1);

    for (int j = 0; j < numColumns; j++)
    {
        int sum = 0;
        for (int i = 0; i < numRows; i++)
        {
            sum += array[i, j];
        }
    double average = (double)sum / numRows;
    Console.WriteLine($"Arithmetic average of column {j + 1}: {average:F2}");
    }
} */