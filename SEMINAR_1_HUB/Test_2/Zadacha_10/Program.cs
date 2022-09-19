// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int x = new Random().Next(1, 10);// Генерация случайного числа
int y = new Random().Next(1, 10);
int z = new Random().Next(1, 10);
Console.Write($"Наше трёхзначное число: {x}");
Console.Write(y);
Console.WriteLine(z);
Console.Write($"Выводим вторую цифру: {y}");
