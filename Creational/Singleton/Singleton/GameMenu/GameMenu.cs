using System;

namespace Singleton
{
    class GameMenu
    {
        public static GameMenu Instance => instance == null ? instance = new GameMenu() : instance;

        private static GameMenu instance;

        private GameMenu() { }

        public void pause()
            => Console.WriteLine("Pause Game");
        public void resume()
            => Console.WriteLine("Resume Game");
        public void exit()
            => Console.WriteLine("Exit Game");
    }
}
