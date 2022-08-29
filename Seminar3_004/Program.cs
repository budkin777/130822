// Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int min = 1; min <= n; min++) Console.WriteLine(Math.Pow(min,2));
// {
//     double result;
//     result = Math.Pow(min,2);
//     Console.Write(result + " ");
// } 

