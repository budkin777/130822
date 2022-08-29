// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"В числе {number} {number.Length} цифр(ы): ");
// int count = 0;
// while (number != 0)
// {
//     number /= 10;
//     count += 1;
// }
// Console.WriteLine(count);

int GetCountNumbers(int fnumber)
{
    int count = 0;
    while (fnumber > 0)
    {
        fnumber /= 10;
        count += 1;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetCountNumbers(number));


