namespace Builder
{
    interface MapBuilder
    {
        void buildResource(ResourceType type);
        void buildTile(TileType type);
        Map getMap();
    }
}
