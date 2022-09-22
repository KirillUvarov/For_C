//Принимает число n и выводит все чётные от единицы до n
Console.Write("Введите число: ");
int number; 
number = Convert.ToInt32(Console.ReadLine());
int a = 2;

    while (a <= number)
    {
    Console.Write(a);
    Console.Write($", ");
    a+=2;
    }

/*
// Выводит все чётные числа от 1 до n.
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
   if (i % 2 == 0)
   {
    Console.Write($"{i} "); 
    
   }
   i++;
}
*/