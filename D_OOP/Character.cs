using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Character
    {
        // если нам нужно дать доступ для чтения, можем воспользоваться свойством
        public int Health { get; private set; } = 100;

        // стоит отметить, что если свойство довольно сложное, то его придется описать в более явном виде
        //private int health = 100;
        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}

        // вышкприведенная конструкция позволяет читать health откуда угодно, но изменять ее можно только внутри класса
        // причем внутри класса изменять можно обращаясь как к Health так и к health(если не применяли автосвойство)

        public void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }

            Health -= damage;
        }
    }
}
