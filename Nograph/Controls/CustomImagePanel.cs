using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    internal class CustomImagePanel : Panel
    {
        protected override Point ScrollToControl(Control activeControl)
        {
            return DisplayRectangle.Location;
        }
    }
}
