using System;
using static System.Console;

namespace Example036_ObjectOrientedThinkingClassComponent011Prop
{
    class Soo
    {
        public int Property { get; set; }
    }

    class Doo
    {
        int property;
        public int Property
        {
            get
            {
                return this.property;
            }
            set
            {
                this.property = value;
            }
        }
    }

    class Foo
    {
        int property;
        public int Property
        {
            private get { return this.property; } // Чтение
            set { this.property = value; } // Запись
        }
    }

    class Xoo
    {
        public string Property
        {
            get
            {
                return DateTime.Now.DayOfWeek.ToString();
            }
        }
    }

    class Hoo
    {
        public string Property
        {
            get
            {
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Monday: return "Понедельник";
                    case DayOfWeek.Tuesday: return "Вторник";
                    case DayOfWeek.Wednesday: return "Среда";
                    case DayOfWeek.Thursday: return "Четверг";
                    case DayOfWeek.Friday: return "Пятница";
                    case DayOfWeek.Saturday: return "Суббота";
                    default: return "Воскресенье";
                }
            }
        }
    }

    class Joo
    {
        public string Property
        {
            get
            {
                string day = String.Empty;
                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Monday: day = "Понедельник"; break;
                    case DayOfWeek.Tuesday: day = "Вторник"; break;
                    case DayOfWeek.Wednesday: day = "Среда"; break;
                    case DayOfWeek.Thursday: day = "Четверг"; break;
                    case DayOfWeek.Friday: day = "Пятница"; break;
                    case DayOfWeek.Saturday: day = "Суббота"; break;
                    case DayOfWeek.Sunday: day = "Воскресенье"; break;
                }
                return day;
            }
        }
    }

    class Koo
    {
        private DayOfWeek dayOfWeek;

        public string Property
        {
            set
            {
                switch (value)
                {
                    case "Понедельник": dayOfWeek = DayOfWeek.Monday; break;
                    case "Вторник": dayOfWeek = DayOfWeek.Tuesday; break;
                    case "Среда": dayOfWeek = DayOfWeek.Wednesday; break;
                    case "Четверг": dayOfWeek = DayOfWeek.Thursday; break;
                    case "Пятница": dayOfWeek = DayOfWeek.Friday; break;
                    case "Суббота": dayOfWeek = DayOfWeek.Saturday; break;
                    case "Воскресенье": dayOfWeek = DayOfWeek.Sunday; break;
                }
            }
        }
    }

    class Poo
    {
        private int[] col;
        public Poo()
        {
            col = new int[10];
        }

        public int[] Col
        {
            get { return this.col; }
            set { this.col = value; }
        }
    }
    class Poo2
    {
        private static int DefaultValue;// Значение в случае отстутствия индекса

        static Poo2()
        {
            DefaultValue = int.MinValue;
        }

        private int[] col;
        public Poo2()
        {
            col = new int[5];
        }

        public int Get(string Numbers)
        {
            switch (Numbers.ToLower())
            {
                case "ноль": return this.col[0];
                case "один": return this.col[1];
                case "два": return this.col[2];
                case "три": return this.col[3];
                case "четыре": return this.col[4];
                default: return DefaultValue;
            }
        }

        public void Set(string Numbers, int value)
        {
            switch (Numbers.ToLower())
            {
                case "ноль": this.col[0] = value; break;
                case "один": this.col[1] = value; break;
                case "два": this.col[2] = value; break;
                case "три": this.col[3] = value; break;
                case "четыре": this.col[4] = value; break;
            }
        }
    }

    class Qoo
    {
        private int[] col;
        public Qoo()
        {
            col = new int[5];
        }

        public int[] Col { get { return this.col; } set { this.col = value; } }
    }

    class Roo
    {
        private int[] col;
        public Roo()
        {
            col = new int[5];
        }

        public int Get(int index) { return this.col[index]; }
        public void Set(int index, int value) { this.col[index] = value; }
    }


    class RPoo
    {
        private static int DefaultValue;// Значение в случае отстутствия индекса

        static RPoo()
        {
            DefaultValue = int.MinValue;
        }

        private int[] col;
        public RPoo()
        {
            col = new int[5];
        }

        public int Get(string Numbers)
        {
            switch (Numbers.ToLower())
            {
                case "ноль": return this.col[0];
                case "один": return this.col[1];
                case "два": return this.col[2];
                case "три": return this.col[3];
                case "четыре": return this.col[4];
                default: return DefaultValue;
            }
        }
        public void Set(string Numbers, int value)
        {
            switch (Numbers.ToLower())
            {
                case "ноль": this.col[0] = value; break;
                case "один": this.col[1] = value; break;
                case "два": this.col[2] = value; break;
                case "три": this.col[3] = value; break;
                case "четыре": this.col[4] = value; break;
            }
        }

        public int Get(int index) { return this.col[index]; }
        public void Set(int index, int value) { this.col[index] = value; }
    }

    class Xoo2
    {
        private static int DefaultValue;// Значение в случае отстутствия индекса

        static Xoo2()
        {
            DefaultValue = int.MinValue;
        }
        private int[] col;
        public Xoo2()
        {
            col = new int[10];
        }

        public int this[int index]
        {
            get { return this.col[index]; }
            set { this.col[index] = value; }
        }

        public int this[string Numbers]
        {
            get
            {
                switch (Numbers.ToLower())
                {
                    case "ноль": return this.col[0];
                    case "один": return this.col[1];
                    case "два": return this.col[2];
                    case "три": return this.col[3];
                    case "четыре": return this.col[4];
                    default: return DefaultValue;
                }
            }
            set
            {
                switch (Numbers.ToLower())
                {
                    case "ноль": this.col[0] = value; break;
                    case "один": this.col[1] = value; break;
                    case "два": this.col[2] = value; break;
                    case "три": this.col[3] = value; break;
                    case "четыре": this.col[4] = value; break;
                }
            }
        }

        int[,] arr = new int[10, 10];

        public int this[int row, int col]
        {
            get { return this.arr[row, col]; }
            set { this.arr[row, col] = value; }
        }




    }
    class Xoo3
    {
        public Xoo3() { }

        public string this[int n]
        {
            get
            {
                return n <= 12 ? "День" : "Ночь";
            }
        }

        public int this[string Text]
        {
            set
            {
                if (Text.ToLower() == "тест") WriteLine($"Тест индексатора с текстом \"Тест\" value = {value}");
                else WriteLine($"Тест индексатора с текстом \"Тест\" не пройден value = {value}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Poo poo = new Poo();
            //poo[1] = 123;

            Foo foo = new Foo();

            foo.Property = 2020;

            /////
            /// 
            Qoo qoo = new Qoo();
            qoo.Col[3] = 2019;
            WriteLine(qoo.Col[3]);

            Roo roo = new Roo();
            roo.Set(3, 2019);
            WriteLine(roo.Get(3));

            Poo2 poo2 = new Poo2();
            poo2.Set("Три", 2000);
            WriteLine(poo2.Get("Три"));

            RPoo rPoo = new RPoo();
            rPoo.Set("Три", 2000);
            WriteLine(rPoo.Get("Три"));
            rPoo.Set(3, 2019);
            WriteLine(rPoo.Get(3));

            #region ToDo

            // Как нужно
            Xoo2 xoo = new Xoo2();
            xoo[3] = 2020;
            xoo["три"] = 2020;
            WriteLine(xoo[3]);
            WriteLine(xoo["три"]);
            xoo[2, 4] = 123;
            #endregion

            ///

            Xoo3 xoo3 = new Xoo3();

            WriteLine(xoo3[10]);
            WriteLine(xoo3[20]);

            xoo3["Ку-ку"] = 1;
            xoo3["тест"] = 2020;


        }
    }
}
