//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int[] Array = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine();

for(int i = 0; i < Array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.Write("["+string.Join(",",Array)+"]");