using System;
using static System.Console;

namespace Example034_ObjectOrientedThinkingClassComponent009Prop
{

    /// <summary>
    /// Класс игры
    /// </summary>
    class Game
    {
        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="Name">Имя игры</param>
        /// <param name="level">Уровень игры</param>
        /// <param name="gold">Количество начального золота</param>
        public Game(string Name, GameLevel level, uint gold)
        {
            this.name = Name;
            this.level = level;
            this.gold = gold;
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
            WriteLine($"Игра \"{name}\" началась...");
        }

        /// <summary>
        /// Метод, отображающий статистику игры
        /// </summary>
        public void Progress()
        {
            WriteLine($"Игра: {name} Уровень: {level} Монет: {gold}\n");
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
            Game game = new Game("Concrete Game", GameLevel.Medium, 600);
            game.Start();
            game.Progress();

            game.gold = 1100;

            game.Progress();



        }
    }
}
