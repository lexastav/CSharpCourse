using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // Еще более простой способ реализации IEnumerable
    class IEnumerableMyStack2<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        private T[] _items;
        public IEnumerableMyStack2()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];

        }
        public IEnumerableMyStack2(int capacity)
        {
            _items = new T[capacity];
        }
        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _items[--Count] = default(T);
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            // вот сама реализация с помощью ключевого слова yield (в переводе что-то вроде произвести). Умный компилятор генерирует то,
            // что мы писали в явном виде в классе StackEnumertor
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }
        // кроме того yield- очень ленивая конструкция, реализует так называемый lazy evaluation. То есть если внешний код, пользуясь нашим
        // классом, будет использовать foreach, сделав break на коко-то этапе, то for нашего класса то же тормознется на этом этапе,
        // он то же не будет делать полный проход.
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
