namespace HarryPotter.Behaviors
{
    using System;

    using WaveEngine.Framework;
    using WaveEngine.Framework.Diagnostic;
    using WaveEngine.Framework.Graphics;

    internal class MapDebugBehavior : Behavior
    {
        [RequiredComponent]
        private Transform2D transform2D;

        private readonly string mapName;

        public MapDebugBehavior(string mapName)
        {
            this.mapName = mapName;
        }

        protected override void Update(TimeSpan gameTime)
        {
            Labels.Add(this.mapName, this.transform2D.Position.X);
        }
    }
}
