using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example023_ObjectOrientedThinkingFirstStep
{
    class Cat
    {
        /// <summary>
        /// Порода
        /// </summary>
        private string Breed;

        /// <summary>
        /// Окрас шерсти
        /// </summary>
        private Color CoatColor;

        /// <summary>
        /// Кличка
        /// </summary>
        private string Nickname;

        /// <summary>
        /// Цвет глаз
        /// </summary>
        private Color EyeColor;

        /// <summary>
        /// Метод, описывающий как котик охотится
        /// </summary>
        private void ToHunt() { Console.WriteLine("Котик охотится..."); }

        /// <summary>
        /// Метод, описывающий как котик спит
        /// </summary>
        private void ToSleep() { Console.WriteLine("Котик засыпает..."); }

        /// <summary>
        /// Метод, описывающий как котик кушает
        /// </summary>
        private void ToEat() { Console.WriteLine("Котик кушает..."); }

        /// <summary>
        /// Метод, описывающий как котик играет
        /// </summary>
        private void ToPlay() { Console.WriteLine("Котик играет..."); }
    }

    class Program
    {

        static void Main(string[] args)
        {


            Cat kitten1 = new Cat();
            Cat kitten2 = new Cat();
            Cat kitten3 = new Cat();

            Cat[] cats = new Cat[] { kitten1, kitten2, kitten3 };

            //kitten1.


            Cat kitten1 = new Cat();                    // "Создание" экземпляра Cat
            

            kitten1.Breed = "Шотландская вислоухая";    //  
            kitten1.CoatColor = Color.Gray;             // Начальные значения
            kitten1.EyeColor = Color.Green;             // соответствующих полей
            kitten1.Nickname = "Барсик";                // 

            kitten1.ToEat();                            // 
            kitten1.ToHunt();                           // Функционал / Поведение
            kitten1.ToPlay();                           // Барсика
            kitten1.ToSleep();                          // 

            #region ToDo

            Console.ReadKey();
            Cat kitten2 = new Cat();                    // "Создание" экземпляра Cat
            kitten2.Breed = "Рэгдолл";                  //  
            kitten2.CoatColor = Color.Gray;             // Начальные значения
            kitten2.EyeColor = Color.Green;             // соответствующих полей
            kitten2.Nickname = "Том";                   // 

            kitten2.ToEat();                            // 
            kitten2.ToHunt();                           // Функционал / Поведение
            kitten2.ToPlay();                           // Тома
            kitten2.ToSleep();                          // 

            #endregion
        }
    }
}