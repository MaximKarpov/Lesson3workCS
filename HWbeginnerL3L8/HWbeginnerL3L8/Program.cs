using System;
using System.Threading;

namespace HomeWorkBeginnerLVL
{
    class Program
    {

        public static double L3_CircleSquare(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Radius less than zero error)))");
                return 0;
            }
            else
            {
                Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(radius, 2));
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public static void L3_CreditCalc()
        {

            double percent, sum;
            do
            {
                Console.WriteLine("Введите сумму кредита! _");
                sum = Convert.ToDouble(Console.ReadLine());
            } while (sum <= 0);
            do
            {
                Console.WriteLine("Под сколько процентов берете кредит? _");
                percent = Convert.ToDouble(Console.ReadLine()) / 100;
            } while (percent <= 0);
            double Zm, finalBill = 0, monthSum = sum / 12;
            for (int i = 1; i <= 12; i++)
            {
                Zm = monthSum + sum * percent;
                sum -= monthSum;
                finalBill += Zm;
                Console.WriteLine("Платеж за " + i + "й месяц: " + Math.Round(Zm, 2));
            }
            Console.WriteLine("Полная сумма выплат по кредиту составит " + Math.Round(finalBill, 2))
;
        }

        public static void L8_RunningName()
        {
            string name = " Maxim Karpov  ";


            char[] stroka = new char[name.Length];
            for (int i = 1; i < 3000; i++)
            {
                for (int zn = 0; zn < name.Length; zn++)
                {
                    stroka[i % (stroka.Length - 1)] = name[name.Length - (zn + i) % (name.Length) - 1];
                }
                if (i % name.Length == 0)
                {
                    Array.Reverse(stroka);
                    Console.WriteLine(stroka);
                    Array.Reverse(stroka);
                    Thread.Sleep(200);
                    Console.Clear();
                }
            }
        }

        static void Main(string[] args)
        {
            L3_CircleSquare(10);
            // L3_CreditCalc();
            // L8_RunningName();
            Console.ReadKey();
        }
    }
}
