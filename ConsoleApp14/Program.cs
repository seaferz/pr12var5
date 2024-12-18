/*Заменить буквы строки за каждой точкой на соответствующую большую букву. 
Добавить после каждой цифры два нуля.*/

string input = "hello1. world2. test3";
string result = "";
bool afterDot = false; // флаг для отслеживания, что символ идет после точки

foreach (char c in input) 
{
    if (c == '.')
    {
        result += c;
        afterDot = true; //следующий символ будет с заглавной буквы
    }
    else if (char.IsLetter(c) && afterDot)
    {
        result += char.ToUpper(c); //делает букву заглавной
        afterDot = false; //сбрастывает флаг
    }

    else if (char.IsDigit(c))
    {
        result += c + "00"; //добавляет к цифре два нуля
    }

    else
    {
        result += c; //добавляет остальные символы в переменную без изменений
    }
}

Console.WriteLine(result);
