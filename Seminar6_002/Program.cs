// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

// int t1 = 100;
// int t2 = 2;
// int t3 = 1;

// Console.WriteLine($"{t1} {t2} {t3}");

// if (t1 < t2 + t3 && t2 < t1 + t3 && t3 < t1 + t2) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

//Михаил_____________________________________________________
// int a = 10000;

// int b = 4;

// int c = 5;

// if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Существует");

// else Console.WriteLine("НЕ существует");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine($"Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [n];
// arr[0] = 0;
// arr[1] = 1;

// for (int i = 2; i < n; ++i)
// {
//     arr[i] = arr[i-1] + arr[i-2];
// }
// Console.WriteLine($"[{String.Join("; ", arr)}]");

//Через числа------------------------------------------------------------

// int N = 10;

// int firstElement = 0; // Первое число по определению равно 0

// int secondElement = 1; // Второе число равно 1

// Console.WriteLine(firstElement); // 1 число
// Console.WriteLine(secondElement); // 2 число

// for (int i = 3; i <= N; i++)
// {
// int nextElement = firstElement + secondElement;
// Console.WriteLine(nextElement);
// firstElement = secondElement;
// secondElement = nextElement;
// }



// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива 
// с помощью поэлементного копирования.

// int size = 10;
// int[] array = new int[size];

// for (int i = 0; i < size; ++i)
// {
//     array[i] = new Random().Next(10);
// }
// Console.WriteLine($"Array     [{String.Join("; ", array)}]");

// int[] arrayCopy = new int[size];

// for (int i = 0; i < size; ++i)
// {
//     arrayCopy[i] = array[i];
// }
// Console.WriteLine($"ArrayCopy [{String.Join("; ", arrayCopy)}]");
