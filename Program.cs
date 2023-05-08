/* Домашнее задание.
Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.*/

using System;
using static System.Console;

int[, ] array = GetArray(2, 3, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}

int [] GetRowArray1(int[,] array) 
{
    int[] result = new int[3]; // inArray.GetLength(1)];
    int index = 0;
    
    for(int j = 0; j < array.GetLength(1); j++)
        {
            result[index] = array[0, j];
            index++;
        }
    return result;
}

int[] Ar1 = GetRowArray1(array);
PrintRowArray1(Ar1);
WriteLine();

void PrintRowArray1 (int [ ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        Write($"{inArray[i]} ");
    }
     WriteLine();
}

int [] GetRowArray2(int[,] array) 
{
    int[] result = new int[3]; // inArray.GetLength(1)];
    int index = 0;
    
    for(int j = 0; j < array.GetLength(1); j++)
        {
            result[index] = array[1, j];
            index++;
        }
        return result;
}

int[] Ar2 = GetRowArray2(array);
PrintRowArray2(Ar2);
WriteLine();

void PrintRowArray2 (int [ ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        Write($"{inArray[i]} ");
    }
    WriteLine();
}

    Array.Sort(Ar1);
    foreach(int i in Ar1)
        {
            Write(i+ " " );
        }
        
    Array.Sort(Ar2);
    foreach(int i in Ar2)
        {
            Write(i+ " ");
        }
       
    Array.Reverse(Ar1);
        foreach(int i in Ar1)
        {
            Console.Write(i + " ");
        }

    Array.Reverse(Ar2);
        foreach(int i in Ar2)
        {
            Console.Write(i + " ");
        }

int[,] ResAr1 = GetResArray(array);
PrintResArray1(ResAr1);
WriteLine();

int [ , ] GetResArray(int[,] array) 
{
    int[,] result = new int[2, 3]; 
       
    for(int j = 0; j < array.GetLength(1); j++)
        {
            result[0, j] = Ar1[j];
            result[1, j] = Ar2[j];
        }
    return result;
}

void PrintResArray1(int [,] ar1)
{
    for(int i = 0; i < 2; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            Write($"{ar1 [i, j]}  ");
        }
        WriteLine();
    }
}

/*Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
строку с наименьшей суммой элементов.
Задача решена*/

/*using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();

WriteLine($"Индекс строки с минимальной суммой {String.Join(" ", GetMinSum(array))}"); 
WriteLine();
PrintArray(ChangeArray(array));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] array)
{
        for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array [i, 0] = array[i, 0] + array[i, j+1];
        }
    }
    return array;
}

int [] GetMinSum(int[,] inArray)

{
    int[] result = new int[] { 0, 0};
    int min = inArray[0, 0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(min > inArray[i, 0])
         {
            min = inArray[i, 0];
            result[0] = i;
         }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write ($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}*/

/*Задача 58. Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц.*/

/*using System;
using static System.Console;

int[, ] array1 = GetArray(2, 2, 1, 10);
PrintArray(array1);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}

int[, ] array2 = GetArray1(2, 2, 1, 10);
PrintArray1(array2);

int[,] GetArray1(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray1 (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}

int[, ] ProizMatr = GetProizMatr(2, 2);
PrintArray3(ProizMatr);

int[,] GetProizMatr(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = array1 [i, 0] * array2 [0, j] + array1 [i, 1] * array2 [1, j];
        }

    }
    return result;
}

void PrintArray3 (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}*/

/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
//Задача решена

/*using System;
using static System.Console;

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
Write("Введите глубину массива: ");
int dep = int.Parse(ReadLine());

int[ , , ] array = GetArray(rows, columns, dep, 10, 100);
PrintArray(array);
WriteLine();

int[ , ,] GetArray(int m, int n, int p, int min, int max) 
{
    int[, ,] result = new int[m, n, p];  
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                result[i, j, k ] = new Random( ).Next(min, max);
            }
        }
    }
    return result;
}

 
void PrintArray(int[, ,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                 Write($"{inArray[i, j, k]} ({i} {j} {k}) " );            
            }   
        } 
    WriteLine();         
    }       
}*/

/*Задача 62. Напишите программу, которая заполнит спиралью массив 4*4.
Например на выходе получается вот такой массив:
1   2   3   4
12  13  14  5 
11  16  15  6
10  9   8   7*/

/*using System;
using static System.Console;

int[, ] array = GetArray(4, 4, 0, 20);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }

    }
    return result;
}

void PrintArray (int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}


int [ , ] array1 = GetSpiralArray();

Void SpiralArray(int[ , ] array)
{
    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < 4; j++)
        {
        Write(array[i, j]+"\t");
        }
    }
    WriteLine();
}

int[ , ] GetSpiralArray(int size)

{
    int[ , ] result = new int [size, size];
    int i = 0;
    int j = 0;
    int temp = 1;
    while (size != 0)
    {
        int k = 0;
        do
        {
            result [i, j++] = temp++; 
        } while (++k < size-1);  
        for (k=0; k < size-1; k++)
        {
            result [i++, j] = temp++;  
        }
        for (k=0; k < size; k++)
        {
            result [i, j--] = temp++; 
        }
        for(k = 0; k < size-1; k++)
        {
            result [i--, j] = temp++;  
        }
        ++i; 
        ++j;
        if (size < 2)
        {
            size = 0;
        }
        else
        {
            size-=2;
        }        
    }
    return result; 
}*/


