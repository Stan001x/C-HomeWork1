Console.Clear();

Console.WriteLine("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

while (Math.Abs(a) < 100)
{Console.WriteLine("Введите число содержащее 3 и более разрядов");
a = Convert.ToInt32(Console.ReadLine());};

while (a / 1000 > 0)
      a = a / 10;
Console.WriteLine(a % 10);