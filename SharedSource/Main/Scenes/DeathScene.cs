namespace HarryPotter.Scenes
{
    using Behaviors.SceneBehaviors;

    using Utils;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Cameras;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Components.UI;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Managers;
    using WaveEngine.Framework.UI;

    internal class DeathScene : Scene
    {
        private readonly int score;
        private readonly int highScore;

        public DeathScene(int score, IScoreStorage scoreStorage)
        {
            this.score = score;
            this.highScore = scoreStorage.GetScore();
            if (this.score > this.highScore)
            {
                scoreStorage.SaveScore(this.score);
                this.highScore = this.score;
            }
        }

        protected override void CreateScene()
        {
            this.VirtualScreenManager.Activate(App.PreferredWidth, App.PreferredHeight, StretchMode.Uniform);

            this.AddSceneBehavior(new DeathSceneBehavior(), SceneBehavior.Order.PostUpdate);

            this.EntityManager.Add(new FixedCamera2D("defaultCamera"));
            this.EntityManager.Add(
                new Entity().AddComponent(new Transform2D()).AddComponent(new Sprite(WaveContent.Assets.Sprites.BackgroundBoard_png)).AddComponent(new SpriteRenderer()));

            this.EntityManager.Add(new TextBlock()
            {
                FontPath = WaveContent.Assets.Font_TTF,
                Margin = new Thickness(200, 30, 0, 0),
                Text = "You died!"
            });

            this.EntityManager.Add(new TextBlock()
            {
                FontPath = WaveContent.Assets.Font_TTF,
                Margin = new Thickness(150, 70, 0, 0),
                Text = $"Your score: {this.score}!"
            });

            this.EntityManager.Add(new TextBlock()
            {
                FontPath = WaveContent.Assets.Font_TTF,
                Margin = new Thickness(150, 110, 0, 0),
                Text = $"Your High score: {this.highScore}!"
            });

            this.EntityManager.Add(new Entity()
                                       .AddComponent(new Transform2D { Position = new Vector2(35, 400), DrawOrder = -1})
                                       .AddComponent(new Sprite(WaveContent.Assets.Sprites.Button_png))
                                       .AddComponent(new SpriteRenderer()));

            this.EntityManager.Add(new TextBlock()
            {
                DrawOrder = -3,
                FontPath = WaveContent.Assets.Font_TTF,
                Margin = new Thickness(210, 450, 0, 0),
                Text = "Restart"
            });

            this.EntityManager.Add(new Entity()
                                       .AddComponent(new Transform2D { Position = new Vector2(35, 500), DrawOrder = -1})
                                       .AddComponent(new Sprite(WaveContent.Assets.Sprites.Button_png))
                                       .AddComponent(new SpriteRenderer()));

            this.EntityManager.Add(new TextBlock()
            {
                DrawOrder = -3,
                FontPath = WaveContent.Assets.Font_TTF,
                Margin = new Thickness(190, 550, 0, 0),
                Text = "Main Menu"
            });
        }
    }
}