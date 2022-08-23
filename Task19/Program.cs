// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// string val = "12821";


string Compare(string val, int i, int j)
{
    if (val[i]==val[j])
    {
        if (val[i+1]==val[j-1]) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
    else Console.WriteLine("нет");
return val;
}

Compare("12821", 0, 4);

