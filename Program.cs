using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleGame
{
    class Program : ClickReactionGame
    {
        static void Main(string[] args)
        {
            RememberGame.Play();
            //PlayGame();
        }
    }

    class RememberGame : RememberingGame
    {

        public static void Play()
        {
            var game = new RememberingGame();
            game.GameLoop();
        }
    }
}
