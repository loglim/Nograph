using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ColorPicker : UserControl
    {
        public Color Color
        {
            get => _color;
            set => _color = BackColor = value;
        }

        public event ColorChangedEvent OnColorChanged;

        public delegate void ColorChangedEvent(Color color);

        private Color _color;

        public ColorPicker()
        {
            InitializeComponent();
        }

        private void ColorPicker_EnabledChanged(object sender, System.EventArgs e)
        {
            if(Enabled)
            {
                BorderStyle = BorderStyle.Fixed3D;
                BackColor = _color;
            }
            else
            {
                BorderStyle = BorderStyle.None;
                BackColor = Color.Gray;
            }
        }
    }
}
