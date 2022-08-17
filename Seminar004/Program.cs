// Работа с esle if - если одно условие совпало, то другие выполняться не будут
// А если if то если условие выполнено будет дальше проверять.
// int temp = -30;
// if (temp > 0) Console.WriteLine("1");
// else if (temp < -10) Console.WriteLine("2");
// else if (temp < -20) Console.WriteLine("3");
// else if (temp <= -30) Console.WriteLine("4");

int number = new Random().Next(10, 100); //[10;100) -> [10;99]
Console.WriteLine("Рандомное число: " + number);

int firstDigit = number / 10;
//Console.WriteLine(firstDigit);
int secondDigit = number % 10;
//Console.WriteLine(secondDigit);

// if(firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

int maximum = firstDigit;
if(maximum < secondDigit) maximum = secondDigit;

Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum} "); //Интерполяция
// Конкатенация - складывает строчки
// Интерполяция - преобразует содержимое в строчку
