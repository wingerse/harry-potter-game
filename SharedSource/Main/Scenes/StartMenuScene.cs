namespace HarryPotter.Scenes
{
    using System;

    using HarryPotter.Behaviors.SceneBehaviors;

    using WaveEngine.Components.Cameras;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Components.UI;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Managers;
    using WaveEngine.Framework.Services;
    using WaveEngine.Framework.UI;

    internal class StartMenuScene : Scene
    {
        protected override void CreateScene()
        {
            this.VirtualScreenManager.Activate(App.PreferredWidth, App.PreferredHeight, StretchMode.Uniform);

            this.AddSceneBehavior(new StartMenuSceneBehavior(), SceneBehavior.Order.PostUpdate);

            var camera = new FixedCamera2D("defaultCamera");
            this.EntityManager.Add(camera);

            var background = new Entity("background");
            background.AddComponent(new Transform2D()).AddComponent(new Sprite(WaveContent.Assets.Sprites.StartMenuBackground_jpg)).AddComponent(new SpriteRenderer());
            this.EntityManager.Add(background);

            this.CreateUi();
        }

        private void CreateUi()
        {
            var startGame = new TextBlock { Text = "Start game", FontPath = WaveContent.Assets.Font_TTF, Margin = new Thickness(350, 500, 0, 0) };
            this.EntityManager.Add(startGame);

            var exit = new TextBlock { Text = "Exit", FontPath = WaveContent.Assets.Font_TTF, Margin = new Thickness(350, 550, 0, 0) };
            this.EntityManager.Add(exit);
        }
    }
}