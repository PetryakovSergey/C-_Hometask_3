// Составить таблицу для куба числа
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine()??"0");
for (int i = 0; i <= N; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
}