using System;

namespace Prototype
{
    class MapEditor
    {
        static void Main(string[] args)
        {
            Map lostTemple = new Map("Lost Temple");
            MapPalette palette = new MapPalette(new Sea(), new Mineral());

            lostTemple.addTile(palette.createTile(TileShape.Hex));
            lostTemple.addResource(palette.createResource(1500));
            lostTemple.addResource(palette.createResource(1200));
            lostTemple.addResource(palette.createResource(850));

            Console.WriteLine(lostTemple.ToString());

            Map fightingSpirit = new Map("Fighting Spirit");
            palette = new MapPalette(new Ground(), new Gas());

            fightingSpirit.addTile(palette.createTile(TileShape.Square));
            fightingSpirit.addTile(palette.createTile(TileShape.Cicle));
            fightingSpirit.addTile(palette.createTile(TileShape.Cicle));
            fightingSpirit.addResource(palette.createResource(950));
            fightingSpirit.addResource(palette.createResource(700));

            Console.WriteLine(fightingSpirit.ToString());
        }
    }
}
