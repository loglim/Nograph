using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class NewFileDialog : Form
    {
        public int ImageWidth => (int) WidthInput.Value;
        public int ImageHeight => (int) HeightInput.Value;
        public Color BackgroundColor => colorPicker1.Color;
        public bool TransparentBackground => TransparentBackgroundcheckBox.Checked;

        public NewFileDialog()
        {
            InitializeComponent();
            Utils.AddDialogEscapeCancel(this);
        }

        private void NewFileDialog_Load(object sender, EventArgs e)
        {
        }

        private void colorPicker1_OnColorChanged(Color color)
        {

        }

        private void colorPalette1_OnColorFocused(Color color)
        {
            colorPicker1.Color = color;
        }

        private void colorPalette1_OnColorPicked(Color color)
        {
            colorPalette1.Hide();
        }

        private void colorPicker1_Click(object sender, EventArgs e)
        {
            colorPalette1.Visible = !colorPalette1.Visible;
        }

        private void TransparentBackgroundcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = TransparentBackgroundcheckBox.Checked;
            colorPicker1.Enabled = !check;
            if(check)
            {
                colorPalette1.Hide();
            }
        }
    }
}
