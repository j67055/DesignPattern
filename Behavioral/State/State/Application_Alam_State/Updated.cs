using System;

namespace State
{
    class Updated : ApplicationAlamState
    {
        public static readonly Updated Instance = new Updated();

        private Updated() { }

        public void releaseNewUpdate(ApplicationController contorller)
        {
            Console.WriteLine("새로운 업데이트 알림");
            contorller.setStatus(Updatable.Instance);
        }

        public void update(ApplicationController contorller)
            => Console.WriteLine("변화 없음");
    }
}
