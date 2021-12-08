using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте градусы");
            inputGrad(out int grad);
            Console.WriteLine("Задайте минуты");
            inputMin(out int min);
            Console.WriteLine("Задайте секунды");
            inputSec(out int sec);
            Angle angle = new Angle(grad, min, sec);
            angle.ToRadians(grad, min, sec, out double radian);
            Console.WriteLine("угол {0} градусов {1} минут и {2} секунд равен {3} радиан", grad, sec, min, radian);


            Console.ReadKey();
        }
        static void inputGrad(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 359) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                inputGrad(out number);
            }
        }//задаем разрешенный диапазон градусов
        static void inputMin(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 59) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                inputMin(out number);
            }
        }//задаем разрешенный диапазон минут
        static void inputSec(out int number)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 59) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных! ВВедите значение заново");
                inputSec(out number);
            }
        }//задаем разрешенный диапазон секунд

    }
    class Angle
    {
        int gradus { get; set; }
        int min { get; set; }
        int sec { get; set; }
        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public void ToRadians(int gradus, int min, int sec, out double radian)
        {
            radian = Math.PI / 180 * (Convert.ToDouble(gradus) + (Convert.ToDouble(min) / 60) + (Convert.ToDouble(sec) / 3600));
        }
    }

}
