using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ImageScale : UserControl
    {
        // Public
        private readonly PictureBox _pb;
        private decimal _aspect;
        private int _origX;
        private int _origY;
        private bool _move;

        private decimal Aspect
        {
            get => _aspect;
            set
            {
                _aspect = value;
                rateA.Value = GetFraction(_aspect)[0];
                rateB.Value = GetFraction(_aspect)[1];
            }
        }

        public ImageScale(PictureBox pb)
        {
            InitializeComponent();
            _pb = pb;
            SetSize(_pb.Image.Width, _pb.Image.Height);
        }

        private static int[] GetFraction(decimal number)
        {
            decimal numerator = 1;
            var denominator = number;

            while (Math.Round(number, 3) % 1 > (decimal) 0.1)
            {
                numerator++;
                number = denominator * numerator;
            }

            return numerator > 99 || denominator * numerator > 99
                ? new[] {1, 1}
                : new[] {(int) (numerator * denominator), (int) numerator};
        }

        public void SetSize(int w, int h)
        {
            width.Value = w;
            height.Value = h;
            CalcAspect();
            width.ValueChanged += numericUpDown1_ValueChanged;
            height.ValueChanged += numericUpDown2_ValueChanged;
            UpdateScale();
        }

        private void CalcAspect()
        {
            Aspect = width.Value / height.Value;
        }

        private void Parent_Resize(object sender, EventArgs e)
        {
            ValidatePos(Left, Right);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (keepAspect.Checked)
                height.Value = Math.Round(width.Value / Aspect, 0);
            else
                CalcAspect();

            UpdateScale();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (keepAspect.Checked)
                width.Value = Math.Round(height.Value * Aspect, 0);
            else
                CalcAspect();

            UpdateScale();
        }

        private void UpdateScale()
        {
            sc_info.Text = $"Nová velikost = {Math.Round(width.Value, 0)}x{Math.Round(height.Value, 0)}px";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Scale((int) width.Value, (int) height.Value);
        }

        private void Scale(int nw, int nh)
        {
            var bmp = new Bitmap(nw, nh);
            var g = Graphics.FromImage(bmp);
            g.DrawImage(_pb.Image, new Rectangle(0, 0, nw, nh));
            g.Save();
            _pb.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _move = true;
            _origX = Parent.Left + SystemInformation.BorderSize.Width + e.X + 8;
            _origY = Parent.Top + SystemInformation.CaptionHeight + e.Y + 8;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_move) return;

            var nx = Cursor.Position.X - _origX;
            var ny = Cursor.Position.Y - _origY;
            ValidatePos(nx, ny);
        }

        public void ValidatePos(int nx, int ny)
        {
            Left = nx >= 0 && nx <= Parent.ClientSize.Width - Width ? nx : nx < 0 ? 0 : Parent.ClientSize.Width - Width;
            Top = ny >= 0 && ny <= Parent.ClientSize.Height - Height ? ny :
                ny < 0 ? 0 : Parent.ClientSize.Height - Height;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _move = false;
        }

        private void ImageScale_Load(object sender, EventArgs e)
        {
            Parent.Resize += Parent_Resize;
        }

        private void keepAspect_CheckedChanged(object sender, EventArgs e)
        {
            //rateA.Enabled = !keepAspect.Checked;
            //rateB.Enabled = !keepAspect.Checked;
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}