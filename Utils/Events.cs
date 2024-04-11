using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RoseTibiaBot
{
    public class Events(IntPtr hwnd)
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;

        private const int MK_LBUTTON = 0x0001;
        private const int MK_RBUTTON = 0x0002;

        private static readonly string[] keys = {
        "F1", "F2", "F3", "F4", "F5", "F6",
        "F7", "F8", "F9", "F10", "F11", "F12"
    };

        private static int[] virtualKeys = {
        0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A, 0x7B
    };

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern short GetKeyState(int vKey);

        public void Keystroke(string key)
        {
            int index = Array.IndexOf(keys, key);
            if (index >= 0)
            {
                int virtualKey = virtualKeys[index];
                SendMessage(hwnd, WM_KEYDOWN, (IntPtr)virtualKey, IntPtr.Zero);
                SendMessage(hwnd, WM_KEYUP, (IntPtr)virtualKey, IntPtr.Zero);
            }
        }

        public void Mouse_Right_Click(Point position)
        {
            SetCursorPos(position.X, position.Y);
            SendMessage(hwnd, WM_MOUSEMOVE, IntPtr.Zero, (IntPtr)(position.Y << 16 | position.X));
            SendMessage(hwnd, WM_RBUTTONDOWN, (IntPtr)MK_RBUTTON, (IntPtr)(position.Y << 16 | position.X));
            Thread.Sleep(100);
            SendMessage(hwnd, WM_RBUTTONUP, IntPtr.Zero, (IntPtr)(position.Y << 16 | position.X));

        }

        public void Mouse_Left_Click(Point position)
        {
            SetCursorPos(position.X, position.Y);
            SendMessage(hwnd, WM_MOUSEMOVE, IntPtr.Zero, (IntPtr)(position.Y << 16 | position.X));
            SendMessage(hwnd, WM_LBUTTONDOWN, (IntPtr)MK_LBUTTON, (IntPtr)(position.Y << 16 | position.X));
            Thread.Sleep(100);
            SendMessage(hwnd, WM_LBUTTONUP, IntPtr.Zero, (IntPtr)(position.Y << 16 | position.X));

        }

    }
}
