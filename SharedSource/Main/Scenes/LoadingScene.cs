namespace HarryPotter.Scenes
{
    using WaveEngine.Common.Graphics;
    using WaveEngine.Components.Cameras;
    using WaveEngine.Framework;
    using WaveEngine.Framework.Services;

    internal class LoadingScene : Scene
    {
        private readonly Scene sceneToLoad;

        public LoadingScene(Scene sceneToLoad)
        {
            this.sceneToLoad = sceneToLoad;
        }

        protected override async void CreateScene()
        {
            this.EntityManager.Add(new FixedCamera2D("defaultCamera2D") { BackgroundColor = Color.Black });
            await System.Threading.Tasks.Task.Run(() => this.sceneToLoad.Initialize(WaveServices.GraphicsDevice));
            WaveServices.ScreenContextManager.To(new ScreenContext(this.sceneToLoad));
        }
    }
}
