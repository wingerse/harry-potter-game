namespace HarryPotter.Behaviors
{
    using System;

    using HarryPotter.Animations;
    using HarryPotter.Entities;

    using WaveEngine.Common.Input;
    using WaveEngine.Common.Math;
    using WaveEngine.Components.Animation;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Animation;
    using WaveEngine.Framework.Diagnostic;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Services;

    internal enum HarryState
    {
        WasGoingUp, 
        WasGoingDown
    }

    internal class HarryBehavior : Behavior
    {
        private const float UpSpeed = 200f;

        [RequiredComponent]
        private Animation2D animation2D;

        private HarryState state = HarryState.WasGoingDown;

        [RequiredComponent]
        private Transform2D transform2D;

        protected override void Update(TimeSpan gameTime)
        {
            if (WaveServices.Input.KeyboardState.IsKeyPressed(Keys.Up))
            {
                this.transform2D.Position += new Vector2(0, -UpSpeed) * (float)gameTime.TotalSeconds;

                // Do not let Harry go too up
                if (this.transform2D.Position.Y < 0)
                {
                    this.transform2D.Position = new Vector2(Harry.InitialPosition.X, 0);
                }

                if (this.state == HarryState.WasGoingDown)
                {
                    this.animation2D.StopAnimation();
                    this.animation2D.PlayAnimation(HarryAnimations.InitUp, false);
                }

                if (this.animation2D.State == AnimationState.Stopped)
                {
                    this.animation2D.PlayAnimation(HarryAnimations.Up, true);
                }

                this.state = HarryState.WasGoingUp;
            }
            else
            {
                this.transform2D.Position += new Vector2(0, UpSpeed) * (float)gameTime.TotalSeconds;

                var lowerBound = new Vector2(this.transform2D.Position.X, this.transform2D.Position.Y + this.transform2D.Rectangle.Height);

                // Do not let Harry go too down
                if (lowerBound.Y > App.PreferredHeight)
                {
                    this.transform2D.Position = new Vector2(Harry.InitialPosition.X, App.PreferredHeight - this.transform2D.Rectangle.Height);
                }

                if (this.state == HarryState.WasGoingUp)
                {
                    this.animation2D.PlayAnimation(HarryAnimations.InitDown, false);
                }

                if (this.animation2D.State == AnimationState.Stopped)
                {
                    this.animation2D.PlayAnimation(HarryAnimations.Down, true);
                }

                this.state = HarryState.WasGoingDown;
            }
        }
    }
}