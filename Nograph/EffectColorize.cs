using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Nograph
{
    public partial class EffectColorize : Form
    {
        // Constants
        private const float ForceMin = 0.5f;

        // Private
        private Bitmap _origBmp;
        private float _force;

        public EffectColorize()
        {
            InitializeComponent();
            Utils.AddDialogEscapeCancel(this);
        }

        private void BWEffect_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _force = (float) trackBar1.Value / 100 + ForceMin;
            UpdatePreview();
        }

        private void ShowContrastLevel()
        {
            var f = (int) Math.Round((_force - ForceMin - 1) * 100);
            label3.Text = Math.Abs(f - 0.1f) == 0 ? "+/- 0%" : f >= 0 ? $"+{f}%" : $"{f}%";
        }

        private void UpdatePreview()
        {
            if (_origBmp == null) return;

            PreviewPictureBox.Image = null;
            float r = radioButton1.Checked ? 1 : 0;
            float g = radioButton2.Checked ? 1 : 0;
            float b = radioButton3.Checked ? 1 : 0;

            if (radioButton4.Checked)
            {
                r = g = b = 1f;
            }

            if (radioButton6.Checked)
            {
                r = (float) CustomColorPanel.BackColor.R / 255;
                g = (float) CustomColorPanel.BackColor.G / 255;
                b = (float) CustomColorPanel.BackColor.B / 255;
            }

            float[][] colorMatrix;
            if (radioButton5.Checked)
            {
                colorMatrix = new[]
                {
                    new[] {-1 * _force, 0, 0, 0, 0},
                    new[] {0, -1 * _force, 0, 0, 0},
                    new[] {0, 0, -1 * _force, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {1, 1, 1, 0, 1}
                };
            }
            else
            {
                /*colorMatrix = new[]
                {
                    new[] {.3f * _force * r, .3f * _force * g, .3f * _force * b, 0, 0},
                    new[] {.59f * _force * r, .59f * _force * g, .59f * _force * b, 0, 0},
                    new[] {.11f * _force * r, .11f * _force * g, .11f * _force * b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                };*/

                colorMatrix = new[]
                {
                    new[] {0f, 0f, 0f, -1f, 0f},
                    new[] {0f, 0f, 0f, 0, 0f},
                    new[] {0f, 0f, 0f, 0, 0f},
                    new[] {r * _force, g * _force, b * _force, 1f, 0f},
                    new[] {0f, 0f, 0f, 0f, 0f}
                };
            }

            /*Bitmap newBitmap = new Bitmap(_origBmp.Width, _origBmp.Height);
            using (Graphics gr = Graphics.FromImage(newBitmap)) // SourceImage is a Bitmap object
            {
                //var gray_matrix = new float[][] {
                //new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                //new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                //new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                //new float[] { 0,      0,      0,      1, 0 },
                //new float[] { 0,      0,      0,      0, 1 }             

                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(_colorMatrix);
                Rectangle rc = new Rectangle(0, 0, _origBmp.Width, _origBmp.Height);
                gr.DrawImage(_origBmp, rc, 0, 0, _origBmp.Width, _origBmp.Height, GraphicsUnit.Pixel, ia);
            }*/

            ColMatrix = new ColorMatrix(colorMatrix);
            PreviewPictureBox.Image = Utils.ColorizeBitmap(_origBmp, ColMatrix);
            ShowContrastLevel();
        }

        public void SetBitmap(Bitmap bmp)
        {
            _origBmp = Utils.CreateImagePreview(bmp, PreviewPictureBox.Width, PreviewPictureBox.Height);
            _force = 1f + ForceMin;
            UpdatePreview();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apply = true;
            Close();
        }

        private void CustomColorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) return;

            CustomColorPanel.BackColor = colorDialog.Color;
            UpdatePreview();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            CustomColorPanel.Visible = radioButton6.Checked;
            UpdatePreview();
        }

        public ColorMatrix ColMatrix { get; private set; }

        public bool Apply { get; private set; }
    }
}
