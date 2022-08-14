Console.Write("Введите число поиска ");
int find = Convert.ToInt32(Console.ReadLine());
int[] array = { 12, 4, 6, 8, 2, 12 };
int n = array.Length;
int index = 0;
// for (int index = 0; index < n; index++)
// {
//     if (array[index] == find) Console.WriteLine("Число совпало на " + find);
//     else Console.WriteLine("Число не совпало");
// }

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}


