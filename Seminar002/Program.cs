Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
//int q = number2 * number2;
Console.Write("Результат: ");

// == проверка на равенство: 5==5 - True
if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число " + number1 + " является квадратом от " + number2);
}
else
{
    Console.WriteLine("Первое число " + number1 + " НЕ является квадратом от " + number2);
}
