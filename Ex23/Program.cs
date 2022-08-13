Console.WriteLine("Введите число, отличное от 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (N > 0)
{
    while (count < N)
    {
        count++;
        Console.Write(Math.Pow(count, 3) + ", ");
    }
}
else
{
   if (N < 0)
{
    while (count > N)
    {
        count= count-1;
        Console.Write(Math.Pow(count, 3) + ", ");
    }
} 
else Console.WriteLine("Число некорректно!");
}