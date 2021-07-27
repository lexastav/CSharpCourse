using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public static class Calculator_static
    {
        // возьмем наш класс Calculator и сделаем все методы в нем статическими
        public static bool TryDevide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        public static double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public static double Average2(params int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public static double CalcTriangleSquere(double a, double b, double c)
        {
            double perimeter = (a + b + c) / 2;
            return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));

        }
        public static double CalcTriangleSquere(double bs, double h)
        {
            return 0.5 * bs * h;
        }
        
        // немного модифицировали метод, добавив опциональный параметр isInRadians
        // только на применение опциональных параметров есть ряд ограничений:
        // 1) они всегда указываются в конце.
        // 2) они не должны быть результатами каких либо вычислений.
        // 3) если кто-то использует нашу библиотеку, а мы поменяли или ввели параметр по умолчанию, то использующиму потребуется сначала
        // у себя обновить библиотеку, а затем перекомпилировать свое приложение, иначе приложение будет использовать старое значение по умолчанию.
        public static double CalcTriangleSquere(double ab, double ac, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                double sinAlpha = Math.Sin(alpha);
                return 0.5 * ab * ac * sinAlpha;
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                double sinAlpha = Math.Sin(rads);
                return 0.5 * ab * ac * sinAlpha;
            }    
        }
      
    }
}
