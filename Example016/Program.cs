
void PrintArray(string [,] table)
{
for(int i = 0; i < table.GetLength(0); ++i)
{
    for(int j = 0; j < table.GetLength(1); ++j)
    {
        Console.Write($"[-{table[i, j]}-]");
    }
    Console.WriteLine();
}
}
string[,] arr = new string[2, 5];
PrintArray(arr);
