using System;
using static System.Console;

namespace Example032_ObjectOrientedThinkingClassComponent006StaticCtor
{
    /// <summary>
    /// Хранилище данных и некоторая логика работы с ними
    /// </summary>
    class Repository
    {
        /// <summary>
        /// Статический конструктор
        /// </summary>
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
    /// <summary>
    /// Класс, описывающий клиентское устройство
    /// </summary>
    class Client
    {
        /// <summary>
        /// Идентификатор киента
        /// </summary>
        static int clientCounter;

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static Client()
        {
            clientCounter = 1;
        }

        int clientId;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Id">Уникальный код клиента</param>
        public Client()
        {
            this.clientId = clientCounter++;
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
    class Program
    {
        static void Main(string[] args)
        {
            Repository.WriteRepositoryData(); // Вывод данных репозитория

            Client client1 = new Client();   //
            Client client2 = new Client();   // Создание группы клиентов
            Client client3 = new Client();   //

            client1.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория

            client2.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория

            client3.AccessToRepositoryData(); // client1 изменяет данные репозитория 
            Repository.WriteRepositoryData(); // Вывод данных репозитория
        }
    }
}
