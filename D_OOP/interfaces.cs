using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // в отличии от абстрактных классов, которые могут содержать и консруктор, и поля, свойства, методы не являющиеся абстрактными,
    // в интерфейсах все более жестко, они могут иметь только сигнатуру причем без ключевого свова abstract и без указания модификаторов.

    // Возникает логичный вопрос, зачем вообще нужны интерфейсы, если по сути это ограниченный абстрактный класс?
    // Да дело все в том, что множественное наследование возможно только в случае интерфейсов. Класс может наследовать хоть 10 интерфейсов,
    // а вот в случае с абстрактными классами или обычными- только один.
    // Кстати говоря мы так же можем наследоваться от одного какого-нибудь класса и вместе с ним от скольких угодно интерфесов.

    // еще важным отличием является возможность расширения интерфейса с клиентской стороны, так и со стороны разработчика, в отличии от классов,
    // которые мы можем рассширять только со стороны разработчика. Спомощью мтодов расширения можно добавить не только декларацию
    // но и реализацию.
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);


    }
    // предположим нам надо расширить интерфейс, например добавить возможность принимать не object, а список objectов. Чтобы обозначить
    // метод расширения заведем класс.
    public static class BaseCollectionExtansion
    {
        // внутри идет сигнатура на которую мы хотим расширить интерфейс
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            // и реализация
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }
    public class BaseList : IBaseCollection
    {

        private object[] items;
        private int count = 0;

        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
