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
    }
}
