Console.Write("Введите цифру, соответствующую дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Weekend (int day) 
{
  if (day == 6) 
  {
  Console.WriteLine("Да");
  }
  else if (day == 7) 
  {
  Console.WriteLine("Да");
  }
  else if (day < 1)
  {
    Console.WriteLine("Нет такого дня недели");
  }
  else if (day > 7) 
  {
    Console.WriteLine("Нет такого дня недели");
  }
  else Console.WriteLine("Нет");
}

Weekend(day);
