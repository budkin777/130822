// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A(x,y) ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B(x,y) ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Точка A({xA},{yA})");
// Console.WriteLine($"Точка B({xB},{yB})");

double result = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
//double result = Math.Sqrt(help);  
//Console.WriteLine($"Расстояния между точками A({xA},{yA}) и B({xB},{yB}) = {Math.Round(result, 2)}");

// Вывод с помощью среза 
Console.WriteLine($"Расстояния между точками A({xA},{yA}) и B({xB},{yB}) = {result:f2}");