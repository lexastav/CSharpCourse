using System;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
        static void HomeworkAuth()
        {
            string login = "johnsilver";
            string password = "qwerty";
            string inputLogin = string.Empty;
            string inputPassword = string.Empty;
            int count = 0;


            while (count <= 4)
            {
                Console.Write("Enter Login: ");
                inputLogin = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter Password: ");
                inputPassword = Console.ReadLine();
                count++;
                if (count <= 3)
                {
                    if (inputLogin == login && inputPassword == password)
                    {
                        Console.WriteLine("Enter the System");
                        break;
                    }
                    else if (inputLogin != login || inputPassword != password)
                    {
                        Console.WriteLine($"Попыток осталось: {3 - count}");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("The number of available tries have been exceeded");
                    break;
                }

            }
        }
        static void HomeworkFactorial()
        {
            int num = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        static void HomeworkAverage()
        {
            int numb;
            int count = 0;
            double total = 0;
            int countOfMultiplesOfThree = 0;
            double average;
            for (int i = 0; count < 10; i++)
            {
                numb = int.Parse(Console.ReadLine());
                count++;
                if (numb != 0)
                {
                    if (numb % 3 == 0 && numb > 0)
                    {
                        total += numb;
                        countOfMultiplesOfThree++;
                    }
                }
                else
                {
                    break;
                }
            }
            average = total / countOfMultiplesOfThree;
            Console.WriteLine(average);
        }
        static void HomeworkFibonacci()
        {
            Console.WriteLine("сколько чисел Фибоначчи Вы хотите сгенерировать");
            int countFib = int.Parse(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;
            int[] lstFib = new int[countFib];
            lstFib[0] = fib1;
            lstFib[1] = fib2;


            for (int i = 2; i < countFib; i++)
            {
                int fib = fib1 + fib2;
                lstFib[i] = fib;

                fib1 = fib2;
                fib2 = fib;
            }

            foreach (int f in lstFib)
            {
                Console.Write(f + " ");
            }
        }
        static void Debuging()
        {
            Console.WriteLine("Введите сторону A");
            double a = GetDouble();
            Console.WriteLine("Введите сторону B");
            double b = GetDouble();
            Console.WriteLine("Введите сторону C");
            double c = GetDouble();

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника равна: {s}");
        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        static void SwichCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("There is no such month");


            }
            Console.WriteLine(season);



            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;

                case 10:
                    name = "Оловянная свадьба";
                    break;

                case 15:
                    name = "Хрустальная свадьба";
                    break;

                case 20:
                    name = "Фарфоровая свадьба";
                    break;

                case 25:
                    name = "Серебренная свадьба";
                    break;

                case 30:
                    name = "Жемчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея";
                    break;
            }
            Console.WriteLine(name);
        }
        static void BreakContinue()
        {
            int[] numbers2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int n in numbers2)
            {
                if (n % 2 != 0)
                {
                    continue;
                }
                Console.Write(n + " ");
            }


            Console.WriteLine();

            int[] numbers1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"Number={numbers1[i]}");

                for (int j = 0; j < numbers1.Length; j++)
                {
                    if (numbers1[i] == j)
                    {
                        break;
                    }
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                {
                    break;
                }

                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI} ; {atJ}). Indexes ({i} ; {j})");
                        counter++;

                    }

                    if (counter == 3)
                    {
                        break;
                    }

                }
            }
        }
        static void WhileDoWhile()
        {
            int age = 30;
            while (age < 18)
            {
                Console.WriteLine("First while loop");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            //Но может сложиться такая ситуация, что изночально условие соблюдено, но нам нужно все равно попасть в цикл
            //Для этого нам поможет do while
            do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);


            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }
        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI} ; {atJ}). Indexes ({i} ; {j})");
                    }

                }
            }

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI} ; {atJ} ; {atK}). Indexes ({i} ; {j} ; {k})");
                        }
                    }


                }
            }
        }
        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }

            }
            Console.WriteLine();

            //если нам не нужен итератор и поиндексный доступ, можем воспользоваться циклом foreach, нообратный вывод не возможен
            foreach (int val in numbers)
            {
                Console.Write(val + " ");
            }
        }
        static void Homework4()
        {
            Console.WriteLine("Введите первое число");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int num2 = int.Parse(Console.ReadLine());

            string maxNum = num1 >= num2 ? $"Максимальное чило {num1}" : $"Максимальное чило {num2}";
            Console.WriteLine(maxNum);

            //int max = num1;
            //if(num2 > num1)
            //{
            //    max = num2;
            //}

            //int max;
            //if(num1 > num2)
            //{
            //    max = num1;
            //}
            //else
            //{
            //    max = num2;
            //}
        }
        static void IfElse()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height (m):");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            bool isTooLow = bmi <= 18.5;
            bool isNormal = bmi > 18.5 && bmi < 25;
            bool isAboveNormal = bmi >= 25 && bmi <= 30;
            bool isTooFat = bmi > 30;

            bool isFat = isAboveNormal || isTooFat;

            // if (isFat == true);
            if (isFat)
            {
                Console.WriteLine("You'd better lose some weight.");
            }
            else
            {
                Console.WriteLine("Oh, you're in a good shape.");
            }

            // if (isFat != true);
            if (!isFat)
            {
                Console.WriteLine("You're definitely not fat!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("You're ok!!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight.");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it's time to get on diet");
            }
            // тернарное выражение
            string description = age > 18 ? "You czn drink alcohol" : "You should get a bit older!";
            Console.WriteLine(description);
        }
    }
}
