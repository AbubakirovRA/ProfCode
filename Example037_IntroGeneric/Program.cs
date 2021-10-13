using System;
using static System.Console;

namespace Example037_IntroGeneric
{
    class TempClass1 { public int Property { get; set; } }
    class TempClass2 { public bool Property { get; set; } }
    class TempClass3 { public short Property { get; set; } }
    class MultiSpecificClass<Type1, Type2, Type3>
    {
        public MultiSpecificClass(Type1 Value1, Type2 Value2, Type3 Value3)
        {
            this.Property1 = Value1;
            this.Property2 = Value2;
            this.Property3 = Value3;
        }
        public Type1 Property1 { get; set; }
        public Type2 Property2 { get; set; }
        public Type3 Property3 { get; set; }

        public Type1 GetValueProperty1()
        {
            return this.Property1;
        }

    }

    // Параметризированный класс
    // Указатель места заполнения типа
    class GenericClass<T> { public T Property { get; set; } }

    class Program
    {
        static void Main(string[] args)
        {
            #region TempClass

            WriteLine($"TempClass1.Property.Type - {new TempClass1().Property.GetType()}");
            WriteLine($"TempClass2.Property.Type - {new TempClass2().Property.GetType()}");
            WriteLine($"TempClass3.Property.Type - {new TempClass3().Property.GetType()}");

            #endregion

            #region GenericClass

            GenericClass<int> q = new GenericClass<int>();
            WriteLine(q.Property.GetType());

            GenericClass<short> w = new GenericClass<short>();
            WriteLine(w.Property.GetType());

            GenericClass<bool> e = new GenericClass<bool>();
            WriteLine(e.Property.GetType());

            GenericClass<uint> r = new GenericClass<uint>();
            WriteLine(r.Property.GetType());

            #endregion

            #region MultiSpecificClass

            MultiSpecificClass<int, string, bool> cl1 =
                new MultiSpecificClass<int, string, bool>(2020, "Февраль", true);

            cl1.Property1 = 2021; //int
            cl1.Property2 = new String('-', 5); //string
            cl1.Property3 = 1 == 1; //bool
            WriteLine(cl1.GetValueProperty1());


            var cl2 = new MultiSpecificClass<byte, short, int>(18, 2, 2020);
            cl2.Property1 = 19; //byte
            cl2.Property2 = 3; //short
            cl2.Property3 = 2021; //int
            WriteLine(cl1.GetValueProperty1());

            #endregion
        }
    }
}
