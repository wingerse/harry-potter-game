namespace HarryPotter.Models
{
    using System.Collections.Generic;

    using WaveEngine.Common.Math;

    internal class HarryBoundingBoxes
    {
        public static readonly Dictionary<int, Vector2[]> AnimationVertices = new Dictionary<int, Vector2[]>
        {
            { 0, new[] { new Vector2(0, 59), new Vector2(58, 1), new Vector2(93, 45) } },
            { 1, new[] { new Vector2(0, 50), new Vector2(67, 4), new Vector2(93, 53) } },
            { 2, new[] { new Vector2(0, 50), new Vector2(67, 4), new Vector2(93, 53) } },
            { 3, new[] { new Vector2(0, 55), new Vector2(14, 6), new Vector2(67, 4), new Vector2(93, 53) } },
            { 4, new[] { new Vector2(0, 55), new Vector2(14, 6), new Vector2(67, 4), new Vector2(93, 53) } },
            { 5, new[] { new Vector2(0, 55), new Vector2(14, 6), new Vector2(67, 4), new Vector2(93, 53) } },
            { 6, new[] { new Vector2(0, 59), new Vector2(58, 1), new Vector2(93, 45) } },
            { 7, new[] { new Vector2(0, 64), new Vector2(45, 0), new Vector2(96, 40) } },
            { 8, new[] { new Vector2(0, 64), new Vector2(48, 0), new Vector2(96, 36) } },
            { 9, new[] { new Vector2(4, 64), new Vector2(8, 28), new Vector2(52, 0), new Vector2(96, 36) } },
            { 10, new[] { new Vector2(4, 64), new Vector2(8, 28), new Vector2(52, 0), new Vector2(96, 36) } },
            { 11, new[] { new Vector2(0, 64), new Vector2(48, 0), new Vector2(95, 35) } }
        };
    }
}
