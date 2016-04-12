namespace HarryPotter.Behaviors.SceneBehaviors
{
    using System;
    using System.Linq;

    using Entities;

    using Scenes;

    using Utils;

    using WaveEngine.Common.Graphics;
    using WaveEngine.Components.Animation;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Animation;
    using WaveEngine.Framework.Graphics;
    using WaveEngine.Framework.Managers;
    using WaveEngine.Framework.Services;

    internal class CollisionDetectionBehavior : SceneBehavior
    {
        private readonly Harry harry;
        private readonly MapGenerationBehavior mapGenerationBehavior;
        private readonly ScoreBehavior scoreBehavior;

        private bool isDead = false;
        private Entity explosion;

        public CollisionDetectionBehavior(Harry harry, MapGenerationBehavior mapGenerationBehavior, ScoreBehavior scoreBehavior)
        {
            this.harry = harry;
            this.mapGenerationBehavior = mapGenerationBehavior;
            this.scoreBehavior = scoreBehavior;
        }

        protected override void ResolveDependencies()
        {
        }

        protected override void Update(TimeSpan gameTime)
        {
            if (!this.isDead)
            {
                var harryPolygonCollider = this.harry.Entity.FindComponent<PolygonColliderSpriteAtlas>();

                var intersected = false;
                foreach (Entity tile in this.mapGenerationBehavior.MapPool.Objects.SelectMany(m => m.Tiles.Cast<Entity>()).Where(e => e.IsVisible))
                {
                    // Ignore transparent tiles. They can't be collided with.
                    if (tile.FindComponent<SpriteAtlas>().TextureIndex == 0)
                    {
                        continue;
                    }

                    var tilePolygonCollider = tile.FindComponent<PolygonColliderSpriteAtlas>();

                    if (PolygonColliderSpriteAtlas.Intersects(tilePolygonCollider, harryPolygonCollider))
                    {
                        intersected = true;
                        this.harry.Entity.FindComponent<SpriteAtlas>().TintColor = Color.Red;
                        tile.FindComponent<SpriteAtlas>().TintColor = Color.Red;
                        // this.Death();
                        // return;
                    }
                    else
                    {
                        tile.FindComponent<SpriteAtlas>().TintColor = Color.White;
                    }
                }

                foreach (Entity obstacleEntity in this.mapGenerationBehavior.MapPool.Objects.SelectMany(m => m.Obstacles.Select(o => o.Entity)).Where(o => o.IsVisible))
                {
                    var obstaclePolygonCollider = obstacleEntity.FindComponent<PolygonCollider>();
                    if (PolygonColliderBase.Intersects(harryPolygonCollider, obstaclePolygonCollider))
                    {
                        intersected = true;
                        this.harry.Entity.FindComponent<SpriteAtlas>().TintColor = Color.Red;
                        obstacleEntity.FindComponent<Sprite>().TintColor = Color.Red;
                        // this.Death();
                        // return;
                    }
                    else
                    {
                        obstacleEntity.FindComponent<Sprite>().TintColor = Color.White;
                    }
                }

                if (!intersected)
                {
                    this.harry.Entity.FindComponent<SpriteAtlas>().TintColor = Color.White;
                }
            }
            else
            {
                if (this.explosion.FindComponent<Animation2D>().State == AnimationState.Stopped)
                {
                    WaveServices.ScreenContextManager.To(new ScreenContext(new DeathScene(this.scoreBehavior.Score, new FileSystemScoreStorage("score"))));
                }
            }
        }

        private void Death()
        {
            Transform2D harryTransform = this.harry.Entity.FindComponent<Transform2D>();
            EntityManager entityManager = this.Scene.EntityManager;

            entityManager.Remove(this.harry);
            this.explosion = new Entity().AddComponent(new Transform2D { Position = harryTransform.Position, DrawOrder = GamePlayScene.HarryDrawOrder})
                                         .AddComponent(new SpriteAtlas(WaveContent.Assets.Sprites.Explosion_spritesheet))
                                         .AddComponent(new SpriteAtlasRenderer())
                                         .AddComponent(new Animation2D());
            entityManager.Add(this.explosion);
            this.explosion.FindComponent<Animation2D>().PlayAnimation("Anim", false);
            this.isDead = true;
        }
    }
}
