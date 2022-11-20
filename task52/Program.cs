// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Программа найдет среднее арифметическое в каждом столбце заданного вами массива.");
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());


void FillMatrixRandomNumbers(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = new Random().Next(0, 100);
        }
    }
    Console.WriteLine();
}


void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" | | ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5 }");
        }
        Console.Write(" | | ");
        Console.WriteLine("  ");
    }
}


int[,] numbers = new int[rows, columns];
Console.WriteLine("Среднее арифметическое каждого столбца: ");
FillMatrixRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(" [" + avarage + "] ");
}

Console.WriteLine();
PrintArray(numbers);