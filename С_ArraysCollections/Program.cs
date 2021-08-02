using System;
using System.Collections.Generic;
using System.Linq;

namespace С_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }
        
        static void HomeWorkRomanPars()
        {
                var baseRomes = new Dictionary<char, int>();
                baseRomes.Add('I', 1);
                baseRomes.Add('V', 5);
                baseRomes.Add('X', 10);
                baseRomes.Add('L', 50);
                baseRomes.Add('C', 100);
                baseRomes.Add('D', 500);
                baseRomes.Add('M', 1000);

                string romeNumb = "VI";
                var lstValues = new List<int>();

                foreach (char item in romeNumb)
                {
                    lstValues.Add(baseRomes[item]);
                }

                int result = 0;
                int previos = lstValues[0];
                int current;

                for (int i = 0; i < romeNumb.Length; i++)
                {
                    current = lstValues[i];
                    if (current <= previos)
                    {
                        result += current;
                    }
                    else
                    {
                        result += (current - previos * 2);

                    }
                    previos = current;
                }
                Console.WriteLine(result);
         }
        static void CastomizbleIndexArray()
        {
            //массивы с настраиваемой индексацией! НИКОГДА ТАК НЕ ДЕЛАТЬ!!!
            // инициализируем массив, который будет содержать 4 элементы, а индексы будут начинаться с 1 а не с 0
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2021, 1);
            myArray.SetValue(2022, 2);
            myArray.SetValue(2023, 3);
            myArray.SetValue(2024, 4);

            Console.WriteLine($"Starting  index:{myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending  index:{myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }

        }
        static void JaggedArrays()
        {
            //зубчатые массивы

            //создаем массив и указываем, что в нем 4 строки
            int[][] jaggedArray = new int[4][];
            //обращаемся к строке и указываем сколько в ней элементов(столбцов) 
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            //заполним массив, можем разнообразить и прпросить пользователя заполнить
            Console.WriteLine("Enter the number for a jagged arrey.");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }
            }
            // выведем элементы
            Console.WriteLine();
            Console.WriteLine("Printing the Elements");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        static void MultidimensionArrays()
        {
            //одномерный массив
            //1 2 3 4

            //двумерный массив
            //1 2 3
            //4 5 6
            //7 8 9

            // создаем многомерный массив
            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; //указываем размерность, например 2 строчки и 3 столбца
            // или покороче
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // итерироваться придется чуть замороченее, вложеными циклами. внимание на синтаксис
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void StackQueue()
        {
            // ОЧЕРЕДЬ принцип FIFO
            var queue = new Queue<int>();
            // добавить элемент в очередь
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine($"Should print out 1: {queue.Peek()}"); // покажет первый добавленный элемент

            queue.Dequeue(); // удаляет первый элемен и возвращает его

            Console.WriteLine($"Should print out 2: {queue.Peek()}");

            Console.WriteLine("Itarate over the queue");
            // можно итерироваться по очереди, при чем элементы будут выводиться в той последовательности, которую гарантировал очередь,
            // то есть с начала в конец
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();

            // СТЭК принцип LIFO
            var stack = new Stack<int>();
            //положить элемент в стэк
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine($"Should print out 6: {stack.Peek()}"); // покажет последний добавленный элемент

            stack.Pop(); // удаляет последний элемен и возвращает его

            Console.WriteLine($"Should print out 5: {stack.Peek()}");

            Console.WriteLine("Itarate over the stack");
            // можно итерироваться по стэку, при чем элементы будут выводиться в той последовательности, которую гарантировал стэк,
            // то есть с конца вначало
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        static void DictionaryType()
        {
            // Создать словарь и добавить в него записи можно так
            var people = new Dictionary<int, string>();
            people.Add(1, "Bob");
            people.Add(2, "Alice");
            people.Add(3, "John");

            // или так

            people = new Dictionary<int, string>()
            {
                {1, "John" },
                {2, "Bob" },
                {3, "Alice" },
            };

            // но в таком случае мы рискуем нарваться на исключение, если хотим добавить пару с ключом, который уже существует в словаре
            // что бы такого не происходило нужно воспользоваться методо TryAdd. Он возвращает bool и исключение не выбрасывает

            if (people.TryAdd(2, "Elias"))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Fail!ed to add! Key alredy exists ");
            }

            // вытащить значение по ключу, выглядит так же как и доступ по индексу в массивах списках и тд

            string name = people[2];
            Console.WriteLine(name);
            Console.WriteLine();

            // или так. Внимательно на синтаксис
            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Value is finded! It's {val}");
            }
            else
            {
                Console.WriteLine("There is no such value");
            }
            // можно итеррироваться по ключам
            var keys = people.Keys; //Dictionary<int, string>.KeyCollection keys = people.Keys; тоже самое, только страшнее выглядит
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();
            // можно итерироваться по значениям
            var values = people.Values; //Dictionary<int, string>.ValueCollection values = people.Values; тоже самое, только страшнее выглядит
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            // но чаще всего итерироваться придется сразу по парам
            foreach (var pair in people) // пары имеют тип KeyValuePair<int, string>
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }

            // можем посмотреть сколько элементов
            var pairCount = people.Count;
            Console.WriteLine(pairCount);

            // можем проверить содержит ли словарь какой-либо ключ
            bool containsKey = people.ContainsKey(2);
            Console.WriteLine(containsKey);
            Console.WriteLine();

            // можем проверить содержит ли словарь какое-либо значение
            bool containsValue = people.ContainsValue("Bob");
            Console.WriteLine(containsValue);
            Console.WriteLine();
            // стоит отметить словарь является ничем инмым как хэш-таблицей, поиск в таком типе по ключу практически моментальный,
            // а вот по значению медленный, по тому такой тип имеет место заводить если мы будем знать и работать исключительно с ключами

            // пары можно удалять по ключу
            people.Remove(1); // метод возвращает bool, так что его можно смело пихать в условие

            // можем очищать словарь
            people.Clear();
        }
        static void ListType()
        {
            var intList = new List<int>() { 7, 5, 9, 12, 1, 4, 2 };
            //добавить элемент в список
            intList.Add(7);

            //добавить целый массив
            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            //а вот удаление чуть сложнее происходит, через if, так как сам метод возвращае true если находит элемент
            //при чем только первое вхождеие
            if (intList.Remove(1))
            {
                //какое-то действие, еще можно и else прописать
            }

            //можно удалить по индексу
            intList.RemoveAt(0);

            //перевернуть list
            intList.Reverse();

            //проверка наличия элемента
            bool contains = intList.Contains(3);

            //минимальный или максимальный элемент
            int min = intList.Min();
            int max = intList.Max();

            //можно искать индексы
            //индекс первого вхождения 2
            int indexOf = intList.IndexOf(2);

            //индекс последнего вхождения 2
            int lastIndexOf = intList.LastIndexOf(2);

            //ну или циклом пройти то же можем, только размер списка берется методом .Count
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);

            }

            // foreach тоже поддерживается
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
        }
        static void ArrayType()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // бинарный поиск по массиву
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            // копирование массива в скобках массив который копируем, массив в который мы копируем, сколько элементов мы копируем
            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            // или чуть по другому, вызывая метод на уровне экземпляра
            int[] anotherCopy = new int[10];
            // вторым аргументом передаем начальный индекс с которого начинается копирование
            copy.CopyTo(anotherCopy, 0);

            //перевернуть массив (не возвращает новый, модифицирует текущий)
            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }

            //сортировка массива

            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            // удалеие элементов
            // в скобках массив, стартовый элемент, конечный элемент
            Array.Clear(copy, 0, copy.Length);



            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 2, 3, 4, 5 };

            // все вышеописанное можно гаписать и без синтаксического сахара

            Array myArray = new int[5];

            // или вообще по хардкору

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            // передадим в массив значение 12 по 0 индексу

            myArray2.SetValue(12, 0);
            // смотреть значение можно то же по хардкору
            Console.WriteLine(myArray2.GetValue(0));
        }
    }
}
