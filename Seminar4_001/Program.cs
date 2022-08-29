
/*Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
// Console.WriteLine("Введите чило А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= a; i++)
// {
//     sum += i;
// }
// Console.Write("Сумма равна: " + sum);

//Метод - это функция, которая создается собственноручно


int GetSumNumbers(int start, int number)
{
    int sum = 0;
    while (start <= number)
    {
        sum += start;
        start++;
    }
    return sum;
}

Console.WriteLine("Введите чило А: ");
int a = Convert.ToInt32(Console.ReadLine());
int res = GetSumNumbers(2, a);
Console.Write("Сумма равна: " + res);


