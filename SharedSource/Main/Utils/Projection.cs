namespace HarryPotter.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using WaveEngine.Common.Math;

    internal struct Projection
    {
        public Projection(float min, float max)
        {
            this.Min = min;
            this.Max = max;
        }

        public float Min { get; }
        public float Max { get; }

        public static bool Overlaps(Projection a, Projection b)
        {
            if (a.Max <= b.Min)
            {
                return false;
            }
            if (b.Max <= a.Min)
            {
                return false;
            }
            return true;
        }

        public static Projection Project(IEnumerable<Vector2> vertices , Vector2 axis)
        {
            List<Vector2> verticesList = vertices.ToList();
            float min = Vector2.Dot(verticesList[0], axis);
            float max = min;

            // Start with 2nd vertex because first one is already projected.
            for (var i = 1; i < verticesList.Count; i++)
            {
                float scalarProjection = Vector2.Dot(verticesList[i], axis);
                if (scalarProjection < min)
                {
                    min = scalarProjection;
                }
                else if (scalarProjection > max)
                {
                    max = scalarProjection;
                }
            }

            return new Projection(min, max);
        }
    }
}
