Console.WriteLine("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x1x2 = Math.Abs(x1-x2);
int y1y2 = Math.Abs(y1-y2);
double x1y2 = Math.Sqrt(Math.Pow(x1x2,2)+Math.Pow(y1y2,2));
int z1z2 = Math.Abs(z1-z2);
double x1z2 = Math.Sqrt(Math.Pow(x1y2,2)+Math.Pow(z1z2,2));

Console.WriteLine($"Расстояние в 3D-пространстве равно: {x1z2:f2}");