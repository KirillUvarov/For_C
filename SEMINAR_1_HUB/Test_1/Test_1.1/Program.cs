Console.Write("Введите число: "); // Просим оператора ввести данные
int num; //Определяем переменную num
num = Convert.ToInt32(Console.ReadLine()); //Говорим, что num надо конвертировать в название типа простого числа в библиотеке .NET   

    if (num == 1)//Ветвление
    {
         Console.WriteLine($"Понедельник");
    }
        
    if (num == 2)
    {
         Console.WriteLine($"Вторник");
    }
     if (num == 3)
    {
         Console.WriteLine($"Среда");
    }    
     if (num == 4)
    {
         Console.WriteLine($"Четверг");
    }
     if (num == 5)
    {
         Console.WriteLine($"Пятница");
    }
     if (num == 6)
    {
         Console.WriteLine($"Суббота");
    }
     if (num == 7)
    {
         Console.WriteLine($"Воскресение");
    }
      if (num > 7)
    {
         Console.WriteLine($"Такого дня нет");
    }