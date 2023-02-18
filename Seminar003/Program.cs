Console.WriteLine("Введите номер задачи  ");
int i = int.Parse(Console.ReadLine());
switch (i)
{
    case 1:
    {   Task1();
        void Task1()
        {
            int x = ReadInt ("x");
            int y = ReadInt ("y");
            int quarter = GetQuarter (x, y);
            Console.WriteLine($"{quarter}: [{x} {y}]");
        }
        int GetQuarter (int x, int y)
        {
            if (x == 0 || y == 0) return -1;
            if (x > 1 && y > 1) return 1;
            if (x < -1 && y > 1) return 2;
            if (x < -1 && y < -1) return 3;
            else return 4;
        }
        int ReadInt (string argumentName)
        {
            Console.WriteLine($"Input {argumentName}");
            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("It's not a number");
            }
            return number;
        }
        break;
    }
    case 2:
    {
        Console.Write("Введите номер четверти  ");
        int с = int.Parse(Console.ReadLine());
        int[] x = {1, -1, -1, 1};
        int[] y = {1, 1, -1, -1};
        if (с == 1)
        {
            System.Console.WriteLine($" x = [{x[0]} ; + oo]; y = [{y[0]} ; + oo]");
        }
        else if (с == 2)
        {
            System.Console.WriteLine($" x = [{x[1]} ; - oo]; y = [{y[1]} ; + oo]");
        }
        else if (с == 3)
        {
            System.Console.WriteLine($" x = [{x[2]} ; - oo]; y = [{y[2]} ; - oo]");
        }
        else
        {
            System.Console.WriteLine($" x = [{x[3]} ; + oo]; y = [{y[3]} ; - oo]");
        }
        
        break;
    }
    case 3:
    {
        // Задача № 21
        Console.WriteLine("Введите координаты точки А  ");
        double x1 = int.Parse(Console.ReadLine());
        double y1 = int.Parse(Console.ReadLine());
        double z1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B  ");
        double x2 = int.Parse(Console.ReadLine());
        double y2 = int.Parse(Console.ReadLine());
        double z2 = int.Parse(Console.ReadLine());    
        double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между точками {result}");
        
        break;
    }
    case 4:
    {
        // Задача № 23
        Console.WriteLine("Введите число N  ");
        int N = int.Parse(Console.ReadLine());
        int Index = 1;
        while (Index <= N)
        {
            int a = (int)Math.Pow(Index, 3);
            Console.Write($"{a}, ");
            Index++;
        }
        break;

    }
    case 5:
    {
        // Задача 19
        Console.Write("Введите пятизначное число  ");
        int a = int.Parse(Console.ReadLine());
        if (a / 10000 % 10 == a % 10 && a / 1000 % 10 == a / 10 % 10)
            {
                Console.WriteLine($"{a} является палиндромом");
            }
        else Console.WriteLine($"{a} не является палиндромом");
        break;
    }
}