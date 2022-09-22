Console.WriteLine("Введите четверть (1-4): ");
int n = Convert.ToInt32(Console.ReadLine());
//int X = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else if (n == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else if (n == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else 
{
    Console.WriteLine("X>0, Y<0");
}