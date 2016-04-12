namespace HarryPotter.Scenes
{
    using System;

    using WaveEngine.Common.Graphics;
    using WaveEngine.Common.Math;
    using WaveEngine.Components.Cameras;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Services;

    internal class WaveEngineScene : Scene
    {
        protected override void CreateScene()
        {
            this.EntityManager.Add(new FixedCamera2D("defaultCamera") { BackgroundColor = Color.White});
            this.EntityManager.Add(new Entity()
                .AddComponent(new Transform2D {Position = new Vector2(240, 480), Origin = Vector2.Center})
                .AddComponent(new Sprite(WaveContent.Assets.Sprites.WaveLogo_png))
                .AddComponent(new SpriteRenderer()));
            WaveServices.TimerFactory.CreateTimer(TimeSpan.FromSeconds(5), () =>
                                                                           WaveServices.ScreenContextManager.To(new ScreenContext(new StartMenuScene())), false, this);
        }
    }
}
