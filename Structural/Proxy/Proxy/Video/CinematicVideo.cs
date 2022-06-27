using System;

namespace Proxy
{
    class CinematicVideo : Video
    {
        private string name;

        public CinematicVideo(string name)
        {
            this.name = name;

            Console.WriteLine($"{name} 영상 로드");
        }

        public void play() 
            => Console.WriteLine($"{name} 영상 플레이");
    }
}
