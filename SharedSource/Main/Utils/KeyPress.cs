namespace HarryPotter.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using WaveEngine.Common;
    using WaveEngine.Common.Input;
    using WaveEngine.Framework.Diagnostic;
    using WaveEngine.Framework.Services;

    internal class KeyPress : Service
    {
        private readonly Dictionary<Keys, ButtonState> previousKeyStates = new Dictionary<Keys, ButtonState>
        {
            [Keys.A] = ButtonState.Release,
            [Keys.B] = ButtonState.Release,
            [Keys.Back] = ButtonState.Release,
            [Keys.C] = ButtonState.Release,
            [Keys.CapsLock] = ButtonState.Release,
            [Keys.Crsel] = ButtonState.Release,
            [Keys.D] = ButtonState.Release,
            [Keys.Delete] = ButtonState.Release,
            [Keys.D0] = ButtonState.Release,
            [Keys.D1] = ButtonState.Release,
            [Keys.D2] = ButtonState.Release,
            [Keys.D3] = ButtonState.Release,
            [Keys.D4] = ButtonState.Release,
            [Keys.D5] = ButtonState.Release,
            [Keys.D6] = ButtonState.Release,
            [Keys.D7] = ButtonState.Release,
            [Keys.D8] = ButtonState.Release,
            [Keys.D9] = ButtonState.Release,
            [Keys.Down] = ButtonState.Release,
            [Keys.E] = ButtonState.Release,
            [Keys.Enter] = ButtonState.Release,
            [Keys.Escape] = ButtonState.Release,
            [Keys.Execute] = ButtonState.Release,
            [Keys.F] = ButtonState.Release,
            [Keys.F1] = ButtonState.Release,
            [Keys.F10] = ButtonState.Release,
            [Keys.F11] = ButtonState.Release,
            [Keys.F12] = ButtonState.Release,
            [Keys.F2] = ButtonState.Release,
            [Keys.F3] = ButtonState.Release,
            [Keys.F4] = ButtonState.Release,
            [Keys.F5] = ButtonState.Release,
            [Keys.F6] = ButtonState.Release,
            [Keys.F7] = ButtonState.Release,
            [Keys.F8] = ButtonState.Release,
            [Keys.F9] = ButtonState.Release,
            [Keys.G] = ButtonState.Release,
            [Keys.H] = ButtonState.Release,
            [Keys.I] = ButtonState.Release,
            [Keys.J] = ButtonState.Release,
            [Keys.K] = ButtonState.Release,
            [Keys.L] = ButtonState.Release,
            [Keys.Left] = ButtonState.Release,
            [Keys.LeftAlt] = ButtonState.Release,
            [Keys.LeftControl] = ButtonState.Release,
            [Keys.LeftShift] = ButtonState.Release,
            [Keys.LeftWindows] = ButtonState.Release,
            [Keys.M] = ButtonState.Release,
            [Keys.N] = ButtonState.Release,
            [Keys.O] = ButtonState.Release,
            [Keys.P] = ButtonState.Release,
            [Keys.Q] = ButtonState.Release,
            [Keys.R] = ButtonState.Release,
            [Keys.Right] = ButtonState.Release,
            [Keys.RightAlt] = ButtonState.Release,
            [Keys.RightControl] = ButtonState.Release,
            [Keys.RightShift] = ButtonState.Release,
            [Keys.RightWindows] = ButtonState.Release,
            [Keys.S] = ButtonState.Release,
            [Keys.Space] = ButtonState.Release,
            [Keys.Subtract] = ButtonState.Release,
            [Keys.T] = ButtonState.Release,
            [Keys.Tab] = ButtonState.Release,
            [Keys.U] = ButtonState.Release,
            [Keys.Up] = ButtonState.Release,
            [Keys.V] = ButtonState.Release,
            [Keys.W] = ButtonState.Release,
            [Keys.X] = ButtonState.Release,
            [Keys.Y] = ButtonState.Release,
            [Keys.Z] = ButtonState.Release,
        };

        protected override void Initialize()
        {
        }

        protected override void Terminate()
        {
        }

        public bool IsKeyPress(Keys key)
        {
            bool isCurrentlyPressed = WaveServices.Input.KeyboardState.IsKeyPressed(key);
            bool previouslyReleased = this.previousKeyStates[key] == ButtonState.Release;

            this.previousKeyStates[key] = isCurrentlyPressed ? ButtonState.Pressed : ButtonState.Release;

            return  isCurrentlyPressed && previouslyReleased;
        }
    }
}
