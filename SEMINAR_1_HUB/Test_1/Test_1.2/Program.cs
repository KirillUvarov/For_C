Console.Write("Введите число 1: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b;
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        Console.WriteLine($"Наибольшее число 1:");
        Console.WriteLine(a);
        Console.WriteLine($"Наименьшее число 2:");
        Console.Write(b);
    }
else
    {
        Console.WriteLine($"Наибольшее число 2:");
        Console.WriteLine(b);
        Console.WriteLine($"Наименьшее число 1:");
        Console.WriteLine(a);
    }