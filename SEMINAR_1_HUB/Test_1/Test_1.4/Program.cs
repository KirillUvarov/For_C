Console.Write("Введите число: ");
int a; 
a = Convert.ToInt32(Console.ReadLine());
int b;
b = (a % 2);

if (b==0)
    {
        Console.WriteLine($"Да");
    }
else
{
    Console.WriteLine($"Нет");
}
