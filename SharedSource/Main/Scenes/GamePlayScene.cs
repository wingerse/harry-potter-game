namespace HarryPotter.Scenes
{
    using HarryPotter.Behaviors;
    using HarryPotter.Behaviors.SceneBehaviors;
    using HarryPotter.Entities;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Cameras;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Managers;
    using WaveEngine.Framework.Services;

    internal class GamePlayScene : Scene
    {
        public const float SkyboardDrawOrder = 0;
        public const float CastleBoardDrawOrder = -1;
        public const float MagicBoard1DrawOrder = -2;
        public const float MagicBoard2DrawOrder = -3;
        public const float MapDrawOrder = -4;
        public const float HarryDrawOrder = -5;

        protected override void CreateScene()
        {
            this.VirtualScreenManager.Activate(App.PreferredWidth, App.PreferredHeight, StretchMode.Uniform);

            var camera = new FixedCamera2D("defaultCamera2D");
            this.EntityManager.Add(camera);

            this.AddBackground();

            var harry = new Harry();
            this.EntityManager.Add(harry);

            var scoreBehavior = new ScoreBehavior();
            var mapGenerationBehavior = new MapGenerationBehavior(scoreBehavior);
            this.AddSceneBehavior(mapGenerationBehavior, SceneBehavior.Order.PreUpdate);
            this.AddSceneBehavior(new CollisionDetectionBehavior(harry, mapGenerationBehavior, scoreBehavior), SceneBehavior.Order.PostUpdate);
            this.AddSceneBehavior(scoreBehavior, SceneBehavior.Order.PostUpdate);
#if DEBUG
            this.AddSceneBehavior(new DebugSceneBehavior(), SceneBehavior.Order.PostUpdate);
#endif
        }

        private void AddBackground()
        {
            Entity skyboard =
                new Entity("skyboard").AddComponent(new Transform2D { DrawOrder = SkyboardDrawOrder })
                                      .AddComponent(new Sprite(WaveContent.Assets.Sprites.SkyBoard_png))
                                      .AddComponent(new SpriteRenderer())
                                      .AddComponent(new BackgroundMovementBehavior(new Vector2(-20, 0)));
            this.EntityManager.Add(skyboard);

            Entity castleboard =
                new Entity("castleboard").AddComponent(new Transform2D { DrawOrder = CastleBoardDrawOrder, Position = new Vector2(0, 380) })
                                         .AddComponent(new Sprite(WaveContent.Assets.Sprites.CastleBoard_png))
                                         .AddComponent(new SpriteRenderer())
                                         .AddComponent(new BackgroundMovementBehavior(new Vector2(-40, 0)));
            this.EntityManager.Add(castleboard);

            Entity magicboard1 =
                new Entity("magicboard1").AddComponent(new Transform2D { DrawOrder = MagicBoard1DrawOrder })
                                         .AddComponent(new Sprite(WaveContent.Assets.Sprites.MagicBoard_png))
                                         .AddComponent(new SpriteRenderer())
                                         .AddComponent(new BackgroundMovementBehavior(new Vector2(-200, 0)));
            this.EntityManager.Add(magicboard1);

            Entity magicboard2 =
                new Entity("magicboard2").AddComponent(new Transform2D { DrawOrder = MagicBoard2DrawOrder, Position = new Vector2(-50, 0) })
                                         .AddComponent(new Sprite(WaveContent.Assets.Sprites.MagicBoard_png))
                                         .AddComponent(new SpriteRenderer())
                                         .AddComponent(new BackgroundMovementBehavior(new Vector2(-220, 0)));
            this.EntityManager.Add(magicboard2);
        }
    }
}