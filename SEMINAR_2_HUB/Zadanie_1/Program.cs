// Генерация случайного числа
int x = new Random().Next(10, 100);
int n = x / 10;
int m = x - (x / 10) * 10;
Console.WriteLine($"Наша переменная: {x}");
//Console.WriteLine($"Наша переменная: {n}");
//Console.WriteLine($"Наша переменная: {m}");

if (n > m) 
{
    Console.WriteLine($"Наибольшая цифра числа: {n}");
}
else 
Console.WriteLine($"Наибольшая цифра числа: {m}");