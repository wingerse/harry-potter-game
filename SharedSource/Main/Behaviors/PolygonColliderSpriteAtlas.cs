namespace HarryPotter.Behaviors
{
    using System;
    using System.Collections.Generic;

    using Utils;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class PolygonColliderSpriteAtlas : PolygonColliderBase
    {
        private readonly Dictionary<int, Vector2[]> spriteSheetVertices;

        [RequiredComponent]
        private SpriteAtlas spriteAtlas;

        [RequiredComponent]
        private Transform2D transform2D;

        public PolygonColliderSpriteAtlas(Dictionary<int, Vector2[]> spriteSheetVertices)
        {
            this.spriteSheetVertices = spriteSheetVertices;
        }

        protected override void Update(TimeSpan gameTime)
        {
            if (!this.spriteSheetVertices.ContainsKey(this.spriteAtlas.TextureIndex))
            {
                this.BoundingPolygon = null;
            }

            this.BoundingPolygon = new Polygon(this.transform2D.Position, this.spriteSheetVertices[this.spriteAtlas.TextureIndex]);
        }

        public static bool Intersects(PolygonColliderSpriteAtlas a, PolygonColliderSpriteAtlas b)
        {
            if (a.BoundingPolygon == null || b.BoundingPolygon == null)
            {
                return false;
            }

            return Polygon.Intersects(a.BoundingPolygon.Value, b.BoundingPolygon.Value);
        }
    }
}
