namespace HarryPotter
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using WaveEngine.Framework.Services;

    using Application = WaveEngine.Adapter.Application;
    using ButtonState = WaveEngine.Common.Input.ButtonState;

    public sealed class App : Application
    {
        public const int PreferredHeight = 640;
        public const int PreferredWidth = 480;

        private Game game;

        public App()
        {
            Instance = this;
            this.Width = PreferredWidth;
            this.Height = PreferredHeight;
            this.FullScreen = false;
            this.WindowTitle = "Harry Potter";
        }

        public static App Instance { get; private set; }

        public override void Draw(TimeSpan elapsedTime)
        {
            if (this.game != null && !this.game.HasExited)
            {
                this.game.DrawFrame(elapsedTime);
            }
        }

        public override void Initialize()
        {
            this.Form.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            this.game = new Game();
            this.game.Initialize(this);
        }

        /// <summary>
        ///     Called when [activated].
        /// </summary>
        public override void OnActivated()
        {
            base.OnActivated();
            this.game?.OnActivated();
        }

        /// <summary>
        ///     Called when [deactivate].
        /// </summary>
        public override void OnDeactivate()
        {
            base.OnDeactivate();
            this.game?.OnDeactivated();
        }

        public override void Update(TimeSpan elapsedTime)
        {
            if (this.game == null || this.game.HasExited)
            {
                return;
            }

            if (WaveServices.Input.KeyboardState.Escape == ButtonState.Pressed)
            {
                WaveServices.Platform.Exit();
            }
            else
            {
                this.game.UpdateFrame(elapsedTime);
            }
        }
    }
}