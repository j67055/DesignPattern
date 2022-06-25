using System;

namespace Facade
{
    class PlayerMarker : Component
    {
        public int ID { get; private set; }

        public PlayerMarker(int id)
            => ID = id;

        public void set()
            => Console.WriteLine(ID.ToString() + "번 플레이어 말 준비");
        public void clear()
            => Console.WriteLine(ID.ToString() + "번 플레이어 말 정리");
    }
}
