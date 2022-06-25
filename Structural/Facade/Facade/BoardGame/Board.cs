using System;
using System.Collections.Generic;

namespace Facade
{
    class Board : Component
    {
        private int size;
        private Dictionary<int, int> locations = new Dictionary<int, int>();

        public Board(int size)
            => this.size = size;

        public void set()
            => Console.WriteLine("보드판 준비");

        public void locatePlayerAtStart(PlayerMarker pm)
        {
            locations.Add(pm.ID, 0);
            Console.WriteLine(pm.ID + "번 플레이어 출발선으로");
        }

        public void movePlayer(PlayerMarker pm, int delta)
        {
            locations[pm.ID] += delta;
            Console.WriteLine(pm.ID + "번 플레이어: " + locations[pm.ID].ToString() + "번 칸까지 전진");
        }

        public bool isWinner(PlayerMarker pm)
            => locations[pm.ID] >= size;

        public void clear()
            => Console.WriteLine("보드판 정리");

    }
}
