using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            double radius;
            double pi = Math.PI;
            double S;
            Console.WriteLine("Введите радиус круга: ");
            radius = Convert.ToDouble(Console.ReadLine());
            S = radius * radius * pi;
            Console.WriteLine("Площадь круга: " + S);



            //Задание 2
            int summaKredita, procenti, deltaSummi = 0;
            Console.WriteLine("Введите сумму кредита: ");
            summaKredita = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент: ");
            procenti = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=12; i++)
            {
           
                deltaSummi = ((summaKredita - deltaSummi) * procenti)/100;
                Console.WriteLine("Сумма выплаты за " + i + "й месяц: " + deltaSummi + "\n");
              
                summaKredita -= deltaSummi;
                Console.WriteLine("Остаток суммы" + summaKredita);
            }
            Console.Read();
        }
    }
}
