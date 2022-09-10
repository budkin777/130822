// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] array = new int[3, 4];

int m = array.GetLength(0);
int n = array.GetLength(1);


for (int i = 0; i < m; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


