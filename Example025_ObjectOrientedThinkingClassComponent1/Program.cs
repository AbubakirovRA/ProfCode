using System;
using static System.Console;

namespace Example025_ObjectOrientedThinkingClassComponent1
{
    /// <summary>
    /// Класс игры
    /// </summary>
    class Game
    {
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

            Game warcraftGame = new Game("Warcraft", GameLevel.Hard, 200);

            warcraftGame.Start();
            warcraftGame.Progress();

            WriteLine();

            #endregion

            #region"Создание" игры  WowGame

            Game wowGame = new Game("World of Warcraft", GameLevel.Hard, 200);

            wowGame.Start();
            wowGame.Progress();

            WriteLine();

            #endregion

            #region "Создание" игры LineageGame

            Game lineageGame = new Game("Lineage II", GameLevel.Medium, 200);

            wowGame.Start();
            wowGame.Progress();

            #endregion

            #region ToDo

            //Game warcraftGame = new Game("Warcraft", GameLevel.Easy);
            //Game warcraftGame = new Game("Warcraft");

            #endregion
        }
    }
}