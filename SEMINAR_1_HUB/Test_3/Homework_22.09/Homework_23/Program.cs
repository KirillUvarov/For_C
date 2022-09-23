// Выводим кубы всех чисел между 1 и введённым числом и 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());;

int value =3;

for (int start = 1; start <= number; start++)
{
    Console.WriteLine($"Куб числа {start} : {Math.Pow(start, value)}");
}
