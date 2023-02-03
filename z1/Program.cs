void Method1()
{
    System.Console.WriteLine("Автор:   ");
}
//Method1();


//vid2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения: ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text: ", 4);
//Method21(count:4,msg: "New text");

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);

string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "kek01");
//System.Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //System.Console.WriteLine($"{i}*{j}={i * j}");
    }
    //System.Console.WriteLine();
}

string text = "– Я думаю, – сказал князь, улыбаясь, – "
+ "что, ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. Вы так"
+ "красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + ($"{newValue}");
        else result = result + text[i];
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
//System.Console.WriteLine();
NewText = Replace(NewText, 'к', 'К');
NewText = Replace(NewText, 'С', 'с');
// System.Console.WriteLine(NewText);

int[] arr = { 1, 5, 4, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;


    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.LongLength- 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length ; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);