namespace HarryPotter.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Behaviors;

    using Models;

    using Scenes;

    using WaveEngine.Common.Math;
    using WaveEngine.Components.Graphics2D;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class Map : BaseDecorator
    {
        public const float Width = 32 * 30;

        public Map()
        {
            this.Obstacles = new List<Obstacle>();

            this.Entity = new Entity().AddComponent(new Transform2D { DrawOrder = GamePlayScene.MapDrawOrder })
                                      .AddComponent(new MapMovementBehavior(new Vector2(-180f, 0)));
            this.EntityTransform = this.Entity.FindComponent<Transform2D>();

            // Set initial position, which is out of map.
            this.EntityTransform.Position = new Vector2(-Width, 0);

            this.FillEmptyTiles();
        }

        public Map(int[][] mapSkeleton)
            : this()
        {
            this.SetTiles(mapSkeleton);
        }

        public Map(int[][] mapSkeleton, Vector2 position)
            : this(mapSkeleton)
        {
            this.EntityTransform.Position = position;
        }

        public Transform2D EntityTransform { get; }

        public bool IsOutOfMap => this.EntityTransform.Position.X <= -Width;

        public List<Obstacle> Obstacles { get; }

        public Entity[,] Tiles { get; } = new Entity[20, 30];

        public void AddObstacle(Obstacle obstacle)
        {
            this.Obstacles.Add(obstacle);
            this.Entity.AddChild(obstacle.Entity);
        }

        public void ClearObstacles()
        {
            this.Obstacles.ForEach(o => this.Entity.RemoveChild(o.Name));
            this.Obstacles.Clear();
        }

        public void SetTiles(int[][] mapSkeleton)
        {
            ValidateMapSkeleton(mapSkeleton);

            for (var y = 0; y < 20; y++)
            {
                for (var x = 0; x < 30; x++)
                {
                    this.Tiles[y, x].FindComponent<SpriteAtlas>().TextureName = Models.Tiles.GetPath(mapSkeleton[y][x]);
                }
            }
        }

        private static void ValidateMapSkeleton(int[][] mapSkeleton)
        {
            if (mapSkeleton.Length != 20)
            {
                throw new ArgumentException(nameof(mapSkeleton), "Map skeleton should contain 20 rows");
            }

            if (mapSkeleton.Any(row => row.Length != 30))
            {
                throw new ArgumentException(nameof(mapSkeleton), "Each row of map skeleton should have 30 columns");
            }
        }

        private void FillEmptyTiles()
        {
            for (var y = 0; y < 20; y++)
            {
                for (var x = 0; x < 30; x++)
                {
                    // Position (Relative to parent) is 32 pixels times the index because 32 pixels is the width of each tile
                    Entity tile =
                        new Entity().AddComponent(new Transform2D { Position = new Vector2(x * 32, y * 32) })
                                    .AddComponent(new SpriteAtlas(WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet))
                                    .AddComponent(new SpriteAtlasRenderer())
                                    .AddComponent(new PolygonColliderSpriteAtlas(TileBoundingBoxes.Vertices));

                    this.Tiles[y, x] = tile;

                    // Add the tile as a child so that it will move as this Map moves
                    this.Entity.AddChild(tile);
                }
            }
        }
    }
}
