// Программа, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length <= 0)
{
  Console.Write("Вы ввели недопустимое значение.");
  return;
}
else
{
  int[] RandArray(int len)
  {
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < arrays.Length; i++)
    {
      arrays[i] = rnd.Next(0, 100);
      Console.Write($"{arrays[i]}  ");

    }
    return arrays;
  }
  int[] res = RandArray(length);
  void PrintArray(int[] res1)
  {
    Console.Write("-> [");
    for (int i = 0; i < res1.Length - 1; i++)
    {
      Console.Write($"{res1[i]}, ");

    }
    Console.Write($"{res1[res1.Length - 1]}]");
  }
  PrintArray(res);
}