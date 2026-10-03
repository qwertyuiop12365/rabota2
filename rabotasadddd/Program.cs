//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    Console.WriteLine((
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите номер дня недели:");
//    int x = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 1:
//            Console.WriteLine("Понедельник");
//            break;
//        case 2:
//            Console.WriteLine("Vtornik");
//            break;
//        case 3:
//            Console.WriteLine("Sreda");
//            break;
//        case 4:
//            Console.WriteLine("Chetverg");
//            break;
//        case 5:
//            Console.WriteLine("Pyatnica");
//            break;
//        case 6:
//            Console.WriteLine("Sybbota");
//            break;
//        case 7:
//            Console.WriteLine("Voskresenye");
//            break;
//        default:
//            Console.WriteLine("Net takogo dnya nedeli");
//            break;

//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите номер месяца:");
//    int x = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 12:
//        case 1:
//        case 2:
//            Console.WriteLine("зима");
//            break;
//        case 3:
//        case 4:
//        case 5:
//            Console.WriteLine("весна");
//            break;
//        case 6:
//        case 7:
//        case 8:
//            Console.WriteLine("лето");
//            break;
//        case 9:
//        case 10:
//        case 11:
//            Console.WriteLine("осень");
//            break;
//        default:
//            Console.WriteLine("нет такого месяца");
//            break;

//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите номер карты:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите номер масти:");
//    int y = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 6:
//        case 7:
//        case 8:
//        case 9:
//        case 10:
//            Console.WriteLine(x);
//            break;
//        case 11:
//            Console.WriteLine("Валет");
//            break;
//        case 12:
//            Console.WriteLine("Дама");
//            break;
//        case 13:
//            Console.WriteLine("Король");
//            break;
//        case 14:
//            Console.WriteLine("Туз");
//            break;
//        default:
//            Console.WriteLine("нет такой карты");
//            break;

//    }
//    switch (y)
//    {
//        case 1:
//            Console.WriteLine("Бубны");
//            break;
//        case 2:
//            Console.WriteLine("Крести");
//            break;
//        case 3:
//            Console.WriteLine("Пики");
//            break;
//        case 4:
//            Console.WriteLine("Черви");
//            break;
//        default:
//            Console.WriteLine("нет такой масти");
//            break;
//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите сколько рублей:");
//    int x = int.Parse(Console.ReadLine());
//    int y = x % 10;
//    if (x % 100 >= 11 && x <= 14) Console.WriteLine($"{x} рублей");
//    else
//    {
//        switch (y)
//        {
//            case 1:
//                Console.WriteLine($"{x} рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine($"{x} рубля");
//                break;

//            default:
//                Console.WriteLine($"{x} рублей");
//                break;

//        }
//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



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

