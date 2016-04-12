namespace HarryPotter.Entities
{
    using HarryPotter.Animations;
    using HarryPotter.Behaviors;
    using HarryPotter.Scenes;

    using Models;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Animation;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Physics2D;

    internal class Harry : BaseDecorator
    {
        public static readonly Vector2 InitialPosition = new Vector2(100, 200);

        public Harry()
        {
            this.Entity = new Entity("harry").AddComponent(new Transform2D { DrawOrder = GamePlayScene.HarryDrawOrder, Position = InitialPosition })
                                   .AddComponent(new SpriteAtlas(WaveContent.Assets.Sprites.Harry_spritesheet))
                                   .AddComponent(new SpriteAtlasRenderer())
                                   .AddComponent(new Animation2D { CurrentAnimation = HarryAnimations.Down, PlayAutomatically = true })
                                   .AddComponent(new HarryBehavior())
                                   .AddComponent(new MagicEmitterBehavior())
                                   .AddComponent(new PolygonColliderSpriteAtlas(HarryBoundingBoxes.AnimationVertices));
        }
    }
}