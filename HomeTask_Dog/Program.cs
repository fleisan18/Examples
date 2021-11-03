double t;
double FFSpeed = 4;
double SFSpeed = 3;
double DogSpeed = 8;
double S = 1000;
int count = 0;
int friend = 2; // 1 - первый друг, 2  - второй друг


while(S >= 10)
{
    if(friend == 1)
    {
        t = S/(DogSpeed + FFSpeed);
        friend = 2;
    }
    else
    {
        t=S/(DogSpeed + SFSpeed);
        friend = 1;
    }
    S = S - t*(SFSpeed + FFSpeed);
    Console.WriteLine($"Расстояние между друзьями стало: {S}");
    count++;
    Console.WriteLine($"На данном этапе собака пробежала: {count}");

}
Console.WriteLine($"Всего собака пробежала: {count}");