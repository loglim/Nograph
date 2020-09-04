using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nograph
{
    public partial class ResizeDialog : Form
    {
        public int TargetWidth { get; private set; }
        public int TargetHeight { get; private set; }
        public bool ShouldResize => TargetWidth != _origWidth || TargetHeight != _origHeight;

        private readonly int _origWidth;
        private readonly int _origHeight;
        private decimal _aspect;

        public ResizeDialog(Image image)
        {
            InitializeComponent();
            Utils.AddDialogEscapeCancel(this);

            TargetWidth = _origWidth = image.Width;
            TargetHeight = _origHeight = image.Height;
            WidthInput.Value = _origWidth;
            HeightInput.Value = _origHeight;
            CalcAspect();
        }

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

        private void WidthInput_ValueChanged(object sender, EventArgs e)
        {
            TargetWidth = (int) WidthInput.Value;

            if (keepAspect.Checked)
                HeightInput.Value = Math.Round(TargetWidth / (Aspect == 0 ? 1 : Aspect), 0);
            else
                CalcAspect();

            //UpdateScale();
        }

        private void HeightInput_ValueChanged(object sender, EventArgs e)
        {
            TargetHeight = (int) HeightInput.Value;

            if (keepAspect.Checked)
                WidthInput.Value = Math.Round(TargetHeight * (Aspect == 0 ? 1 : Aspect), 0);
            else
                CalcAspect();
        }

        private void CalcAspect()
        {
            Aspect = (decimal) TargetWidth / TargetHeight;
        }
    }
}
