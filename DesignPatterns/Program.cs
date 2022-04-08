using System;

namespace DesignPatterns
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Game1.Instance.Run();
        }
    }
}
