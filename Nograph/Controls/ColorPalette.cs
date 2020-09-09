using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ColorPalette : UserControl
    {
        // Public
        public delegate void ColorPickEvent(Color color);

        public event ColorPickEvent OnColorPicked;
        public event ColorPickEvent OnColorFocused;

        // Private
        private Bitmap _bmp;
        private Graphics _gfx;
        private Color _lastFocusedColor = Color.Empty;
        private int MaxPalleteId = 11;
        private int ActivePalleteId = 0;
        private int width;
        private int height;
        private Rectangle BoundingBox;
        private int gridSize = 12;
        private int rows;
        private int colls;
        private const int GridSizeMin = 4;
        private const int GridSizeMax = 64;

        public ColorPalette()
        {
            InitializeComponent();
        }

        private void ColorPalette_Load(object sender, EventArgs e)
        {
            MouseWheel += ColorPalette_MouseWheel;
            BoundingBox = new Rectangle(1, 1, Width - 1, Height - PalleteNumberLabel.Height - 1);
            width = BoundingBox.Width;
            height = BoundingBox.Height;
            DrawPalette();
        }

        private void ColorPalette_MouseWheel(object sender, MouseEventArgs e)
        {
            var change = Math.Sign(e.Delta) * (gridSize / 12 + 1);
            gridSize = Utils.Clamp(GridSizeMin, GridSizeMax, gridSize - change);
            DrawPalette();
        }

        private void DrawPalette()
        {
            BackgroundImage?.Dispose();
            _bmp = new Bitmap(Width, Height);
            _gfx = Graphics.FromImage(_bmp);
            rows = colls = gridSize;
            float pw = (float)width / colls;
            float ph = (float)height / rows;
            float space = 0;

            for (var y = 0; y < rows; y++)
            {
                for (var x = 0; x < colls; x++)
                {
                    var c = Color.Empty;
                    switch (ActivePalleteId)
                    {
                        case 0: c = PalleteType1(x, y); break;
                        case 1: c = PalleteOne(x, y, Color.Red); break;
                        case 2: c = PalleteOne(x, y, Color.Green); break;
                        case 3: c = PalleteOne(x, y, Color.Blue); break; //c = PalleteType3(x, y); break;
                        case 4: c = PalleteTypeMono(x, y, Color.Red); break;
                        case 5: c = PalleteTypeMono(x, y, Color.Lime); break;
                        case 6: c = PalleteTypeMono(x, y, Color. Blue); break;
                        case 7: c = PalleteTypeMono(x, y, Color.Yellow); break;
                        case 8: c = PalleteTypeMono(x, y, Color.Magenta); break;
                        case 9: c = PalleteTypeMono(x, y, Color.Cyan); break;
                        case 10: c = PalleteTypeMono(x, y, Color.White); break;
                    }

                    _gfx.FillRectangle(new SolidBrush(c), (pw + space) * x, (ph + space) * y, pw, ph);
                }
            }

            PalleteNumberLabel.Text = $"Pallete {ActivePalleteId + 1} / {MaxPalleteId}";
            _gfx.Save();
            BackgroundImage = _bmp;
        }

        private Color PalleteType1(int x, int y)
        {
            var gradient = new Color[]
            {
                Color.FromArgb(0,0,0),
                Color.FromArgb(255,0,255),
                Color.FromArgb(255,0,0),
                Color.FromArgb(255,255,0),
                Color.FromArgb(0,255,0),
                Color.FromArgb(0,255,255),
                Color.FromArgb(0,0,255),
                Color.FromArgb(255,255,255)
            };

            float aw = (float)colls / gradient.Length;
            int i = (int)(x / aw);

            var c1 = gradient[i > 0 ? i : 0];
            var c2 = gradient[i < gradient.Length - 1 ? i + 1 : gradient.Length - 1];

            var relX = (float)(x - i * aw);

            var pos = relX / aw;
            var r = Utils.Lerp(c1.R, c2.R, pos);
            var g = Utils.Lerp(c1.G, c2.G, pos);
            var b = Utils.Lerp(c1.B, c2.B, pos);
            var light = 1 - (float)y / rows;

            return Color.FromArgb((int)(light * r), (int)(light * g), (int)(light * b));
        }

        private Color PalleteType2(int x, int y)
        {
            var third = rows / 3;
            var k = 255 / colls * 1;
            var q = 255 / rows * 3;

            // TODO
            if (y < third)
            {
                return Color.FromArgb(255 - y * k, 0, 0);
            }
            else if (y < 2 * third)
            {
                return Color.FromArgb(0, 255 - y * k, 0);
            }
            else
            {
                return Color.FromArgb(0, 0, 255 - y * k);
            }

            /*var third = colls / 3;
            var k = 255 / colls * 3;
            var q = 255 / rows * 1;

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

            /*if (x < third)
            {
                return Color.FromArgb(255 - x * k, y * q, y * q);
            }
            else if (x < 2 * third)
            {
                return Color.FromArgb(255 - y * q, 255 - (x - third) * k, 255 - y * q);
            }
            else
            {
                return Color.FromArgb(y * q, y * q, (x - 2 * third) * k);
            }*/
        }

        private Color PalleteType3(int x, int y)
        {
            var third = rows / 3;
            var k = 255 / colls * 1;
            var q = 255 / rows * 3;

            // TODO
            if (y < third)
            {
                return Color.FromArgb(255 - y * k, 255, 255);
            }
            else if (y < 2 * third)
            {
                return Color.FromArgb(255, 255 - y * k, 255);
            }
            else
            {
                return Color.FromArgb(255, 255, 255 - y * k);
            }
        }

        private Color PalleteType4(int x, int y)
        {
            var third = rows / 3;
            var k = 255 / colls * 1;
            var q = 255 / rows * 3;

            // TODO
            if (y < third)
            {
                return Color.FromArgb(255 - y * k, 255, 255);
            }
            else if (y < 2 * third)
            {
                return Color.FromArgb(255, 255 - y * k, 255);
            }
            else
            {
                return Color.FromArgb(255, 255, 255 - y * k);
            }
        }

        private Color PalleteTypeMono(int x, int y, Color color)
        {
            var i = 1 - (float)y / (colls - 1);
            var r = (int)Utils.Lerp(0, color.R, i);
            var g = (int)Utils.Lerp(0, color.G, i);
            var b = (int)Utils.Lerp(0, color.B, i);
            return Color.FromArgb(r, g, b);
        }

        private Color PalleteOne(int x, int y, Color color)
        {
            var i = 1 - (float)y / (colls - 1);

            var r = color.R > 0;
            var g = color.G > 0;
            var b = color.B > 0;

            var full = (int)(255 * i);
            var other = (int)(Utils.Lerp(0, 255, 1f - (float)x / (colls - 1)) * i);
            return Color.FromArgb(r ? full : other, g ? full : other, b ? full : other);
        }

        /*private static float Lerp2D(int x, int y, int w, int h, int a1, int a2, int a3)
        {
            return 
        }*/

        private void ColorPallete_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void ColorPallete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OnColorPicked?.Invoke(((Bitmap)BackgroundImage).GetPixel(e.X, e.Y));
            }
        }

        private void ColorPallete_MouseMove(object sender, MouseEventArgs e)
        {
            var focusedColor = ((Bitmap)BackgroundImage).GetPixel(e.X, e.Y);
            if (focusedColor == _lastFocusedColor) return;

            _lastFocusedColor = focusedColor;
            OnColorFocused?.Invoke(focusedColor);
        }

        private void ChangePalette()
        {
            ActivePalleteId++;
            if (ActivePalleteId >= MaxPalleteId)
                ActivePalleteId = 0;

            DrawPalette();
        }

        private void ColorPalette_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ChangePalette();
            }
        }

        private void PalleteNumberLabel_Click(object sender, EventArgs e)
        {
            ChangePalette();
        }
    }
}
