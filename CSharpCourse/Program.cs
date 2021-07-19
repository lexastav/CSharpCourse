using System;
using System.Text;
using System.Threading;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        static void HomeWork3()
        {
            Console.WriteLine("Enter your first name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string last_name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height (m):");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            string result =
                $"Your profile:\nFull Name: {last_name}, {first_name}\nAge: {age}\nWeight: {weight}\nHeight: {height}\nBody Mass Index: {bmi}";
            Console.WriteLine(result);
        }
        static void HomeWork2()
        {
            Console.WriteLine("Введите сторону A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону C");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника равна: {s}");
        }
        static void HomeWork1()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");


            Console.WriteLine("Введите первое число");
            var x = Console.ReadLine();
            var z = x;
            Console.WriteLine("Введите второк число");
            var y = Console.ReadLine();
            x = y;
            y = z;
            Console.WriteLine();
            Console.WriteLine($"Абракадабра\n{x}\n{y}");

            Console.WriteLine("Введите число");
            string num = Console.ReadLine();
            Console.WriteLine($"Количество цифр в веденном числе: {num.Length}");
        }
        static void IntroDateTime()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date} {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDT = dt.AddDays(1);
            Console.WriteLine(newDT);

            TimeSpan ts = now - dt;
            //ts = now.Subtract(dt); То же самое, что и выше
            Console.WriteLine(ts.Days);
        }
        static void IntroToArray()
        {
            int[] a1; //инициализировали массив состоящий из данных типа int
            a1 = new int[10]; //выделили память для массива, то есть 10 элементов, то есть 40 байт

            int[] a2 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a3 = { 1, 3, 2, 4, 5 };

            Console.WriteLine(a2[3]);

            int numb = a3[2];
            Console.WriteLine(numb);

            a3[4] = 6;
            Console.WriteLine(a3[4]);

            Console.WriteLine(a3.Length);
            Console.WriteLine(a3[a3.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"First - {first}. Last - {last}");
        }          
        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));

            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // округление к числу удаленному от нуля
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // округление к ближайшему четному, это и используется по умолчанию
        }
        static void Comments()
        {
            // a single-line commet

            /*
             * Multi-line comment
             * 
             * 
             */
        }
        static void CastingAndParsing()
        {
            byte b = 3; // 0000 0011
            int i = b; //0000 0000 0000 0000 0000 0000 0000 0011 так как int шире
            long l = i; //0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011 а Long еще шире

            float f = i; //это фактически 3.0, но консоль покажет 3

            Console.WriteLine(l);
            b = (byte)i; //яное приведение
            Console.WriteLine(b);

            i = (int)f;
            Console.WriteLine(i);

            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            //i = (int)str; вот так работать не будет, так как типы не переводимые
            // а вот сконвертировать можно
            i = int.Parse(str);
            Console.WriteLine(i);

            int x = 5;
            int result = x / 2; //так мы получим целочисленное деление
            Console.WriteLine(result);

            double result2 = (double)x / 2; // а так получится вещественное число, можно использовать float и тд
            Console.WriteLine(result2);
        }
        static void ConsoleBasics()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Hi, please tell me your name");

            string name = Console.ReadLine();
            string sentence = $"Nice to meet you {name}! And I'm VD-2-967/4, but you can call me Vitya!";
            Console.WriteLine(sentence);
            Console.WriteLine("Please tell me your age ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            sentence = $"Yor age is {age}";
            Console.WriteLine(sentence);

            Console.Clear();
        }
        static void ComparingStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            // то же самое
            areEqual = string.Equals(str1, str2, StringComparison.Ordinal); //на самом деле есть несколько режимов сравнения
            Console.WriteLine(areEqual);
            Console.WriteLine();


            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            string str3 = "Strasse";
            string str4 = "Straße";

            // более продвинутые настройки сравнения, которые используются гораздо реже, но он них нужно знать

            areEqual = string.Equals(str3, str4, StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str3, str4, StringComparison.InvariantCulture); //должно быть true, но какая-то проблема с кодировкой
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str3, str4, StringComparison.CurrentCulture); //должно быть true, но какая-то проблема с кодировкой
            Console.WriteLine(areEqual);
        }
        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}";

            string str3 = "My name is \nJohn";
            str3 = $"My name is {Environment.NewLine}John"; //кросс-платформенный вариант перевода на новую строку

            string str4 = "I'm \t30";

            string str5 = "I'm John and I'm a \"good\" programmer";

            string str6 = @"C:\tmp\test_file.txt"; // тоже самое "C:\\tmp\\test_file.txt"

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer); //если надо дополнить число нолями слева

            string result3 = string.Format("{0:f}", answer); // если нужно в формат вещественного числа, добавится 2 знака после запятой
            string result4 = string.Format("{0:f4}", answer); // если нужно добавить нолей после запятой

            double answer2 = 42.321;
            string result5 = string.Format("{0:f}", answer2);
            string result6 = string.Format("{0:f4}", answer2);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;

            string result7 = string.Format("{0:C}", money);
            string result8 = string.Format("{0:C2}", money);

            // не обязательно использовать Format, все проделанное выше можно реализовать с помощью ToString.
            // Например: string result = money.ToString("C2"); Или с использование интерполирования: string result8 = $"{money:C2}";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);

            Console.WriteLine(result7);
            Console.WriteLine(result8);
        }
        static void StringBuilderDemo()
        {
            var sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");


            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModifications()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John.");
            Console.WriteLine(nameConcat);

            //тоже самое, что и: nameConcat = "My " + "name " + "is " + "John.", отличие только в производительности

            string yearsOldConcat = string.Join(" ", "Im", "18", "years", "old.");
            Console.WriteLine(yearsOldConcat);

            //с Join тоже можно кокатенироваться, но его возмоности несколько шире, так как есть параметр- разделитель,
            //а разделителем можно указать все что угодно.


            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 12);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);

            string lower = nameConcat.ToLower();
            string upper = nameConcat.ToUpper();
            Console.WriteLine(lower);
            Console.WriteLine(upper);

            string john = "     My name is John    ";
            Console.WriteLine(john.Trim());
        }
        static void StringEmptiness()
        {
            var str = string.Empty;
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
