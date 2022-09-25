// Выводим кубы всех чисел между 1 и введённым числом 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());;

int value = 3;

for (int start = 1; start <= number; start++)
{
    Console.Write($"{Math.Pow(start, value)}, ");
}
