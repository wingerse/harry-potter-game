namespace HarryPotter.Behaviors
{
    using System;

    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class MagicMovementBehavior : Behavior
    {
        private readonly Vector2 velocity;

        [RequiredComponent]
        private readonly Transform2D transform2D;

        public MagicMovementBehavior(Vector2 velocity)
        {
            this.velocity = velocity;
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.transform2D.Position += this.velocity * (float)gameTime.TotalSeconds;
        }
    }
}