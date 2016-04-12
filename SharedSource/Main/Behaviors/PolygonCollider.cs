namespace HarryPotter.Behaviors
{
    using System;
    using System.Collections.Generic;

    using Utils;

    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class PolygonCollider : PolygonColliderBase
    {
        [RequiredComponent]
        private Transform2D transform2D;

        private readonly IEnumerable<Vector2> vertices;

        public PolygonCollider(IEnumerable<Vector2> vertices)
        {
            this.vertices = vertices;
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.BoundingPolygon = new Polygon(this.transform2D.Position, this.vertices);
        }

        public static bool Intersects(PolygonCollider a, PolygonCollider b)
        {
            if (a.BoundingPolygon == null || b.BoundingPolygon == null)
            {
                return false;
            }

            return Polygon.Intersects(a.BoundingPolygon.Value, b.BoundingPolygon.Value);
        }
    }
}
