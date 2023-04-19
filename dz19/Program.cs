// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 10000 && number < 99999)
{
  int x1 = number % 10;
  int x2 = number / 10 % 10;
  int x3 = number / 100 % 10;
  int x4 = number / 1000 % 10;
  int x5 = number / 1000 / 10;
  int reverse = x1 * 10000 + x2 * 1000 + x3 * 100 + x4 * 10 + x5;
  if (number == reverse)
  {
    Console.WriteLine($"{number} -> yes");
  }
  else
    Console.WriteLine($"{number} -> no");
}
else
{
  Console.WriteLine("That is not five-numbered count");
};
