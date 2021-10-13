using System;

namespace Example029_ObjectOrientedThinkingClassComponent5
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
        /// <param name="level">Уровень игры</param>
        /// <param name="gold">Количество начального золота</param>
        public Game(string name, GameLevel level, uint gold)
        {
            this.name = name;
            this.level = level;
            this.gold = gold;
        }


        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        public Game(string name, GameLevel level) : this(name, level, 200)
        {
            this.gold = 100600;
        }


        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="name">Имя игры</param>
        public Game(string name) : this(name, GameLevel.Easy)
        {
            this.gold = 100_600_000;
        }


        /// <summary>
        /// Имя игры
        /// </summary>
        public string name;

        /// <summary>
        /// Уровень игры
        /// </summary>
        public GameLevel level;

        /// <summary>
        /// Количество золота
        /// </summary>
        public uint gold;

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

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("game");
            game.Progress();
        }
    }
}
