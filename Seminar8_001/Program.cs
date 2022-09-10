// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива

// int[,] arr = new int[3, 3];



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    //return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();

// Метод замены строк

void ChangeRows(int[,] inputMatrix)
{
    int indexLastRow = inputMatrix.GetLength(0) - 1; // size - 1
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        int temp = inputMatrix[0, i];
        inputMatrix[0, i] = inputMatrix[indexLastRow, i];
        inputMatrix[indexLastRow, i] = temp;
    }
}
// int [,] arrCopy = new int [3,3];

// for (int i = 0; i < arrCopy.GetLength(0); i++)
// {
//     for (int j = 0; j < arrCopy.GetLength(1); j++)
//     {
//         arrCopy[i, j] = arr [j, i];

//     }

// }
// PrintArray(arrCopy);

//---------Решение Миша--------------------------------
// if (rows != columns)
// {
// Console.WriteLine("Заменить элементы нельзя");
// return;
// }

int[,] ChangeArray(int[,] matrix)
{
int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < result.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
result[j,i] = matrix[i, j];
}
}
return result;
}

---------------------------------------------------------------------------

//59 задачка: 

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int indexMinRows = 0; // строчка
int indexMinColumns = 0; // столбец с мин элементом

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(11); // [0;10]
Console.Write(matrix[i, j] + "\t");
if (minElement > matrix[i, j]) // 5 > 0, min = 0
{
indexMinColumns = j;
indexMinRows = i;
minElement = matrix[i,j];
}
}
Console.WriteLine();
}
System.Console.WriteLine("Result: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (indexMinRows != i)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (indexMinColumns != j)
{
Console.Write(matrix[i, j] + "\t");
}
}
Console.WriteLine();
}
}
