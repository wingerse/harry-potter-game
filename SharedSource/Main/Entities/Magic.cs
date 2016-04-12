namespace HarryPotter.Entities
{
    using HarryPotter.Behaviors;
    using HarryPotter.Scenes;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Animation;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class Magic : BaseDecorator
    {
        public Magic()
        {
            this.Entity =
                new Entity().AddComponent(new Transform2D { DrawOrder = GamePlayScene.HarryDrawOrder})
                            .AddComponent(new SpriteAtlas(WaveContent.Assets.Sprites.Magic_spritesheet))
                            .AddComponent(new SpriteAtlasRenderer())
                            .AddComponent(new Animation2D { CurrentAnimation = "Anim", PlayAutomatically = true })
                            .AddComponent(new MagicMovementBehavior(new Vector2(-150, 0)));
            this.EntityTransform = this.Entity.FindComponent<Transform2D>();

            // Set initial position
            this.EntityTransform.Position = new Vector2(-this.EntityTransform.Position.X);

        }

        public Transform2D EntityTransform { get; }

        public bool IsOutOfMap => this.EntityTransform.Position.X <= -this.EntityTransform.Rectangle.Width;
    }
}