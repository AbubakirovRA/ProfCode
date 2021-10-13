using System;

namespace Example027_ObjectOrientedThinkingClassComponent3
{
    /// <summary>
    /// Уровни игры
    /// </summary>
    enum GameLevel
    {
        /// <summary>
        /// Простой уровень игры
        /// </summary>
        Easy,

        /// <summary>
        /// Средний уровень игры
        /// </summary>
        Medium,

        /// <summary>
        /// Сложный уровень игры
        /// </summary>
        Hard
    }


    /// <summary>
    /// Класс игры
    /// </summary>
    class Game
    {
        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        public Game(string name)
        {
            name = name;
            level = GameLevel.Easy;
            gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        public Game(string name, GameLevel level)
        {
            name = name;
            level = level;
            gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        /// <param name="gold">Количество начального золота</param>
        public Game(string name, GameLevel level, uint gold)
        {
            name = name;
            level = level;
            gold = gold;
        }

        /// <summary>
        /// Имя игры
        /// </summary>
        public string name = String.Empty;

        /// <summary>
        /// Уровень игры
        /// </summary>
        public GameLevel level = 0;

        /// <summary>
        /// Количество золота
        /// </summary>
        public uint gold = 0;

        /// <summary>
        /// Метод, запускающий игру
        /// </summary>
        public void Start()
        {
            Console.WriteLine($"Игра \"{name}\" началась...");
        }

        /// <summary>
        /// Метод, отображающий статистику игры
        /// </summary>
        public void Progress()
        {
            Console.WriteLine($"Игра: {name} Уровень: {level} Монет: {gold}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
