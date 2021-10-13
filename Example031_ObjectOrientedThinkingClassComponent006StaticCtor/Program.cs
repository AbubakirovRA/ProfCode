using System;
using static System.Console;

namespace Example031_ObjectOrientedThinkingClassComponent006StaticCtor
{
    /// <summary>
    /// Класс, описывающий клиентское устройство
    /// </summary>
    class Client
    {
        /// <summary>
        /// Идентификатор киента
        /// </summary>
        private int clientId;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Id">Уникальный код клиента</param>
        public Client(int Id)
        {
            this.clientId = Id;
        }

        /// <summary>
        /// Метод, изменяющий данные репозитория
        /// </summary>
        public void AccessToRepositoryData()
        {
            for (int i = 0; i < Repository.Data.Length; i++)
            {
                Repository.Data[i] += $" [изменено Client #{this.clientId}] ";
            }
        }
    }

    /// <summary>
    /// Хранилище данных и некоторая логика работы с ними
    /// </summary>
    class Repository
    {

        #region static ctor

        static Repository()
        {
            Data = new string[]
            {
                "data0",
                "data1",
                "data2",
                "data3",
                "data4",
                "data5",
                "data6",
                "data7",
                "data8",
                "data9"
            };
        }

        #endregion

        /// <summary>
        /// Массив с данными
        /// </summary>
        static public string[] Data;

        /// <summary>
        /// Вывод данных репозитория
        /// </summary>
        static public void WriteRepositoryData()
        {
            foreach (var item in Data)
            {
                WriteLine(item);
            }
            WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Repository.WriteRepositoryData(); // Вывод данных репозитория

            ReadLine();

            Client client1 = new Client(1);   //
            Client client2 = new Client(1);   // Создание группы клиентов
            Client client3 = new Client(1);   //

            client1.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория
            ReadLine();

            client2.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория
            ReadLine();

            client3.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория


        }
    }
}
