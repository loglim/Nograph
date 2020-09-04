using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ColorPicker : UserControl
    {
        public Color Color
        {
            get => BackColor;
            set => BackColor = value;
        }

        public event ColorChangedEvent OnColorChanged;

        public delegate void ColorChangedEvent(Color color);

        public ColorPicker()
        {
            InitializeComponent();
        }

        private void ColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            /*using (var dialog = new ColorDialog())
            {
                dialog.Color = Color;
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                Color = dialog.Color;
                OnColorChanged?.Invoke(Color);
            }*/
        }
    }
}
