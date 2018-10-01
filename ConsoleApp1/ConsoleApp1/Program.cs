using System;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            //switch case
            char moveKey = 'Y';
            while (moveKey != 'x' && moveKey != 'X')
            {
                Console.WriteLine("W, S, A, D or X to quit: ");
                moveKey = (char)Console.ReadKey().KeyChar;

                switch (moveKey)
                {
                    case 'w':
                        Console.WriteLine("\nWe are going forward!!1");
                        break;

                    case 'a':
                        Console.WriteLine("\nLets go left now....");
                        break;

                    case 's':
                        Console.WriteLine("\nWe are moving backwards captain!!!!");
                        break;

                    case 'd':
                        Console.WriteLine("\nIts a movement to a right direction!!");
                        break;

                    default:
                        Console.WriteLine("\nIt seems like captain decided not to move this time((((");
                        break;
                }
            }



            //for
            Console.WriteLine("\n");
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " четное число");
                }
                else Console.WriteLine(i + " нечетное число");
            }




            //through string with for
            Console.WriteLine("\nEnter your string: ");
            string stringToCount = Console.ReadLine();
            int nmbrOfAs = 0;
            for (int i = 0; i < stringToCount.Length; i++)
            {
                if (stringToCount[i] == 'a' || stringToCount[i] == 'A')
                {
                    nmbrOfAs++;
                }
            }
            Console.WriteLine(nmbrOfAs + " of letter A in this string");




            //foreach
            nmbrOfAs = 0;

            foreach (char letter in stringToCount)
            {
                if (letter == 'a' || letter == 'A') nmbrOfAs++;
            }
            Console.WriteLine("\n" + nmbrOfAs + " of letter A in this string");





            //Calculator with switch
            double x, y, d;
            char znak, flag = 'y';
            while (flag == 'y' || flag == 'Y')
            {
                Console.WriteLine("\nКалькулятор: \n Введите первое число: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n(+)(-)(*)(/): ");
                znak = (char)Console.ReadKey().KeyChar;

                while (znak != '+' && znak != '-' && znak != '*' && znak != '/')
                {
                    Console.WriteLine("\nНеверный ввод!\n(+)(-)(*)(/): ");
                    znak = (char)Console.ReadKey().KeyChar;
                }
                Console.WriteLine("\nВведите воторое число: ");
                y = Convert.ToDouble(Console.ReadLine());

                switch (znak)
                {
                    case '+':
                        d = x + y;
                        break;
                    case '-':
                        d = x - y;
                        break;
                    case '*':
                        d = x * y;
                        break;
                    case '/':
                        if (y == 0)//Jada-Jada-Jada compare floating point with epsilon Jada-Jada-Jada
                        {
                            {
                                Console.WriteLine("Для этой опции требуется ненулевое значение второго числа:");
                                while (y == 0)
                                {
                                    Console.WriteLine("\nВведите ненулевое воторое число: ");
                                    y = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        }

                        d = x / y;
                        break;
                    default:
                        d = 0;
                        Console.WriteLine("Кажется что-то пошло не так)))");
                        break;
                }

                Console.WriteLine("Результат вычисления: " + d + "\nПоробовать снова? [Y/N]");
                flag = (char)Console.ReadKey().KeyChar;
            }




            //calculator with if

            flag = 'y';
            while (flag == 'y' || flag == 'Y')
            {
                Console.WriteLine("\nКалькулятор No2: \n Введите первое число: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n(+)(-)(*)(/): ");
                znak = (char)Console.ReadKey().KeyChar;

                while (znak != '+' && znak != '-' && znak != '*' && znak != '/')
                {
                    Console.WriteLine("\nНеверный ввод!\n(+)(-)(*)(/): ");
                    znak = (char)Console.ReadKey().KeyChar;
                }
                Console.WriteLine("\nВведите воторое число: ");

                y = Convert.ToDouble(Console.ReadLine());



                if (znak == '*')
                {
                    d = x * y;
                }
                else if (znak == '+')
                {
                    d = x + y;
                }
                else if (znak == '-')
                {
                    d = x - y;
                }
                else if (znak == '/')
                {
                    if (y == 0)//Jada-Jada-Jada compare floating point with epsilon Jada-Jada-Jada
                    {
                        {
                            Console.WriteLine("Для этой опции требуется ненулевое значение второго числа:");
                            while (y == 0)
                            {
                                Console.WriteLine("\nВведите ненулевое воторое число: ");
                                y = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                    }

                    d = x / y;
                }
                else
                {
                    Console.WriteLine("Something went wrong here......");
                    d = 0;
                }


                Console.WriteLine("Результат вычисления: " + d + "\nПоробовать снова? [Y/N]");
                flag = (char)Console.ReadKey().KeyChar;
            }
        }
    }
}