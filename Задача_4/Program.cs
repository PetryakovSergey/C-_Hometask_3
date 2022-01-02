// Показать кубы чисел (от 1 до N), заканчивающихся на четную цифру
Console.WriteLine("Введите число N "); 
int N = int.Parse(Console.ReadLine()??"0");
int i = 1;
int result = 0;
while (i <= N)
{
    // Забыл, что куб нечетного числа не может в результате дать четное число, поэтому программа усложнилась))
    result = i * i * i;
    int remain = result % 10;
    if (remain % 2 == 0)
    {
        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
    }
    i++;
}
