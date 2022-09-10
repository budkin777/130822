// Собрать строку с числами от а до b, a <=b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

//Рекурсия

string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a} " + NumbersRec(a + 1,b);
    else return String.Empty;

}

//  ----------------------------------------------------------------------
