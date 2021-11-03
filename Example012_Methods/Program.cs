// Вид 1( ничего не принимают и ничего не возвращают)
void Method1()
{
    Console.WriteLine("Hello, Пушкин");
}
Method1();

//Вид 2(что-то принимают, но ничего не возвращают)

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg + "   ");
        i++;
    }
}
Method2("Текст сообщения ", 5);

//Вид 3 (ничего не принимают, но что-то возвращают)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид 4 (что-то принимают и что-то возвращают)
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i<count)
//     {
//         result = result+text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(4, "ABCD");
Console.WriteLine(res);

//Цикл в цикле
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

//Дан текст. В нем нужно 
//заменить все пробелы черточками, 
//маленькие "к" на большие "К", 
//большие "С" на маленькие "с"

string text = "Приходит студент—программист на занятия с утра злой. "
            + "Его одногрупники спрашивают: — Ты чего такой злой? "
            + "— Да программу вчера всю ночь набивал. — И что, не заработала? "
            + "— Да нет, заработала. — Может, неправильно заработала? "
            + "— Да нет, правильно. — А что тогда? "
            + "— Да на Backspace уснул… ";

//s = "qwerty"
//     012345
//s[3] == r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.Write(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.Write(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.Write(newText);
Console.WriteLine();

//Упорядочивание массива от min к max

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

