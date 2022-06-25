using System;
using System.Collections.Generic;

namespace Facade
{
    class BoardGame
    {
        private Board board;
        private Dice dice = new Dice();
        private List<PlayerMarker> players = new List<PlayerMarker>();

        public BoardGame(int boardSize)
        {
            board = new Board(boardSize);
            dice = new Dice();
            players = new List<PlayerMarker>();
        }

        public void startGame(int playerCnt)
        {
            Console.WriteLine("----------게임 준비----------");
            for (int i = 0; i < playerCnt; ++i)
                players.Add(new PlayerMarker(i));

            board.set();
            dice.set();
            players.ForEach(p => p.set());
            players.ForEach(p => board.locatePlayerAtStart(p));
            Console.WriteLine("-----------------------------");
        }

        public void play()
        {
            Console.WriteLine("----------게임 시작----------");
            while (true)
                foreach (var p in players)
                {
                    board.movePlayer(p, dice.roll());
                    if (!board.isWinner(p)) continue;
                    Console.WriteLine(p.ID + "번 플레이어 승리!");
                    Console.WriteLine("-----------------------------");
                    return;
                }
        }

        public void endGame()
        {
            Console.WriteLine("----------게임 정리----------");
            players.ForEach(p => p.clear());
            dice.clear();
            board.clear();

            players.Clear();
            Console.WriteLine("-----------------------------");
        }
    }
}
