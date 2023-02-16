/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] InitMatrix()
{
    int[,] array = new int[8, 8];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int GetRowNumber(string message, int[,] matrix)
{
    int rowNum = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out rowNum) && rowNum > 0
                                                         && rowNum <= matrix.GetLength(0))
        {
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Такого элемента нет. Повторите ввод!");
            Console.WriteLine();
        }
    }

    return rowNum;
}

int GetColNumber(string message, int[,] matrix)
{
    int colNum = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out colNum) && colNum > 0
                                                         && colNum <= matrix.GetLength(1))
        {
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Такого элемента нет. Повторите ввод!");
            Console.WriteLine();
        }
    }

    return colNum;
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
int row = GetRowNumber("Введите номер строки нужного вам элемента: ", matrix);
Console.WriteLine();
int col = GetColNumber("Введите номер столбца нужного вам элемента: ", matrix);
Console.WriteLine();
Console.WriteLine($"В {row}-й строке {col}-го столбца найден элемент со значением: {matrix[row - 1, col - 1]}");