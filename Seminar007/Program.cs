Console.WriteLine("Введите пожалуйста число: ");
int number = Convert.ToInt32(Console.ReadLine());

// && - логический оператор "И"
// || - логический оператор "Или"
if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");

