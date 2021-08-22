using System;
using System.Timers;

namespace F_Delegation_event_
{
    public class Car
    {
        // сама конструкция с использование делегатов выглядит весьма запутаной, необходимо написание методов добавления и удаления,
        // вот что бы упрастить подобного рода работу и придумали eventы. Event- базируется на delegate. Является как бы надстройкой.
        int speed = 0;

        //public event TooFast TooFastDriving;
        //public delegate void TooFast(int currentspeed);

        // однако в реальности на скорее всего не придется самостоятельно писать делегаты, так как все уже есть в библиотеке

        public event Action<object, int> TooFastDriving;

        public void Start()
        {
            speed = 10;
        }
        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                {
                    TooFastDriving(this, speed);
                }  
            }

        }
        public void Stop()
        {
            speed = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // на самом деле в BCL полно типов, которые базируются на event, например таймер, который позволяет нам завести таймер и подписаться
            // на событие, которое срабатывает тогда, когда истек определенный период времени.
            var timer = new Timer();
            // и у него есть событие Elapsed
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 5000;
            timer.Start();


            
            
            Console.ReadLine();
            var car = new Car();
            // так мы подписываемся на событие
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            // так мы отписываемся
            car.TooFastDriving -= HandleOnTooFast;

            car.Start();
            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }
        }
        // обработчик события
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //var timer = (Timer)sender;

            Console.WriteLine("Handling Timer Elapsed Event");
        }

        private static void HandleOnTooFast(object obj, int speed)
        {
            Console.WriteLine($"Oh, I got it, calling brake! Current speed- {speed}");
            var car = (Car)obj;
            car.Stop();
        }
    }
}
