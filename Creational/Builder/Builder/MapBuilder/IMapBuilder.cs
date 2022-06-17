namespace Builder
{
    interface IMapBuilder
    {
        void buildResource(ResourceType type);
        void buildTile(TileType type);
        Map getMap();
    }
}
