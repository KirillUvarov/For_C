// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру. 456 -> 46 или 782 -> 72


int x = new Random().Next(1, 10);// Генерация случайного числа
int y = new Random().Next(1, 10);
int z = new Random().Next(1, 10);
Console.Write($"Наше трёхзначное число: {x}");
Console.Write(y);
Console.WriteLine(z);
Console.Write($"Выводим первое и третье: {x}");
Console.Write(z);
