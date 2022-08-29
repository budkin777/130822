// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8];

// for(int i = 0; i < 8; i++)
// {
//     arr[i] = new Random().Next(2);
//     Console.Write($"{arr[i]} ");
// }

int[] GetBinatyArray(int sizeArray)
{
    int[] result = new int[sizeArray]; //sizeArray = 5; result = {0,0,0,0,0}
    for (int i = 0; i < sizeArray; i++)
    {
        result[i] = new Random().Next(2); // Next(2) значит от [0,2) от 0 до 1
    }
    return result;
}

int [] arr = GetBinatyArray(8);
Console.Write($"Результат [{String.Join(", ", arr)}]");





