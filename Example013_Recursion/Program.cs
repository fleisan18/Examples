string[,] table = new string [2,5];
// строка, столбец
// table [0,0]   table [0,1]  table [0,2]  table [0,3]  table [0,4]
// table [1,0]   table [1,1]  table [1,2]  table [1,3]  table [1,4]
// table[1,2] = "word"; 
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int col = 0; col < 5; col++)
//     {
//         System.Console.WriteLine($"-{table[rows, col]}-");
//     }
// }

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(1,10);
        }
    }
}
int[,] matrix = new int [3,4];
PrintArray(matrix);
System.Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);

double Factorial (int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}


//f(1) = 1
//f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci (int n)
{
    if(n==1||n==2) return 1;
    else return Fibonacci(n-1) +Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}