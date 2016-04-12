namespace HarryPotter.Behaviors
{
    using System;
    using System.Diagnostics;

    using Entities;

    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class MapMovementBehavior : Behavior
    {
        private readonly Vector2 velocity;

        [RequiredComponent]
        private Transform2D transform2D;

        public MapMovementBehavior(Vector2 velocity)
        {
            this.velocity = velocity;
        }

        protected override void Update(TimeSpan gameTime)
        {
            Vector2 velocityTimeStepVector = this.velocity * (float)gameTime.TotalSeconds;
            var roundedVector = new Vector2((float)Math.Round(velocityTimeStepVector.X), (float)Math.Round(velocityTimeStepVector.Y));
            this.transform2D.Position += roundedVector;
        }
    }
}
