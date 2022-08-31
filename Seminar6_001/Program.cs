// int size = 5;
// int[] arr = new int[size];

// for (int i = 0; i < arr.Length; ++i)
// {
//     arr[i] = new Random().Next(10);
// }
// Console.WriteLine($"Array         [{String.Join(", ", arr)}]");

// int[] resultArray = new int[size];
// int lastIndex = size - 1;

// for(int i = 0; i < size; ++i)
// {
//     resultArray[i] = arr[lastIndex - i];
// }
// Console.WriteLine($"Reverse array [{String.Join(", ", resultArray)}]");


int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void ReversArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;
}
