namespace HarryPotter.Behaviors.SceneBehaviors
{
    using System;

    using WaveEngine.Common.Graphics;
    using WaveEngine.Components.UI;
    using WaveEngine.Framework;
    using WaveEngine.Framework.UI;

    internal class ScoreBehavior : SceneBehavior
    {
        private TextBlock textBlock;
        private float timer;

        public int Score { get; private set; }

        protected override void ResolveDependencies()
        {
            this.textBlock = new TextBlock
            {
                Foreground = Color.Yellow,
                Margin = new Thickness(5, 5, 0, 0),
                BorderColor = Color.Black,
                FontPath = WaveContent.Assets.Font_TTF,
                Text = string.Empty
            };

            this.Scene.EntityManager.Add(this.textBlock);
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.timer += (float)gameTime.TotalMilliseconds;
            if (this.timer >= 200)
            {
                this.Score++;
                this.textBlock.Text = this.Score.ToString();
                this.timer = 0;
            }
        }
    }
}
