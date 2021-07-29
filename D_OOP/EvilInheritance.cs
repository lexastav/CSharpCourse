using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    // пример так называемой проблемы представителя в наследовании. Предположим у нас есть некий класс прямоугольк, у него есть наследник квадрат,
    // который является частным случаем прямоугольника. И нам никто не мешает инициализировать квадрат через базовый класс, то есть прямоугольник
    // и передать ему разные стороны, что не возможно в принципе.
    // Стоит отметить, что это известная проблема ооп, дело в том что сама парадигма часто преподносится как некая абстракция подхода
    // программирования на ситуации в реальном мире. Да квадрат- это прямоугольник, но при этом это квадрат :) И часто при проектировании
    // подобные моменты тяжело выявить или предугадать.
    
    public class Rect
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Square : Rect
    {

    }

    public static class AreaCalculator
    {
        public static int CalcSquare(Square square)
        {
            return square.Height * square.Height;
        }
        public static int CalcSquare(Rect rect)
        {
            return rect.Height * rect.Width;
        }
    }

    // Oднако починить проблему представителя можно с помощью интерфейса и работать с ним полиморфно.
    // public interface IShape
    // {
    //      int CalcSquare();
    // }
    //public class Rect : IShape
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    
    //    public int CalcSquare()
    //    {
    //          return Width * Height;
    //    }
    //}

    //public class Square : IShape
    //{
    //      public int SideLength { get; set; }
    //
    //      public int CalcSquare()
    //      {
    //          return SideLength * SideLength;
    //      }
    //}



}
