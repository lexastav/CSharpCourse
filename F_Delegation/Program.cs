using System;

namespace F_Delegation
{
    public class Car
    {
        int speed = 0;
        // определим делегат, который описывает некую сигнатуру, и этой сигнатуре должен следовать обработчик события, он будет в клиентском коде
        // в нашем случае обработчиком события будет метод private static void HandleOnTooFast()
        public delegate void TooFast(int currentspeed);

        //объявим экземпляр делегата
        private TooFast tooFast;

        public void Start()
        {
            speed = 10;
        }
        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                // сам обработчик вызывается вот здесь
                tooFast(speed);
            }
                
        }
        public void Stop()
        {
            speed = 0;
        }
        public void RegisterOnTooFast(TooFast tooFast)
        {
            // добавляем в список делегаты ссылку на метод-обработчик
            this.tooFast += tooFast;
        }

        public void UnregisterOnTooFast(TooFast tooFast)
        {
            // а так можно осоединять обработчики
            this.tooFast -= tooFast;
        }
    }
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.RegisterOnTooFast(HandleOnTooFast);
            // вот если мы сделаем так, то в делегате будет 2 ссылки, а значит HandleOnTooFast вызовется 2 раза, то есть мы дважды подписались
            car.RegisterOnTooFast(HandleOnTooFast);
            // а так мы можем отписаться, и ввод останется только один
            car.UnregisterOnTooFast(HandleOnTooFast);

            car.Start();
            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }           
        }
        private static void HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Oh, I got it, calling brake! Current speed- {speed}");
            car.Stop();
        }
    }
}
