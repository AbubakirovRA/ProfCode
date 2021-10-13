using System;

namespace Example038_MultiGeneric
{
    #region ToDo

    interface IShape { void Draw(); }
    class Shape : IShape { public void Draw() { } }
    class Ellipse : Shape { }
    class Rectangle : Shape { }
    class Polygon : Shape { }

    #endregion

    class MultiSpecificClass<T, K>
    #region ToDo
    //where T : notnull
    //where T: struct
    //where T: class
    //where T: unmanaged
    //where T: new()
    //where T : IShape
    //where T : Shape

    #endregion
    {
        public MultiSpecificClass(T Value1, K Value2)
        {
            this.Property1 = Value1;
            this.Property2 = Value2;
        }
        public T Property1 { get; set; }
        public K Property2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Ограничения
            var cl2 = new MultiSpecificClass<byte, string>(18, "Февраль");




        }
    }
}
