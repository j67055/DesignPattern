using System;
using System.Numerics;

namespace Flyweight
{
    class Bullet
    {
        private string color;

        public Bullet(string color)
            => this.color = color;

        public void render(Vector2 pos)
            => Console.WriteLine($@"x: {pos.X.ToString()} y: {pos.Y.ToString()} 위치에 {color} 총알");
    }
}
