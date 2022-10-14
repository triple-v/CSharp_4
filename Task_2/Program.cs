// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите целое положительное число:");
int num = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int number)
{
  int sum = 0;
  if (number <= 0)
  {
    Console.WriteLine($"Введите число больше нуля");
  }
  else
  {
    while (number > 0)
    {
      sum += number % 10;
      number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в числе равна: {sum}");
  }
  return sum;
}
SumNumbers(num);