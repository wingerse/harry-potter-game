namespace HarryPotter.Behaviors.SceneBehaviors
{
    using System;
    using System.Linq;

    using Entities;

    using Models;

    using Utils;

    using WaveEngine.Common.Math;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Graphics;

    internal class MapGenerationBehavior : SceneBehavior
    {
        private const int DifficultyIncrementScore = 200;

        private readonly ScoreBehavior scoreBehavior;
        private Map lastMap;
        private int difficulty = 1;


        public MapGenerationBehavior(ScoreBehavior scoreBehavior)
        {
            this.scoreBehavior = scoreBehavior;

            this.MapPool.Objects.Add(new Map());
            this.MapPool.Objects.Add(new Map());
            this.MapPool.Objects.Add(new Map(Maps.Map0, new Vector2(0, 0)));
        }

        public ObjectPool<Map> MapPool { get; } = new ObjectPool<Map>(m => m.IsOutOfMap);

        protected override void ResolveDependencies()
        {
            foreach (Map map in this.MapPool.Objects)
            {
                this.Scene.EntityManager.Add(map);
            }
            this.lastMap = this.MapPool.Objects.Last();
        }

        protected override void Update(TimeSpan gameTime)
        {
            foreach (Map map in this.MapPool.AvailableObjects)
            {
                this.ForwardMap(map);
            }

            this.difficulty = this.scoreBehavior.Score / DifficultyIncrementScore + 1;
        }

        private void ForwardMap(Map map)
        {
            Transform2D lastMapTransform = this.lastMap.EntityTransform;
            var newPosition = new Vector2(lastMapTransform.Position.X + Map.Width, lastMapTransform.Y);
            map.EntityTransform.Position = newPosition;

            Tuple<int, int[][]> randomMap = Maps.RandomMap;
            map.SetTiles(randomMap.Item2);

            map.ClearObstacles();
            foreach (Obstacle obstacle in Obstacles.GetObstacles(randomMap.Item1, this.difficulty))
            {
                map.AddObstacle(obstacle);
            }

            this.lastMap = map;
        }
    }
}
