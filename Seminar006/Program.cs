Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if(firstnumber % secondnumber == 0) Console.WriteLine ("кратно");
else 
{
    int r = firstnumber % secondnumber;
    Console.WriteLine ("Не кратно, остаток от деления " + r);
}

