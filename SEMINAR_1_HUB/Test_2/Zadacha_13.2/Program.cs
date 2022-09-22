Console.Write("Введите трёх(или больше)-значное  число: "); // Просим оператора ввести данные
int num;
num = Convert.ToInt32(Console.ReadLine());
int scnd_num = 0;

if (num < 100)
{
   Console.Write($"Ваше число {num} не являестя трёхзначным");
}

else if (num > 100)
{
   while (num < 10)
   {
      scnd_num = num % 10;
   }
   Console.Write($"Третий знак вашего числа { scnd_num }");
}

/*else if ( num > 999)
{
   while (num >= 100)
   {
      num = num / 10;
   }

}
Console.Write($"Третий знак вашего числа {num}");


if (num >= 100 && num <= 1000)
{

}
{
  while (num < 1000)
   {
   num = num / 10;
   Console.WriteLine(num);
   }
  
}
else
{
   Console.Write($"Ваше число {num} не являестя трёхзначным");
}
/*/




/*/



while (num <= 100)
{
   num = num % 10;
   //index++;
}

Console.WriteLine(num);/*/
