// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillMultiArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMultiArray(int[,] matr)// Метод вывода многомерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)// matrix.GetLength(1) - количество столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();// Для вывода массива в виде таблицы 3*4
    }
}

int[,] RealMatrix = new int[3, 4];

void SortSelection(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            int MinPos = i;
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k,j] > matrix[k,MinPos]) MinPos = j;
            }
            int temp = matrix[k,i];
            matrix[k,i] = matrix[k,MinPos];
            matrix[k,MinPos] = temp;
        }
    }
}

FillMultiArray(RealMatrix);
PrintMultiArray(RealMatrix);
System.Console.WriteLine();
SortSelection(RealMatrix);
PrintMultiArray(RealMatrix);


