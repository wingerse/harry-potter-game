namespace HarryPotter.Behaviors
{
    using System;
    using System.Linq;

    using HarryPotter.Entities;
    using HarryPotter.Utils;

    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class MagicEmitterBehavior : Behavior
    {
        private const double Delay = 50; // Milliseconds

        private readonly ObjectPool<Magic> magicPool = new ObjectPool<Magic>(m => m.IsOutOfMap);

        private double timer = Delay;

        [RequiredComponent]
        private Transform2D transform2D;

        public MagicEmitterBehavior()
        {
            for (var i = 0; i < 13; i++)
            {
                var magic = new Magic();
                this.magicPool.Objects.Add(magic);
            }
        }

        private Vector2 MagicEmittingLocation => new Vector2(this.transform2D.Position.X, this.transform2D.Position.Y + this.transform2D.Rectangle.Height * 0.4f);

        protected override void Update(TimeSpan gameTime)
        {
            this.timer += gameTime.TotalMilliseconds;

            // At every delay, take one Magic which is out of the map and put it at the end of the broom
            if (this.timer >= Delay)
            {
                Magic magic = this.magicPool.AvailableObjects.FirstOrDefault();

                // If there are no available magic, do nothing.
                if (magic == null)
                {
                    return;
                }

                // Change position to player
                magic.EntityTransform.Position = this.MagicEmittingLocation;

                if (!this.EntityManager.Contains(magic))
                {
                    this.EntityManager.Add(magic);
                }

                this.timer = 0;
            }
        }
    }
}