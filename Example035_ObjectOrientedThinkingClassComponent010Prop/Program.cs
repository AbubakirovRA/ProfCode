using System;
using static System.Console;

namespace Example035_ObjectOrientedThinkingClassComponent010Prop
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
        private uint gold;


        /// <summary>
        /// Метод получения информации о количестве золота
        /// </summary>
        /// <returns>Количество золота</returns>
        public uint GetGold()
        {
            return this.gold;
        }


        /// <summary>
        /// Метод установки количества количестве золота
        /// </summary>
        /// <param name="value"></param>
        private void SetGold(uint value)
        {
            this.gold = value;
        }

        #region _
        // Свойства

        public uint Gold
        {
            private get { return this.gold; }
            set { this.gold = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        #endregion


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
            Game game = new Game("Concrete Game", GameLevel.Medium, 100);
            game.Progress();


            //game.gold = 1100; // Ошибка CS0122  'Game.gold" недоступен из-за его уровня защиты.

            WriteLine(game.GetGold());

            game.Gold = 120;
            //WriteLine(game.Gold);

            //game.SetGold(100);

            WriteLine(game.GetGold());

            game.Progress();

        }
    }
}
