namespace HarryPotter.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using WaveEngine.Common.Math;

    internal struct Polygon
    {
        private readonly List<Vector2> absoluteVertexPositions;
        private readonly List<Vector2> projectionAxes;
        private readonly List<Vector2> localVertexPositions; 

        public Polygon(Vector2 position, IEnumerable<Vector2> localVertexPositions)
            : this()
        {
            this.localVertexPositions = localVertexPositions.ToList();
            this.absoluteVertexPositions = this.localVertexPositions.Select(lvp => position + lvp).ToList();
            this.projectionAxes = new List<Vector2>();

            for (var i = 0; i < this.absoluteVertexPositions.Count; ++i)
            {
                // Vector from this vertices to next vertice. If this is the last vertice, it goes to the first one.
                Vector2 edge = this.absoluteVertexPositions[i == this.absoluteVertexPositions.Count - 1 ? 0 : i + 1] - this.absoluteVertexPositions[i];
                var normal = new Vector2(-edge.Y, edge.X);
                this.projectionAxes.Add(normal);
            }
        }

        public static bool Intersects(Polygon a, Polygon b)
        {
            // For all projection axes for both of the polygons, see if there is any "gap" (Non overlapping area) in the projections. 
            // If there is, it does not overlap. Else it does.

            if (a.projectionAxes.Any(axis => !ProjectionsOverlap(a, b, axis)))
            {
                return false;
            }
            if (b.projectionAxes.Any(axis => !ProjectionsOverlap(a, b, axis)))
            {
                return false;
            }
            return true;
        }

        private static bool ProjectionsOverlap(Polygon a, Polygon b, Vector2 axis)
        {
            Projection aProjection = Projection.Project(a.absoluteVertexPositions, axis);
            Projection bProjection = Projection.Project(b.absoluteVertexPositions, axis);
            return Projection.Overlaps(aProjection, bProjection);
        }

        public override string ToString()
        {
            return string.Join(", ", this.localVertexPositions.Select(v => v));
        }
    }
}
