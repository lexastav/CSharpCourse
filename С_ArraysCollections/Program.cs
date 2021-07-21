using System;
using System.Collections.Generic;
using System.Linq;

namespace С_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
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
