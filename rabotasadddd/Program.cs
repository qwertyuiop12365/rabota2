
//лаб 2.3 вариант 22 базовый уровень

//try
//{
//    Console.Write("Введите номер параметра:");
//    int x = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 1:
//            {
//                double a = 15, b = 13, c = -33;
//                if ((a < b) && (a < c))
//                    Console.WriteLine(a);
//                else if ((b < a) && (b < c))
//                    Console.WriteLine(b);
//                else Console.WriteLine(c);
//            }
//            break;
//        case 2:
//            {
//                double a = -38, b = 25, c = 12;
//                if ((a < b) && (a < c))
//                    Console.WriteLine(a);
//                else if ((b < a) && (b < c))
//                    Console.WriteLine(b);
//                else Console.WriteLine(c);
//            }
//            break;
//        case 3:
//            {
//                double a = 22, b = -1, c = -33;
//                if ((a < b) && (a < c))
//                    Console.WriteLine(a);
//                else if ((b < a) && (b < c))
//                    Console.WriteLine(b);
//                else Console.WriteLine(c);
//            }
//            break;
//         default:  break;
//    }


//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//лаб 2.3 вариант 22 среднийй уровень уровень

try
{
    Console.Write("Введите номер варианта:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double a = 0, b = 0, z = 0, y = 0;

    switch (n)
    {
        case 1:
            {
                a = 0.3; b = 0.9; z = Math.Sin(Math.Pow(x, 2));
            }
            break;
        case 2:
            {
                a = 4.3; b = 3.15; z = Math.Sin(Math.Pow(x, 3));
            }
            break;
        case 3:
            {
                a = 6.5; b = 3.5; z = Math.Pow(Math.Sin(x), 2);
            }
            break;
        default: break;
    }
    if (x < a)
    {
        y = (a + b * x + Math.Pow(Math.Sin(z * Math.Pow(x, 3.5)), 2));
    }
    else if ((a <= x) && (x <= Math.Pow(b, 2)))
    {
        y = a + Math.Log(Math.Abs(a * b - z * Math.Pow(x, 3))) + Math.Abs(x);
    }

    else if (x > Math.Pow(b, 2))
    {
        y = Math.Sqrt(Math.Abs(a + (1 / Math.Tan(z * x)))) + b*Math.Sin(x);
    }
    Console.WriteLine($"y = {y:F2}");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

