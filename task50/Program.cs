// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет



Console.Clear();
Console.WriteLine("Программа которая на вход принимает позиции элемента в двумерном массиве и говорит, есть ли этот элемент в массиве .");
Console.WriteLine("Введите номер строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int columns = Convert.ToInt32(Console.ReadLine());

void FillMatrixRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(0, 100)/10;
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" | | ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5 }  "); 
        }   
        Console.Write(" | |");
        Console.WriteLine(" "); 
    }
}


int [,] numbers = new int [10,10];
FillMatrixRandomNumbers(numbers);
if (rows > numbers.GetLength(0) && columns > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца равно {numbers[rows - 1, columns - 1]}");
}

PrintMatrix(numbers);