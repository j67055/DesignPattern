using System.Collections.Generic;
using System.Numerics;

namespace Flyweight
{
    class DodgeGame
    {
        private List<KeyValuePair<Bullet, Vector2>> bullets = new List<KeyValuePair<Bullet, Vector2>>();

        public void spwanBullet(string color, Vector2 pos)
        {
            Bullet bullet = BulletFactory.Instance.createBullet(color);
            bullets.Add(new KeyValuePair<Bullet, Vector2>(bullet, pos));
        }

        public void render()
        {
            foreach(var p in bullets)
                p.Key.render(p.Value);
        }
    }
}
