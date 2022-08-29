//Задача 17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

// int x = new Random().Next(-1000, 1000);
// int y = new Random().Next(-1000, 1000);
// //Console.WriteLine($"Координаты точки А(x,y) = A({x},{y})");
Console.WriteLine("Введите координату по оси оХ: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0) // можно без проверки, так как 0 не входит в if'sы ))
{
    if (x > 0 && y > 0) Console.WriteLine($"Точка А(x,y) = A({x},{y}) находится в 1й четверти");
    else if (x < 0 && y > 0) Console.WriteLine($"Точка А(x,y) = A({x},{y}) находится во 2й четверти");
    else if (x < 0 && y < 0) Console.WriteLine($"Точка А(x,y) = A({x},{y}) находится в 3й четверти");
    else if (x > 0 && y < 0) Console.WriteLine($"Точка А(x,y) = A({x},{y}) находится в 4й четверти");
}
else Console.WriteLine($"Координаты точки А(x,y) = A({x},{y}) не удовлетворяют требованием задачи X != 0 и Y != 0");



