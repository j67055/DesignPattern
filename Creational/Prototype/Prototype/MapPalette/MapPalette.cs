namespace Prototype
{
    class MapPalette
    {
        private Tile tile;
        private Resource resource;

        public MapPalette(Tile tile, Resource resource)
        {
            this.tile = tile;
            this.resource = resource;
        }

        public Tile createTile(TileShape shape)
        {
            var tile = this.tile.Clone() as Tile;
            tile.setShape(shape);

            return tile;
        }
        public Resource createResource(int value)
        {
            var resource = this.resource.Clone() as Resource;
            resource.setValue(value);

            return resource;
        }
    }
}
