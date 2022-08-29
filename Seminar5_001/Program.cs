// int[] array = new int[12];

// int sumOfNegativeNumbers = 0;
// int sumOfPosotiveNumbers = 0;
// int arraySize = array.Length;

// for(int i = 0; i < arraySize; i++) //i, j, k, m - счетчики
// {
//     array[i] = new Random().Next(-9,10);
//     if(array[i] < 0)  sumOfNegativeNumbers = sumOfNegativeNumbers + array[i];
//     else sumOfPosotiveNumbers += array[i];
// }
// Console.WriteLine($"[{string.Join( "| ", array)}]");
// Console.WriteLine($"Сумма отрицательных равна {sumOfNegativeNumbers}");
// Console.WriteLine($"Сумма положительных равна {sumOfPosotiveNumbers}");

//---------------------------------------------------------------------------

// int[] array = {-4, -8, 8, 2};

// int arraySize = array.Length;
// for(int i = 0; i < arraySize; i++)
// {
//         array[i] = array[i] * -1;
// }
// Console.WriteLine($"Полученный массив {String.Join(", ",array)}");

//------------------------------------------------------------------------------

// int[] arr = new int[10];
// int arraySize = arr.Length;
// Console.WriteLine("Введите число для поиска: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countDa = 0;

// for(int i = 0; i < arraySize; i++)
// {
//     arr[i] = new Random().Next(0,10); 
//     if (arr[i] == number) countDa += 1;
//     }    
// Console.WriteLine($"[{String.Join(", ", arr)}]");
// if(countDa > 0) Console.WriteLine($"Число {number} есть");
// else Console.WriteLine($"Числа {number} нет");
    
// -----------------------------------------------------------------------------------

int[] arr = new int[10];
int arrSize = arr.Length;
int count = 0;

for (int i = 0; i < arrSize; i++)
{
    arr[i] = new Random().Next(100);
    if (arr[i] >= 10 && arr[i] <= 99) count += 1;
}
Console.WriteLine($"Массив [{String.Join(", ", arr)}]");
Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");








