// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
        System.Console.WriteLine();// Для вывода матрицы в виде таблицы 3*4
    }
}


void PrintNewArray(int[] Arr2)
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
        System.Console.WriteLine();
    }
}


int[,] RealMatrix = new int[3, 4];

int[] SumRowMatrix(int[,] matrix)
{
    int SumRow;
    int[] arrsum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow = SumRow + matrix[i, j];
        }
        arrsum[i] = SumRow;
    }
    return arrsum;
}

int PosMinArray(int[] array)
{
    int MinPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < array[MinPos]) MinPos = i;        
    }
    return MinPos;
}

FillMultiArray(RealMatrix);
PrintMultiArray(RealMatrix);
System.Console.WriteLine();
int[] SumRow = SumRowMatrix(RealMatrix);
PrintNewArray(SumRow);
int PosRowMinSum = PosMinArray(SumRow)+1;
System.Console.WriteLine();
System.Console.WriteLine($"Минимальная сумма элемнтов в строке - {PosRowMinSum} матрицы");



