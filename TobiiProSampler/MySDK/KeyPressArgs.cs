using System;
using System.Windows.Forms;

namespace MySDK
{
    public class KeyPressArgs : EventArgs
    {
        private Keys keyPressed;
        public Keys KeyPressed { get { return KeyPressed; } }
        internal KeyPressArgs(Keys keyPressed)
        {
            this.keyPressed = keyPressed;
        }

        
    }
}