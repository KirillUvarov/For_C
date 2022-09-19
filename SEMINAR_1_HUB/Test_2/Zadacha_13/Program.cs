Console.Write("Введите трёхзначное число: "); // Просим оператора ввести данные
int num;
num = Convert.ToInt32(Console.ReadLine());

if (num < 100 & num >= 10)
{
    Console.WriteLine("Число двузначное. Третьей цифры нет");
}

else if ( num < 10)
{
    Console.WriteLine("Число однозначное. Второй и третьей цифры нет");
}

