using System;

namespace MySDK
{
    public class MouseEventArgs : EventArgs
    {
        public ButtonState LeftButton { get; set; }
        public ButtonState RightButton { get; set; }
        public ButtonState MiddleButton { get; set; }

        public float ScrollY { get; set; }

        internal MouseEventArgs(ButtonState left, ButtonState right, 
            ButtonState middle, float scrollY)
        {
            LeftButton = left;
            RightButton = right;
            MiddleButton = middle;
            ScrollY = scrollY;
        }
        internal MouseEventArgs(ButtonState left, ButtonState right,
            ButtonState middle) : this(left, right, middle, 0) { }
        internal MouseEventArgs(float scroll) : this(ButtonState.None,
            ButtonState.None, ButtonState.None, scroll) { }
    }
}