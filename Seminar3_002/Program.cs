﻿// Задача 18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек 
// в этой четверти (x и y)

Console.WriteLine("Введите четверть 1,2,3 или 4 ");
int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x);

if (x == 1) Console.WriteLine("Диапазон координат x > 0, y > 0");
if (x == 2) Console.WriteLine("Диапазон координат x < 0, y > 0");
if (x == 3) Console.WriteLine("Диапазон координат x < 0, y < 0");
if (x == 4) Console.WriteLine("Диапазон координат x > 0, y < 0");
else Console.WriteLine("Вы ввели неправильное значение! Перезапустите программу"); 