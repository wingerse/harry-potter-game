namespace HarryPotter.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using Entities;

    using WaveEngine.Common.Math;

    internal static class Obstacles
    {
        private static readonly Dictionary<int, string> ObstacleNumToPath = new Dictionary<int, string>
        {
            [1] = WaveContent.Assets.Sprites.Obstacles.obstacle1_png,
            [2] = WaveContent.Assets.Sprites.Obstacles.obstacle2_png,
            [3] = WaveContent.Assets.Sprites.Obstacles.obstacle3_png,
            [4] = WaveContent.Assets.Sprites.Obstacles.obstacle4_png,
            [5] = WaveContent.Assets.Sprites.Obstacles.obstacle5_png,
            [6] = WaveContent.Assets.Sprites.Obstacles.obstacle6_png,
            [7] = WaveContent.Assets.Sprites.Obstacles.obstacle7_png,
            [8] = WaveContent.Assets.Sprites.Obstacles.obstacle8_png,
            [9] = WaveContent.Assets.Sprites.Obstacles.obstacle9_png,
            [10] = WaveContent.Assets.Sprites.Obstacles.obstacle10_png,
            [11] = WaveContent.Assets.Sprites.Obstacles.obstacle11_png,
            [12] = WaveContent.Assets.Sprites.Obstacles.obstacle12_png,
            [13] = WaveContent.Assets.Sprites.Obstacles.obstacle13_png,
            [14] = WaveContent.Assets.Sprites.Obstacles.obstacle14_png,
            [15] = WaveContent.Assets.Sprites.Obstacles.obstacle15_png
        };

        private static XDocument document;

        public static List<Obstacle> GetObstacles(int mapNum, int difficulty)
        {
            List<XElement> difficultyNodes = document.Root.Element($"Map{mapNum}").Elements().ToList();

            // No difficulty? No obstacles
            if (!difficultyNodes.Any())
            {
                return new List<Obstacle>();
            }

            // If specified difficulty does not exist, last dificulty is chosen.
            XElement difficultyNode = difficultyNodes.FirstOrDefault(e => e.Name == $"Difficulty{difficulty}") ?? difficultyNodes.Last();

            return difficultyNode.Elements()
                                 .Select(obElement =>
                                         {
                                             int num = int.Parse(obElement.Element("Name").Value);
                                             string[] posValues = obElement.Element("Position").Value.Split(',');
                                             var pos = new Vector2(int.Parse(posValues[0]), int.Parse(posValues[1]));
                                             return new Obstacle(num, pos);
                                         }).ToList();
        }

        public static string GetPath(int num)
        {
            return ObstacleNumToPath[num];
        }

        public static void Load()
        {
            document = XDocument.Load(WaveContent.Assets.Obstacles_xml);
        }
    }
}
