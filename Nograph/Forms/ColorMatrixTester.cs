using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ColorMatrixTester : Form
    {
        public ColorMatrixTester()
        {
            InitializeComponent();
        }

        private float[][] _matrix;
        private Image _image;
        private Graphics _graphics;

        private void ColorMatrixTester_Load(object sender, EventArgs e)
        {
            const int w = 5;
            const int h = 5;
            _matrix = new float[w][];

            for (var x = 0; x < w; x++)
            {
                _matrix[x] = new float[h];
                for (var y = 0; y < h; y++)
                {
                    var num = new NumericUpDown
                    {
                        Size = new Size(64, 20),
                        Minimum = -1,
                        Maximum = 1,
                        DecimalPlaces = 2,
                        Value = 0,
                        Tag = x * 10 + y,
                        Left = x * 80,
                        Top = y * 32,
                        Increment = 0.05m
                    };
                    num.ValueChanged += Num_ValueChanged;
                    panel1.Controls.Add(num);
                }
            }

            _image = BrushLibrary.Brushes[0];
            pictureBox1.Image = _image;
            _graphics = Graphics.FromImage(_image);
        }

        private void Num_ValueChanged(object sender, EventArgs e)
        {
            var num = (NumericUpDown) sender;
            var x = (int) num.Tag / 10;
            var y = (int) num.Tag % 10;
            _matrix[x][y] = (float) num.Value;

            var textForm = "";
            for (x = 0; x < 5; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    textForm += $"{_matrix[x][y]}f, ";
                }

                textForm += "\n";
            }

            label1.Text = textForm;

            pictureBox1.Image = Utils.ColorizeBitmap((Bitmap)_image, new ColorMatrix(_matrix));
        }
    }
}
