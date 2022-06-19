using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Map
    {
        private string name;
        private List<Tile> tiles = new List<Tile>();
        private List<Resource> resources = new List<Resource>();

        public Map(string name)
            => this.name = name;

        public void addTile(Tile tile)
            => tiles.Add(tile);
        public void addResource(Resource resource)
            => resources.Add(resource);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);

            sb.Append("\n  Tiles: ");
            foreach (Tile tile in tiles)
                sb.Append(tile.ToString())
                    .Append(' ');

            sb.Append("\n  Resources: ");
            foreach (Resource resource in resources)
                sb.Append(resource.ToString())
                    .Append(' ');

            return sb.ToString();
        }
    }
}
