namespace HarryPotter.Behaviors
{
    using Utils;

    using WaveEngine.Framework;

    internal abstract class PolygonColliderBase : Behavior
    {
        public Polygon? BoundingPolygon { get; protected set; }

        public static bool Intersects(PolygonColliderBase a, PolygonColliderBase b)
        {
            if (a.BoundingPolygon == null || b.BoundingPolygon == null)
            {
                return false;
            }
            return Polygon.Intersects(a.BoundingPolygon.Value, b.BoundingPolygon.Value);
        }
    }
}
