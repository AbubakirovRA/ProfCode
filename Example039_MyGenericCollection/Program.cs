using System;
using static System.Console;

namespace Example039_MyGenericCollection
{
    class Storage<T>
    {
        T[] array;
        int index;
        public Storage(int count = 0)
        {
            this.array = new T[count];
            this.index = 0;
        }

        public void Add(T item)
        {
            if (array.Length >= this.index)
            {
                Array.Resize(ref this.array, this.array.Length * 2 + 1);
            }

            this.array[this.index] = item;
            this.index++;
        }

        public int Count { get { return this.index; } }

        public T this[int i]
        {
            get { return this.array[i]; }
            set { this.array[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Storage<int> storageInt = new Storage<int>();

            Random r = new Random();

            for (int i = 0; i < 5; i++) storageInt.Add(r.Next(10));

            for (int i = 0; i < storageInt.Count; i++) Write($"{storageInt[i]} ");

            // ======
            WriteLine(Environment.NewLine);


            Storage<string> storageString = new Storage<string>();


            for (int i = 0; i < 5; i++) storageString.Add(Guid.NewGuid().ToString());

            for (int i = 0; i < storageString.Count; i++) WriteLine($"{storageString[i]} ");

            WriteLine();
        }
    }
}
