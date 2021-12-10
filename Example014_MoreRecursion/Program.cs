// 1. собрать строку с числами от а до б, а <=b
string ShowNumbers (int a, int b)
{
    if(a==b) return $"{b}";
    else return $"{a} " + ShowNumbers(a+1, b);
}

System.Console.WriteLine(ShowNumbers(3,6));

// 2. a>=b
string ShowNumbers2 (int a, int b)
{
    if(a==b) return $"{b}";
    else return  $"{a} " + ShowNumbers2(a-1, b);
}

System.Console.WriteLine(ShowNumbers2(6,3));

// 3. сумма чисел от 1 до n
int Sum (int n)
{
    if(n==1) return 1;
    else return n+Sum(n-1);
}

System.Console.WriteLine(Sum(4));

// 4. факториал числа
int Factorial (int n)
{
    if(n==1|| n==0) return 1;
    else return n*Factorial(n-1);       
}

System.Console.WriteLine(Factorial(5));

// 5. a^n
int Degree(int a, int n)
{
    if(n==0) return 1;
    else
    {
        if(n%2==0) return Degree(a*a, n/2);
        else return a*Degree(a, n-1);
    }
}
System.Console.WriteLine(Degree(2,5));

// 6. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

void Words (string alphabet, char[] words, int n =0)
{
    if(n==words.Length) 
    {
        System.Console.WriteLine($"{new String(words)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        words[n] = alphabet[i];
        Words(alphabet, words, n+1);
    }
}
int n = 4;
Words("аисв", new char[n]);

// 7. обход всех директорий
string path = "/Users/1645295/Desktop/Examples/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}
path = "/Users/1645295/Desktop/Examples/";

CatalogInfo(path);