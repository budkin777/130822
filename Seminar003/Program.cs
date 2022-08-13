int number = Convert.ToInt32(Console.ReadLine());
// -n = n * (-1)
int negativNumber = number * (-1);

while (negativNumber <= number)
{
    Console.Write(negativNumber + " ");
    negativNumber ++;
}

