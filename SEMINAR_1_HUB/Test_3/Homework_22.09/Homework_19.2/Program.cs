Console.WriteLine("Введите пятизначное число:");
int num;
num = Convert.ToInt32(Console.ReadLine());
//scnd_num = 0;

if (num < 10000 || num > 100000 )
{
   Console.Write($"Ваше число {num} не являестя пятизначным");
}
while (num > 100)
{
    num = num / 10;
}
int scnd_num = num % 10;
Console.Write($"{scnd_num}");

// scnd_num = num % 10;
// Console.Write($"{scnd_num}");
// num = num / 10;
// scnd_num = num % 10;
// Console.Write($"{scnd_num}");
// num = num / 10;
// scnd_num = num % 10;
// Console.Write($"{scnd_num}");
// num = num / 10;
// scnd_num = num % 10;
// Console.Write($"{scnd_num}");
// num = num / 10;

// else if (num > 10000)
// {
//    for (int scnd_num = 0; scnd_num / 10; scnd_num++ )
//    {
//       scnd_num = num % 10;
//       Console.Write($"{scnd_num}");
      
//    }
//    //Console.Write($"Третий знак вашего числа {scnd_num}");
// }

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int num = 0;
//int[] array = new int[5];
// while (num < 10; num = 0)
//     {
//     double ostatok = num % 10;
//     Console.WriteLine(ostatok);
//     }
    //for (int i = 4;i > 0; i=i-1)
       // {
        //Console.Write($"A [{i}] = ", i);
        //array[i] = int.Parse(Console.ReadLine());
       // }
    //counter++;
//}


//Console.Write($"Массив: A[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}]");

