/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int CreateVariable (string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int m, int n)
{
    int[,] Array = new int[m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1,10);
        }
    }
    return Array;
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

int [,] ModifyArray (int[,] Array)
{
    for (int b =0; b<Array.GetLength(1); b++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            int temp;
            for (int j = 0; j < Array.GetLength(1)-1; j++)
            {
                if (Array[i,j]<Array[i,j+1])
                {
                    temp = Array[i,j];
                    Array[i,j] = Array[i,j+1];
                    Array[i,j+1] = temp;
                }
            }
        }
    }
    return Array;
}
/*---------------------------------------------------------------------------*/

int M = CreateVariable("размер m");
int N = CreateVariable("размер n");
System.Console.WriteLine("Задан массив:");
int [,] Array = CreateArray(M,N);
PrintArray(Array);
System.Console.WriteLine();
System.Console.WriteLine("Изменённый массив:");
int [,] NewArray = ModifyArray (Array);
PrintArray(NewArray);