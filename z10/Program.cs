Console.Clear();

Console.WriteLine("Введите трехзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

while (Math.Abs(a) < 100 || Math.Abs(a) >= 1000)
{Console.WriteLine("введите трехзначное число:");
a = Convert.ToInt32(Console.ReadLine());};
Console.WriteLine(Math.Abs(a % 100 / 10));