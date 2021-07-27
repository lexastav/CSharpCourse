using System;

namespace D_OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            // поведение при копировании в случае структур и классов
            PointVal a;
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");

            PointRef c = new PointRef();
            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            c.LogValues();
            d.LogValues();


            double result2 = Calculator_static.Average2(1, 2, 3);


            Calculator calc3 = new Calculator();
            if(calc3.TryDevide(10, 0, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }

            Console.WriteLine();

            Character ch = new Character();
            Console.WriteLine(ch.Health);
            ch.Hit(20);
            Console.WriteLine(ch.Health);

            Console.WriteLine();

            Calculator calc = new Calculator();
            double squere2 = calc.CalcTriangleSquere(10, 20); // вызывается второй метод
            double squere1 = calc.CalcTriangleSquere(5, 5, 5); // вызывается первый метод 
            Console.WriteLine($"Squere1={squere1} Squere2={squere2}");


            Console.WriteLine();

            Console.WriteLine(ParserRomeNumbers.Parse("XIX"));

            Console.WriteLine();
            Calculator calc1 = new Calculator();
            double avg = calc1.Average(new int[] { 1, 2, 3, 4 });
            //или с params
            double avg1 = calc1.Average2(1, 2, 3, 4);
            Console.WriteLine(avg);
            Console.WriteLine();
            double sq = calc1.CalcTriangleSquere(ab: 10, ac: 20, alpha: 30);





        }
    }
}

