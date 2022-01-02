// Программа для вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
int i = 1;
int product = 1;
while (i <= N)
{
    product = product * i;
    i++;
}
Console.Write("Произведение чисел от 1 до ");
Console.Write($"{N} = " +product);
  