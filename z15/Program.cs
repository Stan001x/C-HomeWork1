Console.Clear();

Console.WriteLine("Введите число от 1 до 7");

int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 7)
      {Console.WriteLine("Введите число от 1 до 7");
      a = Convert.ToInt32(Console.ReadLine());};
if (a < 6)
    Console.WriteLine("рабочий день");
    else
        Console.WriteLine("Выходной день");