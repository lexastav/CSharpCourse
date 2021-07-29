using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // а вот с полиморфизмом несколько посложнее, в обычном наследовании нас никто не заставляет переопределять методы,
    // мы можем использовать в наследниках как базовые, так и свои, так и совмещать. Однако при полиморфизме мы обязаны переопределять.
    // Все дело в том, что в основе полиморфизма лежит некоторый абстрактный класс, который по сути является скилетом,
    // как правило он содержит абстрактные методы, которые мы должны переопределить в наследниках. В Main подробнее для чего это нужно.
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();

    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Created");
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle Created");
        }
        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }
}
