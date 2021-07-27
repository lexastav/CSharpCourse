using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    class Calculator
    {
        // продолжение темы про защиту от дурака, создадим метод аналогичный TryParse
        public bool TryDevide(double divisible, double divisor, out double result) 
            // out параметр всегда последним указывается, причем он может быть не один.
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        
        public double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        // тоже самое но с ключевым словом params, оно позволяет более простой вызов метода, см класс Program.
        // Только необходимо учесть, что модификатор  params нужно указывать последним в случае передачи множества аргументов разных типов.
        public double Average2(params int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        // мы можем создавть перегруженные методы, это те методы у которых одинаковые названия, но разные сигнатуры
        // например метод нахожождения площади треугольника разными способами
        public double CalcTriangleSquere(double a, double b, double c)
        {
            double perimeter = (a + b + c) / 2;
            return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
           
        }
        public double CalcTriangleSquere(double bs, double h)
        {
            return 0.5 * bs * h;
        }
        public double CalcTriangleSquere(double ab, double ac, int alpha)
        {
            double rads = alpha * Math.PI / 180;
            double sinAlpha = Math.Sin(rads);
            return 0.5 * ab * ac * sinAlpha;
        }
    }

    // то есть если мы вызовем CalcTriangleSquere передав ему 3 аргумента, вызовется первый метод, а если 2, то второй
}
 