// Console.WriteLine("Двумерный массив: \n");

// int [,] array = new int [3,4];

// for(int i = 0; i < 3; ++i)
// {
//     for (int j = 0; j < 4; ++j)
//     {
//         array[i, j] = new Random().Next(11);
//         Console.Write($"[{array[i, j]}]"); 
//     }
//     Console.WriteLine();
// }

//======================Учитель(Методы)=========================================

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int m, int n)
{
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)//строчки
{
for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
{
matrix[i, j] = new Random().Next(11);
}
}
return matrix;
}


int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);


void PrintArray(int[,] inputMatrix)
{
for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
{
for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
{
Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
}
Console.WriteLine();
}
}


 