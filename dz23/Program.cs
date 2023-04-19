// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Enter count ");
int x = Convert.ToInt32(Console.ReadLine());
int run = 1;
while (run <= x)
{
  Console.Write(Math.Pow(run,3));
  Console.Write(", ");
  run++;
}