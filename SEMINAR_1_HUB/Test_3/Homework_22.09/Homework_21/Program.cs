Console.WriteLine("Введите координату X первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d;
d = Math.Sqrt((x2-x1)*(x2-x1) +(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//d = Math.Round(d,2); // округление до 2х символов после запятой
Console.WriteLine(d);
//Math.Pow(d,2); - возведение в степень