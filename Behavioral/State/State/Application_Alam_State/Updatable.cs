using System;

namespace State
{
    class Updatable : ApplicationAlamState
    {
        public static readonly Updatable Instance = new Updatable();

        private Updatable() { }

        public void releaseNewUpdate(ApplicationController contorller)
            => Console.WriteLine("변화 없음");

        public void update(ApplicationController contorller)
        {
            Console.WriteLine("업데이트 시작");
            contorller.setStatus(Updated.Instance);
        }
    }
}
