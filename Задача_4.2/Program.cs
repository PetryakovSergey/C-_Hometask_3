// Показать кубы чисел (от 1 до N), заканчивающихся на четную цифру
Console.WriteLine("Введите число N "); 
int N = int.Parse(Console.ReadLine()??"0");
int i = 1;
while (i <= N)
{
    if (i % 2 == 0) 
    {
        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
    }
    i++;
}
