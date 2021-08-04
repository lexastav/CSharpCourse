using System;
using System.Collections.Generic;
using System.Linq;

namespace D_OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            var ms = new IEnumerableMyStack2<int>();
            ms.Push(2);
            ms.Push(3);
            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            
            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
            // все работает


        }
        static void IEnumerableMyStackDemo()
        {
            // а вот тут мы теперь обязаны передать тип
            var ms = new IEnumerableMyStack<int>();
            ms.Push(2);
            ms.Push(3);
            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            // вот с помощью модификации с использование IEnumerable мы можем теперь юзать foreach
            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
            // это эквивалентно следующему:
            var enumerator = ms.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            // вот это вот еще один пример крутости интерфейсов. То есть мы с помощью интерфейса заключили так сказать контракт
            // с конструкцией foreach, по которому мы как бы сказали: "Вот смотри, по нашему стеку тоже можно итерироваться", а foreach
            // такой: "О да я вижу, что ты реализовал IEnumerable, я буду с тодой работать"

            // однако есть еще более простой способ реализации IEnumerable, который в большинстве случаев то же будет работать

        }
        static void GeneralizedMyStackDemo()
        {
            // а вот тут мы теперь обязаны передать тип
            var ms = new GeneralizedMyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());

            Console.ReadLine();

            // и положить в него всякую дичь теперь нельзя, если мы указали тип int то там может быть только этот тип.
            // Компилятор нам это подсветит, так как управление типом происходит в копайл тайме. вот за этим и нужны дженерики.

            //ms.Push("abraaa");
            //ms.Push(false);

            ms.Push('a'); // а это можно положить, так как char- это структура, и стэк конвертирует его в целочисленную репрезентацию,
                          // но в реальной практике такое не надо передавать 
                          //ms.Push(0.2);
                          //ms.Push(new Character(Race.Elf));

            while (ms.Count != 0)
            {
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }
            // Но в этом стэке есть еще проблемка. Дело в том, что пройтись по стэку с помощью foreach мы не можем, выскочит исключение
            // исправить эту недоработку можно несколькими способами, самый простой- с помощью интерфейса iEnumerable
        }
        static void MyStackDemo()
        {
            MyStack ms = new MyStack();
            ms.Push(1);
            ms.Push(2);
            ms.Push(3);

            Console.WriteLine(ms.Peek());

            ms.Pop();

            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);

            Console.WriteLine(ms.Peek());

            Console.ReadLine();

            // ну а теперь самая проблема objectoв

            ms.Push("abraaa");
            ms.Push(false);
            ms.Push('a');
            ms.Push(0.2);
            ms.Push(new Character(Race.Elf));

            // то есть мы можем напихать туда абсолютно всего (прям как в пайтон). И это может произойти совершенно непреднамеренно.
            // а вот если нам нужно с данными поработать, например так:
            while (ms.Count != 0)
            {
                Console.WriteLine((int)ms.Peek());
                ms.Pop();
            }
            // все нормально вроде, компилятор не ругается, однако в рантайме вывалится InvalidCastException
            // и вот именно эту проблему решают обобщения. То есть строгая типизация.
        }
        static void RepresenativeProblemDemo()
        {
            Rect rect = new Rect { Height = 2, Width = 5 };
            int rectArea = AreaCalculator.CalcSquare(rect);
            Console.WriteLine($"Rect area = {rectArea}");

            // хоба вот и проблема представителя
            Rect square = new Square { Height = 2, Width = 10 };
        }
        static void ExtansionMethodsDemo()
        {
            IBaseCollection collection = new BaseList(4);
            collection.Add(1);

            List<object> list = new List<object>() { 1, 2, 3 };
            collection.AddRange(list);
        }
        static void PolymorphismDemo()
        {
            // мы не можем созать просто экземпляр Shape, но мы можем создать массив shapes например из 2х элементов
            Shape[] shapes = new Shape[2];
            // создадим 2 фигуры
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);

            // а теперь поработаем с созданными фигурами
            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());

            }

            // вот в этом и есть вся фишка полиморфизма, то есть мы можем создать где-либо какой нибудь метотд, передав в него в нашем случае
            // просто shape и не важно что там, Triangle или Rectangle, он проведет с ним какую либо работу. То есть мы работаем с базовым классом
            // полиморфно.
            // static void Do(Shape shape) 
            // {
            // }
        }
        static void InheritenceDemo()
        {
            ModelXTerminal terminal = new ModelXTerminal("1234");
            terminal.Connect();
        }
        static void BoxingUnboxing()
        {
            int x = 1;
            // boxing
            object obj = x; // здесь происходит следующее: object оборачивает значение х, как бы переносит значение в кучу, а obj- это
                            // ссылка на значение 

            // unboxing
            int y = (int)obj;

            // однако с боксингом и анбоксингом есть кое-какие проблемы

            double pi = 3.14;
            object obj1 = pi;
            // кто-либо, работающий с этим objectом может быть и не в курсе, что там был ранее double, и попробует скаставать из него int
            int number = (int)obj1; // если это запустить- получим исключени
                                    // в этом и есть проблема object, то есть никто не знает какой именно тип там лежит
            Console.WriteLine(number);
            // изнначально object задумывался как нечто универсальное бля перебачи каких угодно аргументов, но из-за проблемы описанной выше,
            // работать с ним было не очень удобно и с появлением дженериков с object уже никто не работает.
            // Однако если у нас есть некий метод, который принимает object в качестве аргументов, мы все таки можем узнать типы принимаемых.
            // см. метод Do()
        }
        static void Do(object obj)
        {
            // на примере PointRef
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                // какой-нибудь код в случае если тип не PointRef
            }

            // второй способ более простой
            PointRef pr1 = obj as PointRef;
            // если obj является PointRef то произойдет кастование, а если нет, то в pr1 запишется null
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                // какой-либо код если в pr1 записан null
            }
        }
        static void NullableValueTypesDemo()
        {
            //бывает случаи, например при получении данных из бд, когда нам нужно присвоить переменной null, ну то есть ничего,
            //но просто так это сделать не получится по этому в таких случаях необходимо указывать ? после типа переменной
            //в которую мы хотим поместить null
            //например так если у нас тип сложный, то есть с использованием has value property:
            PointVal? pv = null;
            if (pv.HasValue)
            {
                Console.WriteLine(pv.Value.X);
            }
            else
            {
                //какой-то код, который будет выполняться в случае если записан null
            }
            // или так без has value property:
            PointVal pv3 = pv.GetValueOrDefault();

            //простые типы можно так записывать
            int? a = null;
            Console.WriteLine(a); // ничего не напечатает, так как мы ничего и не записали
        }
        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();

            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            // в случае если нам нужна функция, которая сможет изменять исходные данные, необходимо пользоваться ключевым словом ref
            // перед объявлением типа принимающихся аргументов, но только в случае если принимающиеся аргументы типа значения.
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");


        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void ValRefTypesDemo()
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
        }
        static void StaticClassAndMethodsDemo()
        {
            double result2 = Calculator_static.Average2(1, 2, 3);
        }
        static void ClassMethodsAndOverloadedMethodsDemo()
        {
            Calculator calc = new Calculator();
            double squere2 = calc.CalcTriangleSquere(10, 20); // вызывается второй метод
            double squere1 = calc.CalcTriangleSquere(5, 5, 5); // вызывается первый метод 
            Console.WriteLine($"Squere1={squere1} Squere2={squere2}");

            Calculator calc1 = new Calculator();
            double avg = calc1.Average(new int[] { 1, 2, 3, 4 });
            //или с params
            double avg1 = calc1.Average2(1, 2, 3, 4);
            Console.WriteLine(avg);
            Console.WriteLine();
            double sq = calc1.CalcTriangleSquere(ab: 10, ac: 20, alpha: 30);
        }
        static void OutParametresDemo()
        {
            Calculator calc3 = new Calculator();
            if (calc3.TryDevide(10, 0, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
        }
        static void ProtectedAtributesDemo()
        {
            Character ch = new Character(Race.Elf);
            Console.WriteLine(ch.Health);
            ch.Hit(20);
            Console.WriteLine(ch.Health);
        }
        static void HomeWorkRomeParse()
        {
            Console.WriteLine(ParserRomeNumbers.Parse("XIX"));
        }

    }
}

