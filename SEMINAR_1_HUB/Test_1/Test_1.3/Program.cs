Console.Write("Введите число 1: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b;
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c;
c = Convert.ToInt32(Console.ReadLine());

maxNum = 0;

if (a>b)
    {
        maxNum=a;
    }
else
    {
        maxNum=b;
    }
Console.WriteLine(maxNum);