﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Snake.Model
{
    /// <summary>
    /// A játékmenet logikáját tartalmazza  
    /// 
    /// Ez egy osztálydefinició, ami leírha. hogy ha létrehozok egy példányt ebből az osztályból
    /// akkor hogyan is kell minden példánynak működnie.
    /// Ez olyan, mint egy tervrajz.
    /// </summary>
    class Arena
    {
        private MainWindow View;

        /// <summary>
        /// Konstruktor függvény, ő hozza létre az osztály egy-egy példányát.
        /// </summary>
        /// <param name="view">az ablak, ami létrehozta az Arena példányát</param>
        public Arena(MainWindow view)
        {
            //hivatkozva az aosztálypéldányra, amiben vagyunk
            //így is el tudjuk érni az osztálypéldány osztályszintű változóját
            this.View = view;
            //A játék kezdetén megjelenítjük a játékszabályokat
            //Az osztályon belül a this használata nem kötelező
            View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Visible;
        }

        internal void KeyDown(KeyEventArgs e)
        {
            //a játék megkezdéséhez a négy nyílbillentyű valamelyikét kell leütni.
            switch (e.Key)
            {
                case Key.Left:
                case Key.Up:
                case Key.Right:
                case Key.Down:
                    //Elinditjuk a játékot: altüntetjük a játékszabályokat
                    View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Hidden;
                    Console.WriteLine(e.Key);
                    break;
            }
        }
    }
}
