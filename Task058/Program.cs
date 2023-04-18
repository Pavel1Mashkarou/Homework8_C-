/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateAndFillMatrix(string arg)
{
    int [,] Matrix = new int[2,2];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            System.Console.WriteLine($"Введите элемент матрицы №{arg} [{i+1};{j+1}]");
            Matrix[i,j] = int.Parse(Console.ReadLine());
        }
    }
    return Matrix;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] Array1, int[,] Array2)
{
    int [,] Array = new int [2,2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = Array1[i,j]*Array2[i,j] + Array1[i,j+1]*Array2[i+1,j];
        }
    }
    return Array;
} 
/*-----------------------------------------------------------------------*/

int[,] Matrix1 = CreateAndFillMatrix("1");
int[,] Matrix2 = CreateAndFillMatrix("2");
System.Console.WriteLine("Первая матрица:");
PrintArray(Matrix1);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
PrintArray(Matrix2);
System.Console.WriteLine();
int[,] SummMatrix = MatrixMultiplication(Matrix1, Matrix2);
PrintArray(SummMatrix);