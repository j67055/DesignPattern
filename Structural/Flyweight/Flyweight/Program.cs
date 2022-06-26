using System.Numerics;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            DodgeGame game = new DodgeGame();
            game.spwanBullet("빨간색", new Vector2(74f, 24f));
            game.spwanBullet("빨간색", new Vector2(10f, 12f));
            game.spwanBullet("빨간색", new Vector2(20f, 15f));
            game.spwanBullet("검정색", new Vector2(61f, 51f));
            game.spwanBullet("검정색", new Vector2(84f, 10f));
            game.render();
        }
    }
}
