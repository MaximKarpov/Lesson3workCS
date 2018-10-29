using System;

namespace lesson9DZ
{

    public class DateTimeExtension
    {
        public void Deconstruct(out int year, out int month, out int day, out int hour, out int minuit, out int sec)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hour = DateTime.Now.Hour;
            minuit = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
        }
    }

    class Program
    {
       
        public struct Coordinate
        {
            public double x, y, z;
     
            public void Deconstruct(out double x, out double y, out double z, out double vect)
            {
                x = this.x;
                y = this.y;
                z = this.z;
                vect = Math.Round(Math.Pow((x * x + y * y + z * z), 0.5), 3);
                //Да, это было очень просто, но я тупил как всегда...
            }
        }



      
        static void Main(string[] args)
        {
            Coordinate V = new Coordinate();
            V.x = 40; V.y = 30; V.z = 0;
            var (x, y, z, vect) = V;
            Console.WriteLine("V = (" + x + "; " + y + "; " + z + ");" );
            Console.WriteLine("Длина вектора = " + vect);
            DateTimeExtension Now = new DateTimeExtension();
            var (_, _, _, hour, min, sec) = Now;
            Console.WriteLine("Время сейчас: " + hour + ":" + min + ":" + sec);
            Console.ReadKey();    
        }
    }
}
