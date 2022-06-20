namespace Builder
{
    class StandardMapBuilder : IMapBuilder
    {
        private Map map;

        public StandardMapBuilder(string mapName)
            => map = new Map(mapName);

        public void buildResource(ResourceType type)
        {
            switch(type)
            {
                case ResourceType.Mineral:
                    map.addResource(new Mineral());
                    break;
                case ResourceType.Gas:
                    map.addResource(new Gas());
                    break;
            }    
        }

        public void buildTile(TileType type)
        {
            switch (type)
            {
                case TileType.Land:
                    map.addTile(new Land());
                    break;
                case TileType.Sea:
                    map.addTile(new Sea());
                    break;
            }
        }

        public Map getMap()
            => map;
    }
}
