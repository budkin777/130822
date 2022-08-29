// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int factorial = 1;
// for (int i = 1; i <= n; i++)
// {
//     factorial *= i;        
// }
// Console.WriteLine($"Факториал числа {n} = {factorial}");

int GetNFactorial(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал числа {n} = {GetNFactorial(n)}");









