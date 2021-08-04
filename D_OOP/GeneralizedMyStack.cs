using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
     // А теперь переработаем наш стэк, сделав его обобщенным, то есть что попало в него не запишешь.
     // обобщения записываются в <> T - то есть какой-то тип, но мы не знаем какой.
    public class GeneralizedMyStack<T>
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
        public GeneralizedMyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];

        }
        public GeneralizedMyStack(int capacity)
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
            _items[--Count] = default(T); // сдесь мы не можем присвоить null, заменим его на значение по умолчанию
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _items[Count - 1];

        }
       // Клиент, который создает объект класса
       // теперь должен будет передать тип. 

    }
}
