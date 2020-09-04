using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ColorPalette : UserControl
    {
        public delegate void ColorPickEvent(Color color);

        public event ColorPickEvent OnColorPicked;
        public event ColorPickEvent OnColorFocused;

        private Bitmap _bmp;
        private Color _lastFocusedColor = Color.Empty;

        public ColorPalette()
        {
            InitializeComponent();

            _bmp = new Bitmap(Width, Height);
            var g = Graphics.FromImage(_bmp);

            const int w = 24;
            const int h = 24;
            const int pw = 3;
            const int ph = 3;
            const int space = 0;

            var third = w / 3;
            var horizontal = true;
            var k = 255 / w * (horizontal ? 3 : 1);
            var q = 255 / h * (horizontal ? 1 : 3);

            for (var x = 0; x < w; x++)
            {
                for (var y = 0; y < h; y++)
                {
                    var c = Color.Empty;
                    if (horizontal)
                    {
                        // Cyan/Magenta/Yellow
                        /*if (x < third)
                        {
                            c = Color.FromArgb(255 / (x * k + 1), y * k, y * 16);
                        }
                        else if (x < 2 * third)
                        {
                            c = Color.FromArgb(y * k, 255 / (x * k + 1), y * 16);
                        }
                        else
                        {
                            c = Color.FromArgb(y * k, y * 16, 255 / (x * k + 1));
                        }*/

                        if (x < third)
                        {
                            c = Color.FromArgb(255 - x * k, y * q, y * q);
                        }
                        else if (x < 2 * third)
                        {
                            c = Color.FromArgb(255 - y * q, 255 - (x - third) * k, 255 - y * q);
                        }
                        else
                        {
                            c = Color.FromArgb(y * q, y * q, (x - 2 * third) * k);
                        }
                    }
                    else
                    {
                        // TODO
                    }

                    g.FillRectangle(new SolidBrush(c), x * (pw + space), y * (ph + space), pw, ph);
                }
            }

            g.Save();
            BackgroundImage = _bmp;
        }

        private void ColorPallete_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ColorPallete_MouseDown(object sender, MouseEventArgs e)
        {
            OnColorPicked?.Invoke(((Bitmap)BackgroundImage).GetPixel(e.X, e.Y));
        }

        private void ColorPallete_MouseMove(object sender, MouseEventArgs e)
        {
            var focusedColor = ((Bitmap)BackgroundImage).GetPixel(e.X, e.Y);
            if (focusedColor == _lastFocusedColor) return;

            _lastFocusedColor = focusedColor;
            OnColorFocused?.Invoke(focusedColor);
        }
    }
}
