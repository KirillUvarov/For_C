﻿//Console.Clear();
Console.Write("Введите трёх(или больше)-значное  число: "); // Просим оператора ввести данные
int num;
num = Convert.ToInt32(Console.ReadLine());
string numString = Convert.ToString(num);

if (num < 100 & num >= 10)
{
    Console.WriteLine("Вы ввели двузначное число . Третьего знака нет");
}

else if ( num < 10)
{
    Console.WriteLine("Вы ввели однозначное число. Второго и третьего знака нет");
}
//else if ( num >= 100)

if (numString.Length > 3) 
{
     Console.WriteLine("Третий знак слева: " + numString[2]); 
}