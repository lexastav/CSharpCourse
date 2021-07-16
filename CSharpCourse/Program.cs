using System;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
        static void StringEmptiness()
        {
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");

            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);
        }
        static void QueryingStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfA = name.LastIndexOf('a');
            Console.WriteLine(lastIndexOfA);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFromTo);
        }
        static void StaticAndInstanceMembers()
        {
            string name = "abracadabra";
            // var name = new string("abracadabra");
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('e');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat('a', 'b', "drew"); // метод Concat может принимать как char так и string

            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }
        static void ComparisonOperators()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            //все операторы точно такие же как в Python
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;

            Console.WriteLine(b);
            Console.WriteLine(c);

            a = 4 % 2;
            b = 5 % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a * a; //a в степени 3
            Console.WriteLine(a);
        }
        static void IncrementDecrementDemo()
        {
            int x = 1;
            x++; //postfix increments
            ++x; //infix increments

            Console.WriteLine(x);

            x--; //postfix increments
            --x; //infix increments

            Console.WriteLine(x);

            x += 2; //x = x + 2
            x -= 2; //x = x - 2
        }
        static void Overflow()
        {
            uint x = uint.MaxValue;

            Console.WriteLine(x);

            x = x + 1;

            Console.WriteLine(x);

            x = x - 1;

            Console.WriteLine(x);

        }
        static void VariableScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
        }
    }
}
