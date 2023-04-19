// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите X первой точки ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки ");
int Z2 = Convert.ToInt32(Console.ReadLine());
// Я усложняю переменными, потому что сходу решить не получилось
double pow1 = Math.Pow((X2 - X1),2);
double pow2 = Math.Pow((Y2 - Y1),2);
double pow3 = Math.Pow((Z2 - Z1),2);
double sum = pow1 + pow2 + pow3;
double sqrt = Math.Sqrt(sum);
double round = Math.Round((sqrt),2);
Console.WriteLine($"Расстояние между точками в 3-d пространстве равно {round}");
