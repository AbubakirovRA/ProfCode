using System;
using static System.Console;

namespace Example024_ObjectOrientedThinkingClassComponent0
{
    /// <summary>
    /// Класс игры
    /// </summary>
    class Game
    {
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
            WriteLine($"Игра: {name} Уровень: {level} Монет: {gold}");
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
            #region "Создание" игры WarcraftGame

            Game warcraftGame = new Game();

            warcraftGame.name = "Warcraft";
            warcraftGame.level = GameLevel.Easy;
            warcraftGame.gold = 200;

            warcraftGame.Start();
            warcraftGame.Progress();

            WriteLine();

            #endregion

            #region"Создание" игры  WowGame

            Game wowGame = new Game
            {
                name = "World of Warcraft",
                level = GameLevel.Hard,
                gold = 200
            };

            wowGame.Start();
            wowGame.Progress();

            WriteLine();

            #endregion

            #region "Создание" игры LineageGame

            Game lineageGame = new Game
            {
                name = "Lineage II",
                level = GameLevel.Medium,
                gold = 200
            };

            wowGame.Start();
            wowGame.Progress();

            #endregion

            #region ToDo

            //Game lineageIIGame = new Game("Lineage II", GameLevel.Easy, 200);
            //lineageIIGame.Start();
            //lineageIIGame.Progress();

            #endregion
        }

    }
}