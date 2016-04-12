namespace HarryPotter
{
    using HarryPotter.Scenes;

    using Utils;

    using WaveEngine.Common;
    using WaveEngine.Common.Media;
    using WaveEngine.Framework.Services;

    public class Game : WaveEngine.Framework.Game
    {
        public override void Initialize(IApplication application)
        {
            base.Initialize(application);
            Models.Obstacles.Load();
            WaveServices.RegisterService(new KeyPress());

            var screenContext = new ScreenContext(new WaveEngineScene());
            WaveServices.ScreenContextManager.To(screenContext);

            MusicPlayer musicPlayer = WaveServices.MusicPlayer;
            musicPlayer.Play(new MusicInfo(WaveContent.Assets.Music.music_mp3));
            musicPlayer.IsRepeat = true;
        }
    }
}