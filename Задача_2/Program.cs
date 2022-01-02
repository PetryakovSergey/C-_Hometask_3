// Сумма чисел в числе
Console.WriteLine("Введиет число: ");
int N = int.Parse(Console.ReadLine()??"0");
int Sum = 0;
while (N != 0)
{
    Sum = Sum + (N % 10);
    N = N / 10; 
}  
Console.WriteLine("Сумма цифр числа = "+ Sum);