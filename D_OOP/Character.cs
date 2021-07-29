using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Character
    {
        private const int speed = 10;

        private readonly int force;
        // если нам нужно дать доступ для чтения, можем воспользоваться свойством
        public int Health { get; private set; } = 100;
        public Race Race { get; private set; }
        public int Armor { get; private set; }

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
        
        public Character(Race race, int armor = 30) // конструктор
        {
            Race = race;
            Armor = armor;
        }
        public Character(Race race) // конструктор
        {
            Race = race;
            Armor = 30;
        }
        public Character(Race race,  int armor, int force) // конструктор
        {
            Race = race;
            Armor = armor;
            this.force = force;
        }
    }
}
