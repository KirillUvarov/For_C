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
