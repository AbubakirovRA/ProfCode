using System;

namespace Example028_ObjectOrientedThinkingClassComponent4
{
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
            this.name = name;
            this.level = GameLevel.Easy;
            this.gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        public Game(string name, GameLevel level)
        {
            this.name = name;
            this.level = level;
            this.gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        /// <param name="gold">Количество начального золота</param>
        public Game(string name, GameLevel level, uint gold)
        {
            this.name = name;
            this.level = level;
            this.gold = gold;
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
            Console.WriteLine($"Игра \"{this.name}\" началась...");
        }

        /// <summary>
        /// Метод, отображающий статистику игры
        /// </summary>
        public void Progress()
        {
            Console.WriteLine($"Игра: {this.name} Уровень: {this.level} Монет: {this.gold}\n");
        }
    }
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
