using System;

namespace lab5
{
    delegate void KeyHandler(object source, KeyEventArgs args);

    class KeyEventArgs : EventArgs
    {
        public char c;
    }

    class KeyEvent
    {
        public event KeyHandler KeyPress;

        public void OnKeyPress(char key)
        {
            KeyEventArgs args = new KeyEventArgs();
            if (KeyPress != null)
            {
                args.c = key;
                KeyPress(this, args);
            }
        }
    }
}
