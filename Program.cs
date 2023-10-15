using System;

class Program
{
    static void Main()
    {
        double xp, xk, dx, R, x, y;
        Console.Write("Введіть xp: ");
        xp = double.Parse(Console.ReadLine());

        Console.Write("Введіть xk: ");
        xk = double.Parse(Console.ReadLine());

        Console.Write("Введіть крок dx: ");
        dx = double.Parse(Console.ReadLine());

        Console.Write("Введіть R: ");
        R = double.Parse(Console.ReadLine());

        Console.WriteLine("------------------------");
        Console.WriteLine("|    x    |      y     |");
        Console.WriteLine("------------------------");

        x = xp;
        while (x <= xk)
        {
            // розгалуження в повній формі
            if (x <= -R)
            {
                y = R;
            }
            else
            {
                if (-R < x && x <= R)
                {
                    y = R - Math.Sqrt(R * R - x * x);
                }
                else
                {
                    if (R < x && x <= 6)
                    {
                        y = R + ((-3 - R) / (6 - R)) * (x - R);
                    }
                    else
                    {
                        y = -3 + ((0 + 3) / (9 - 6)) * (x - 6);
                    }
                }
            }

            Console.WriteLine($"| {x,7} | {y,10} |");
            x += dx;
        }

        Console.WriteLine("------------------------");
    }
}