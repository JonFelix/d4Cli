using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace d4Cli.Data
{
    class ClipboardItem
    {
        private string _text;
        private DateTime _timestamp;
        private string _activeWindowHandle;

        public string Text
        {
            get
            {
                return _text;
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return _timestamp;
            }
        }

        public string WindowTitle
        {
            get
            {
                return _activeWindowHandle;
            }
        }

        public ClipboardItem(string text)
        {
            _text = text;
            _timestamp = DateTime.Now;
            _activeWindowHandle = GetActiveWindowTitle();
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if(GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return "";
        }
    }
}
