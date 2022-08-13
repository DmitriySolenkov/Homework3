Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num <= 99999)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;
    if (num1==num5 && num2==num4) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число НЕ является палиндромом");
}
else Console.WriteLine("Число не пятизначное!");