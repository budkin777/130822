//Вид 1 - Ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

//Вид 2 - Прнимают на вход значения, но ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Тект сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count) 
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", 5);
//Method21(count: 4, msg: "Текст"); // указываем переменной значение(можно не по порядку)

//Вид 3 Ничего не принимают, но что-то возвращают

int Method3 ()
{
    return DateTime.Now.Year;
}

// int year = Method3(); 
// Console.WriteLine(year);

//Вид 4 Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0;i < count;i++)
    {
        result = result + text;
    }
    return result;  
}
string res = Method4(10, "текс1");
Console.WriteLine(res);


