using System.Collections.Generic;

namespace Flyweight
{
    class BulletFactory
    {
        public static BulletFactory Instance => instance == null ? instance = new BulletFactory() : instance;

        private static BulletFactory instance;

        private Dictionary<string, Bullet> bulletTable = new Dictionary<string, Bullet>();

        private BulletFactory() { }

        public Bullet createBullet(string color)
        {
            if(bulletTable.ContainsKey(color))
                return bulletTable[color];

            return bulletTable[color] = new Bullet(color);
        }
    }
}
