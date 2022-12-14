// Программа, которая принимает на вход пять знаков, 
// составляет из них массив из пяти элементов и провряет, является ли он полиндромом.

Console.WriteLine("Введите пятизначное число:");

int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[1 + (int)Math.Log10(x)];

for (int i = array.Length - 1; i >= 0; i--)
{
    int digit;
    x = Math.DivRem(x, 10, out digit);
    array[i] = digit;
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.Write($" Число является полиндромом");
}
else 
{
    Console.Write($" Число не является полиндромом");
}
