﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // попробуем реализовать свой собственный стэк, за основу возьмем тип object
    public class MyStack
    {
        // добавим свойство Counter, что бы пользователь мог аноидировать стэк, однако записывать смогли бы только мы.
        public int Count { get; private set; }
        // а что бы внешний код мог почитать емкость- создадим свойство Capacity. Оно будет вообще read only.
        public int Capacity 
        {
            get
            {
                return _items.Length;
            }
        }
        // и вот тут важно понимать, что между Count и Capacity есть весомая разица. Если мы создадим стэк и ничего туда не положим, то
        // по умолчанию Count будет равен 0, однако Capacity будет равен вместимости массива, то есть если мы не передали явно, то будет
        // равен 4, а если укажем вместимость 10- будет равен 10.

        private object[] _items;
        // объявим конструкторы
        // первый неявный, где просто укажем, что по умолчанию размерность стэка будет 4
        public MyStack()
        {
            const int defaultCapacity = 4; // укажем стэку размерность 4 по умолчанию
            _items = new object[defaultCapacity];

        }
        // и второй конструктор, если вместимость массива кто-то захочет указать свою. Теперь если кто-то инициализирует наш стэк без
        // указания вместимости, в стэк поместится 4 записи, или же может указать какое угодно значение
        public MyStack(int capacity)
        {
            _items = new object[capacity];
        }
        // реализуем возможность записывать в стэк. По сути нам нужно обработать 2 ситуации, когда массив у нас не заполнен и когда заполнен
        public void Push(object item)
        {
            if (_items.Length == Count)
            {
                object[] largerArray = new object[Count * 2]; // временно задаем массив увеличенный на двое
                Array.Copy(_items, largerArray, Count); // и копируем в него в наш массив _items (абсолютно все элементы)
                _items = largerArray; // ну и переназначаем ссылку, так сказать
            }
            // не забываем положить элемент в массив, а после увеличить Count на 1.
            _items[Count++] = item;
        }
        // реализуем метод Pop. И тут тоже 2 ситуации. 1 если человек пытается изъять элемент из пустого стэка, то мы должы выбросить исключение.
        // 2 если там есть элементы, то можно без проблем от туда изъять
        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            // изымаем элемент и затираем там значение
            _items[--Count] = null;
        }
        // ну и метод Peek, который просто возвращает нам последний элемент не удаляя его (удаляет Pop)
        public object Peek()
        {
            // тут по аналогии с Pop, если массив пустой, то мы должны сказать вызывающему коду, что он сам дурак.
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            // и просто возвращаем последний элемент
            return _items[Count - 1];

        }
        // ну и на этом наш стэк с базовым функционалом готов, перейдем в Program.cs
    }
}