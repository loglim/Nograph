namespace Nograph
{
    internal static class Extensions
    {
        public static float Clamp(this float value, float min, float max) => value > max ? max : value < min ? min : value;

        public static int Clamp(this int value, int min, int max) => value > max ? max : value < min ? min : value;

        public static double Clamp(this double value, double min, double max) => value > max ? max : value < min ? min : value;

        public static decimal Clamp(this decimal value, decimal min, decimal max) => value > max ? max : value < min ? min : value;
    }
}
