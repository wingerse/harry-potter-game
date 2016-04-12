namespace HarryPotter.Behaviors
{
    using System;
    using System.Collections.Generic;

    using Utils;

    using WaveEngine.Common.Input;
    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Services;

    internal class MenuBehavior : Behavior
    {
        private readonly List<Vector2> positions;

        [RequiredComponent]
        private Transform2D transform2D;

        public MenuBehavior(List<Vector2> positions)
        {
            this.positions = positions;
        }

        public int Index { get; private set; }

        protected override void Update(TimeSpan gameTime)
        {
            if (WaveServices.GetService<KeyPress>().IsKeyPress(Keys.Up))
            {
                this.Index--;
                if (this.Index < 0)
                {
                    this.Index = this.positions.Count - 1;
                }
            }

            if (WaveServices.GetService<KeyPress>().IsKeyPress(Keys.Down))
            {
                this.Index++;
                if (this.Index == this.positions.Count)
                {
                    this.Index = 0;
                }
            }

            this.transform2D.Position = this.positions[this.Index];
        }
    }
}
