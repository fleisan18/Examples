int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(1, 50);
int a2 = new Random().Next(1, 50); 
int a3 = new Random().Next(1, 50);
int b1 = new Random().Next(1, 50);
int b2 = new Random().Next(1, 50);
int b3 = new Random().Next(1, 50);
int c1 = new Random().Next(1, 50);
int c2 = new Random().Next(1, 50); 
int c3 = new Random().Next(1, 50);

Console.WriteLine(a1);
Console.WriteLine(a2);
Console.WriteLine(a3);
Console.WriteLine(b1);
Console.WriteLine(b2);
Console.WriteLine(b3);
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);

// int max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = b1;

// if(a2 > max) max = b1;
// if(b2 > max) max = b1;
// if(c2 > max) max = b1;

// if(a3 > max) max = b1;
// if(b3 > max) max = b1;
// if(c3 > max) max = b1;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b1, c3);
int max = Max(max1, max2, max3);

Console.WriteLine("Max");
Console.Write(max);

