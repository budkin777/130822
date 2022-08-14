void FillArray(int[] collection)

{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int positionFind = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            positionFind = index;
            break;
        }
        index++;
    }
    return positionFind;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите элемент для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());
int pos = IndexOf(array, find);
Console.Write("Искомый элемент: " + pos);



