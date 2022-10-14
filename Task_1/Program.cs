// Программа с циклом, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
double Degree(int number1, int number2)
{
  double result = 1; // Является ответом при записи чисел 0 и 0, так как пропускается блок кода "for" внутри "else".
  if (number2 < 0)
  {
    number2 = number2 * -1;
    for (int counter = 1; counter <= number2; counter++)
    {
      result = result * number1;
    }
    result = 1 / result;
  }
  else
  {
    for (int counter = 1; counter <= number2; counter++)
    {
      result = result * number1;
    };
  }
  Console.WriteLine($"Ответ: {result}");
  return result;
}
Degree(a, b);