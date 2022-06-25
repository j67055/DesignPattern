namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardGame game = new BoardGame(20);
            game.startGame(5);
            game.play();
            game.endGame();
        }
    }
}
