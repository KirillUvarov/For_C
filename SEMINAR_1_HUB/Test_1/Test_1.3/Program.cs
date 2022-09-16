Console.Write("Введите число 1: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b;
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c;
c = Convert.ToInt32(Console.ReadLine());

int maxNum = 0;

{
    if (a>maxNum)
    {
        maxNum=a;
        
    }
    if (b>maxNum)
    {
        maxNum=b;
        
    }
    if (c>maxNum)
    {
        maxNum=c;
        
    }
    
}
Console.WriteLine($"Максимальное число:");
Console.WriteLine(maxNum);
