// Задача 49. Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
 
int[,] array = new int[3, 4];

int m = array.GetLength(0);
int n = array.GetLength(1);


for (int i = 0; i < m; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        array[i, j] = i + j;
        if(i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        // 0 считается четным числом
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

