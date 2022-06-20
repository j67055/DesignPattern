using System;

namespace Builder
{
    class Starcraft
    {
        static void Main(string[] args)
        {
            Map lostTemple = CreateLostTemple(new StandardMapBuilder("Lost Temple"));
            Console.WriteLine(lostTemple.ToString());
            
            Map fightingSpirit = CreateFightingSpirit(new StandardMapBuilder("Fighting Spirit"));
            Console.WriteLine(fightingSpirit.ToString());
        }

        static Map CreateLostTemple(IMapBuilder builder)
        {
            builder.buildTile(TileType.Sea);
            builder.buildTile(TileType.Sea);

            builder.buildResource(ResourceType.Mineral);
            builder.buildResource(ResourceType.Gas);

            return builder.getMap();
        }

        static Map CreateFightingSpirit(IMapBuilder builder)
        {
            builder.buildTile(TileType.Land);

            builder.buildResource(ResourceType.Mineral);
            builder.buildResource(ResourceType.Mineral);

            return builder.getMap();
        }
    }
}
