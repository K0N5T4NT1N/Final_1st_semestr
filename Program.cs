#nullable disable

string[] TextArray()
{
    int count = 0;
    string[] array = new string[count];
    string text;
    string[] tempArray;

    Console.WriteLine("Введите текст, после каждой строки нажмите Enter ");

    do
    {
        text = Console.ReadLine();
        if (text != "")
        {
            count++;
            tempArray = new string[count];
            for (int i = 0; i < tempArray.Length - 1; i++)
            
            tempArray[i] = array[i];
            tempArray[count - 1] = text;
            array = tempArray;            
        }
    } while (text != "");
    return array;
}

string[] FilterArray(string[] array, int value)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        char[] text = array[i].ToCharArray();
        if (text.Length >= value)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

Console.Clear();
string[] userText = TextArray();
string[] finalText = FilterArray(userText, 3);

System.Console.Write("Итоговый текст: ");
System.Console.WriteLine(String.Join(" ", finalText));
Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
Console.ReadKey();