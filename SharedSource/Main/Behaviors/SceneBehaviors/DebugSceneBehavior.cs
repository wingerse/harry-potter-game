namespace HarryPotter.Behaviors.SceneBehaviors
{
    using System;

    using HarryPotter.Scenes;

    using WaveEngine.Common.Input;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Services;

    internal class DebugSceneBehavior : SceneBehavior
    {
        protected override void ResolveDependencies()
        {
            
        }

        protected override void Update(TimeSpan gameTime)
        {
            if (WaveServices.Input.KeyboardState.IsKeyPressed(Keys.A))
            {
                WaveServices.ScreenContextManager.To(new ScreenContext(new GamePlayScene()));
            }
        }
    }
}