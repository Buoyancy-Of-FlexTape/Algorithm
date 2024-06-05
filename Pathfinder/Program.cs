using System.Drawing;

namespace Pathfinder
{
    internal class Program
    {
        private static void Main()
        {
            var mapImage = new Bitmap("SuperMap.png");

            var map = Map.Read(mapImage);
            
            var (path, explored) = Algorithm.ShortestPath(
                map.Graph, 
                map.StartingPosition, 
                map.TargetPosition);

            var result = map.Draw(path, explored);

            new ShowResult(result).ShowDialog();
        }
    }
}
