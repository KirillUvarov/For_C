Console.Clear();

//int i = 1;
int[] array = {1, 2, 3, 4}; 

Console.WriteLine($"Выводим элемент массива: {array[array.Length-1]}");

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * 2;
    Console.WriteLine($"Выводим элемент массива: {array[i]}");
}


