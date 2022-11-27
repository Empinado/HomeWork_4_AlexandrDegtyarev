// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
string A = Console.ReadLine();
int C = int.Parse(A);
char[] B = A.ToCharArray();
int sum = 0;

if (C > 0)
{
    for (int i = 0; i < B.Length; i++)
    {
        sum = sum + B[i] - 48;
        Console.WriteLine(B[i]);
    }
}
else if(C<0)
{
    for (int i = 1; i < B.Length; i++)
    {
        sum = sum + B[i] - 48;
        Console.WriteLine(B[i]);
    }
}
Console.WriteLine(sum);

