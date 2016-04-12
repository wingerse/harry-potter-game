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

    internal class DeathSceneBehavior : SceneBehavior
    {
        private MenuBehavior menuBehavior;

        protected override void ResolveDependencies()
        {
            this.menuBehavior = new MenuBehavior(new List<Vector2> { new Vector2(35, 400), new Vector2(35, 500) });
            this.Scene.EntityManager.Add(new Entity()
                                             .AddComponent(new Transform2D {DrawOrder = -2})
                                             .AddComponent(new Sprite(WaveContent.Assets.Sprites.ButtonOver_png))
                                             .AddComponent(new SpriteRenderer())
                                             .AddComponent(this.menuBehavior));
        }

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
                        WaveServices.ScreenContextManager.To(new ScreenContext(new StartMenuScene()));
                        break;
                }
            }
        }
    }
}
