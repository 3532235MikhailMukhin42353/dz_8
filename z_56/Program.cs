/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Array = new int[5, 4];
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
SumMin(Array);

void FillArray(int[,] Array)
{
    Random rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(0, 21);
        }
    }
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SumMin(int[,] Array)
{
    int SumOneStroka = 0;
    int minSumRow = 0;
    int SumNewStroka = 0;
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        SumOneStroka += Array[0, i];
    }
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++) 
        SumNewStroka += Array[i, j];
        if (SumNewStroka < SumOneStroka)
        {
            SumOneStroka = SumNewStroka;
            minSumRow = i;
        }
        SumNewStroka = 0;
    }
    Console.Write($"{minSumRow + 1} строка");;
}
