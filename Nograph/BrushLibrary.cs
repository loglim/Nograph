using System.Drawing;
using System.IO;

namespace Nograph
{
    internal class BrushLibrary
    {
        private static BrushLibrary _instance = new BrushLibrary();

        public static Image[] Brushes { get; private set; }

        public BrushLibrary()
        {
            // Load brushes all available
            const string dir = @"..\..\gfx\";
            var brushFiles = Directory.GetFiles(dir, "*.png");
            Brushes = new Image[brushFiles.Length];
            for (var i = 0; i < brushFiles.Length; i++)
            {
                Brushes[i] = Utils.LoadBitmapFromFile(brushFiles[i]);
            }
        }
    }
}
