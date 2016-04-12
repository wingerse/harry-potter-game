namespace HarryPotter.Models
{
    using System.Collections.Generic;

    using WaveEngine.Common.Math;

    internal static class ObstacleBoundingBoxes
    {
        public static readonly Dictionary<int, Vector2[]> Vertices = new Dictionary<int, Vector2[]>
        {
            [1] = new[] { new Vector2(4, 0), new Vector2(24, 0), new Vector2(22, 153), new Vector2(4, 153) },
            [2] = new[] { new Vector2(16, 0), new Vector2(80, 0), new Vector2(80, 78), new Vector2(16, 78) },
            [3] = new[] { new Vector2(16, 0), new Vector2(80, 0), new Vector2(80, 174), new Vector2(16, 174) },
            [4] = new[] { new Vector2(0, 64), new Vector2(17, 14), new Vector2(32, 64) },
            [5] = new[] { new Vector2(22, 96), new Vector2(2, 50), new Vector2(15, 18), new Vector2(48, 18), new Vector2(62, 50), new Vector2(42, 96) },
            [6] = new[] { new Vector2(0, 0), new Vector2(128, 0), new Vector2(96, 130), new Vector2(32, 130) },
            [7] = new[] { new Vector2(0, 0), new Vector2(64, 0), new Vector2(64, 98), new Vector2(0, 98) },
            [8] = new[] { new Vector2(0, 0), new Vector2(64, 0), new Vector2(64, 128), new Vector2(0, 128) },
            [9] = new[] { new Vector2(0, 16), new Vector2(30, 16), new Vector2(30, 64), new Vector2(0, 64) },
            [10] = new[] { new Vector2(0, 16), new Vector2(30, 16), new Vector2(30, 96), new Vector2(0, 96) },
            [11] = new[] { new Vector2(0, 0), new Vector2(30, 0), new Vector2(30, 48), new Vector2(0, 48) },
            [12] = new[] { new Vector2(0, 0), new Vector2(30, 0), new Vector2(30, 80), new Vector2(0, 80) },
            [13] = new[] { new Vector2(20, 94), new Vector2(12, 40), new Vector2(34, 0), new Vector2(54, 40), new Vector2(48, 94) },
            [14] = new[] { new Vector2(0, 14), new Vector2(32, 14), new Vector2(32, 128), new Vector2(0, 128) },
            [15] = new[] { new Vector2(0, 0), new Vector2(62, 32), new Vector2(124, 0) }
        };
    }
}
