namespace HarryPotter
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using (var app = new App())
            {
                app.Run();
            }
        }
    }
}