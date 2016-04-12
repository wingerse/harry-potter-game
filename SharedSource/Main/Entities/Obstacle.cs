namespace HarryPotter.Entities
{
    using Behaviors;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class Obstacle : BaseDecorator
    {
        public Obstacle(int num, Vector2 localPosition)
        {
            this.Entity =
                new Entity().AddComponent(new Transform2D { Position = localPosition })
                            .AddComponent(new Sprite(Models.Obstacles.GetPath(num)))
                            .AddComponent(new SpriteRenderer())
                            .AddComponent(new PolygonCollider(Models.ObstacleBoundingBoxes.Vertices[num]));
        }
    }
}
