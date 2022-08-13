Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Здавствуй Машуля дуруля!!!"); 
}
else
{
    Console.Write("Здравствуй ");
    Console.Write(username);    
}
