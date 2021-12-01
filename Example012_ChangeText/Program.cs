string text = "В минуты отъезда и перемены жизни на людей," 
            + "способных обдумывать свои поступки, обыкновенно находит"
            + "серьезное настроение мыслей. В эти минуты обыкновенно"
            + "поверяется прошедшее и делаются планы будущего.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int leght = text.Length;
    for (int i = 0; i < leght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'о', 'О');
Console.WriteLine(newText);
Console.WriteLine();

