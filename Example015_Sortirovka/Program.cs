int[] arr = { 2, 5, 6, 7, 43, 5, 6, 77, 5 };

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

void SelectionSorf(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;



    }
}

PrintArray(arr);
SelectionSorf(arr);
PrintArray(arr);
