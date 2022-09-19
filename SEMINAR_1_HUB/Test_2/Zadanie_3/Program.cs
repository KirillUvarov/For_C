Console.Write("Введите возраст: "); // Просим оператора ввести данные
int num; //Определяем переменную num
num = Convert.ToInt32(Console.ReadLine()); //Говорим, что num надо конвертировать в название типа простого числа в библиотеке .NET   
/*/до 13 включительно – детство;
	от 14 до 24 – молодость;
	от 25 до 59 – зрелость;

от 60 – старость.
*/

    if (num <= 13)//Ветвление
    {
         Console.WriteLine("Детство");
    }
        
    else if (num <= 24)
    {
         Console.WriteLine("Молодость");
    }
     else if (num <= 59)
    {
         Console.WriteLine("Зрелость");
    }    
     else if (num >= 60)
    {
         Console.WriteLine("Cтарость");
    }
     