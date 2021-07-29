using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // предположим, что нам поступила задача разработать систему подключения к серверу банковских терминалов.
    // создадим базовый класс, определим в нем общие атрибуты и виртуальный метод, который маследники могут по своему переопределять
    // и добовлять свои какие-то действия. А в конструкторе сразу определим атрибут, который потом смогут определять наследники
    // в своих конструкторах.

    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine("General Connecting Protocol....");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id) // передали id с базового конструктора, по сути этим кодом мы делигируем
                                                    // работу базовому конструктору
        {
        }
        public override void Connect() // переопределем базовый метод
        {
            base.Connect();
            Console.WriteLine("Additional actions for Model X");

        }
    }

    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id) 
        {
        }
        public override void Connect() // а тут мы хотим что бы базовый метод не вызывался
        {
            Console.WriteLine("Additional actions for Model Y");

        }
    }

}
