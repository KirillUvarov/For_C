// Напишите программу, которая принимает на вход пятизначноное число и провряет, является ли оно полиндромом.
//Console.WriteLine("Введите пять чисел пятизначного числа");
// int[] array;
// array = new int[5];
// array[0] = Convert.ToInt32(Console.ReadLine());
// array[1] = Convert.ToInt32(Console.ReadLine());
// array[2] = Convert.ToInt32(Console.ReadLine());
// array[3] = Convert.ToInt32(Console.ReadLine());
// array[4] = Convert.ToInt32(Console.ReadLine());

int[] array;
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("A [{0}] = ", i);
    array[i] = int.Parse(Console.ReadLine());
}
while (int elem in array) 
{
    Console.Write($"{0}", elem);
}




// int[] array = {11, 211, 61, 31, 41, 15, 61, 17, 18 };

// int n = array.Length;
// int find = 61;

// int index = 0;

// while (index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index); // Выводит индекс числа, которое указано в find
//         break; // Если в массиве два одинаковых элемента, то выведет только индекс первого элемента
//     }
//     index++; // index += 1 или index = index + 1
// }