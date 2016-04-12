namespace HarryPotter.Behaviors
{
    using System;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class BackgroundMovementBehavior : Behavior
    {
        [RequiredComponent]
        private readonly Sprite sprite;

        [RequiredComponent]
        private readonly Transform2D transform2D;

        private readonly Vector2 velocity;

        private Vector2 startingPosition;

        public BackgroundMovementBehavior(Vector2 velocity)
        {
            this.velocity = velocity;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.startingPosition = this.transform2D.Position;
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.transform2D.Position += this.velocity * (float)gameTime.TotalSeconds;

            var middlePosition = new Vector2(this.transform2D.Position.X + (this.sprite.Texture.Width / 2f), this.transform2D.Position.Y);

            if (middlePosition.X <= this.startingPosition.X)
            {
                this.transform2D.Position = this.startingPosition - (this.startingPosition - middlePosition);
            }
        }
    }
}