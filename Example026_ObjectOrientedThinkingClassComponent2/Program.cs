using System;
using static System.Console;

namespace Example026_ObjectOrientedThinkingClassComponent1
{
    /// <summary>
    /// Класс игры
    /// </summary>
    class Game
    {
        public Game()
        {
            name = "Def game";
            level = GameLevel.Easy;
            gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="GameName">Имя игры</param>
        public Game(string GameName)
        {
            name = GameName;
            level = GameLevel.Easy;
            gold = 200;
        }

        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="GameName">Имя игры</param>
        /// <param name="SetGameLevel">Уровень игры</param>
        public Game(string GameName, GameLevel SetGameLevel)
        {
            name = GameName;
            level = SetGameLevel;
            gold = 200;
        }


        /// <summary>
        /// Конструктор, позволяющий создать новую игру
        /// </summary>
        /// <param name="GameName">Имя игры</param>
        /// <param name="SetGameLevel">Уровень игры</param>
        /// <param name="AmountOfGold">Количество начального золота</param>
        public Game(string GameName, GameLevel SetGameLevel, uint AmountOfGold)
        {
            name = GameName;
            level = SetGameLevel;
            gold = AmountOfGold;
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
            #region "Создание" игр

            Game game = new Game("Warcraft", GameLevel.Hard, 200);
            game.Progress();


            game = new Game("World Of Warcraft", GameLevel.Medium);
            game.Progress();


            game = new Game("Lineage II");
            game.Progress();

            game = new Game();
            game.Progress();

            #endregion
        }
    }
}