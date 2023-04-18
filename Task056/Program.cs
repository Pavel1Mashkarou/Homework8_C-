/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int CreateVariable (string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

void RectangleCheck (int m, int n)
{
    if (m<=0 || n<=0)
    {
        System.Console.WriteLine("Значение строки и столбца не может быть отрицательным или равно нулю!");
        throw new IndexOutOfRangeException();
    }
    else if (m == n) 
    {
        System.Console.WriteLine("Массив должен быть прямоугольным");
        throw new IndexOutOfRangeException();
    }
    else if(m!=n) System.Console.WriteLine("Массив прямоугольный, работаем дальше!");
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

void SummOfLines(int[,] Array)
{
    int min = 1000;
    int line = 0;
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int minCompare = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            minCompare+=Array[i,j];
        }
        if (minCompare < min) 
        {
            min = minCompare;
            line = i;
        }
        System.Console.WriteLine($"Строка {i} - сумма {minCompare}");
    }
    System.Console.WriteLine($"Строка с минимальной суммой элементов - {line}");
}
/*-------------------------------------------------------------------------------------------------------------*/
int M = CreateVariable("размер m");
int N = CreateVariable("размер n");

RectangleCheck(M, N);

System.Console.WriteLine("Задан массив: ");
int [,] Array = CreateArray(M,N);
PrintArray(Array);

SummOfLines(Array);