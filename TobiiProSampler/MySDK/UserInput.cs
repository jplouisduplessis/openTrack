using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySDK
{
    public delegate void KeyInputHandler(KeyPressArgs args);
    public delegate void MouseInputHandler(MouseEventArgs args);
    public class UserInput
    {
        private static Lazy<UserInput> input = new Lazy<UserInput>(() =>
        { return new UserInput(); });

        public static UserInput Instance { get { return input.Value; } }

        public event MouseInputHandler MouseScroll;
        public event MouseInputHandler MousePressed;
        public event KeyInputHandler KeyPressed;

        private UserInput()
        {

        }
    }
}
