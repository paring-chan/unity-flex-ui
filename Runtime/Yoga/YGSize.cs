using System.Runtime.InteropServices;

namespace Gilzoide.FlexUi.Yoga
{
    [StructLayout(LayoutKind.Sequential)]
    public struct YGSize
    {
        public float Width;
        public float Height;

        public YGSize(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
