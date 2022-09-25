// Программа, которая принимает на вход пятизначное число иопределяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число:");
int num;
num = Convert.ToInt32(Console.ReadLine());

int d = num % 10;
int c = num / 10 % 10;
int b = num / 1000 % 10;
int a = num / 10000 % 10;

if (a == d || b == c)
{
    Console.Write($" Число является полиндромом");
}
else Console.Write($" Число не является полиндромом");
