namespace HarryPotter.Behaviors.SceneBehaviors
{
    using System;
    using System.Collections.Generic;

    using Scenes;

    using Utils;

    using WaveEngine.Common.Input;
    using WaveEngine.Common.Math;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Services;

    internal class StartMenuSceneBehavior : SceneBehavior
    {
        private MenuBehavior menuBehavior;

        protected override void Update(TimeSpan gameTime)
        {
            if (WaveServices.GetService<KeyPress>().IsKeyPress(Keys.Enter))
            {
                switch (this.menuBehavior.Index)
                {
                    case 0:
                        WaveServices.ScreenContextManager.To(new ScreenContext(new LoadingScene(new GamePlayScene())));
                        break;
                    case 1:
                        WaveServices.Platform.Exit();
                        break;
                }
            }
        }

        protected override void ResolveDependencies()
        {
            this.menuBehavior = new MenuBehavior(new List<Vector2> { new Vector2(350, 530), new Vector2(350, 580) });
            this.Scene.EntityManager.Add(new Entity()
                                             .AddComponent(new Transform2D { DrawOrder = -1 })
                                             .AddComponent(new Sprite(WaveContent.Assets.Sprites.MenuOver_png))
                                             .AddComponent(new SpriteRenderer())
                                             .AddComponent(this.menuBehavior));
        }
    }
}