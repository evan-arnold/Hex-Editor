using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SHex
{
    class W32
    {
        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr MonitorFromWindow(IntPtr hwnd, int dwFlags);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr MonitorFromRect([In] ref RECT lprc, int dwFlags);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr MonitorFromPoint(POINT pt, int dwFlags);

        internal const int MONITORINFOF_PRIMARY = 0x00000001;
        internal const int MONITOR_DEFAULTTONEAREST = 0x00000002;
        internal const int MONITOR_DEFAULTTONULL = 0x00000000;
        internal const int MONITOR_DEFAULTTOPRIMARY = 0x00000001;

        [StructLayout(LayoutKind.Sequential)]
        internal struct POINT
        {
            internal int x;
            internal int y;

            internal POINT(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            internal int left;
            internal int top;
            internal int right;
            internal int bottom;
        }

        [DllImport("Shcore.dll", SetLastError = true)]
        internal static extern int GetDpiForMonitor(IntPtr hmonitor, Monitor_DPI_Type dpiType, out uint dpiX, out uint dpiY);

        internal enum Monitor_DPI_Type : int
        {
            MDT_Effective_DPI = 0,
            MDT_Angular_DPI = 1,
            MDT_Raw_DPI = 2,
            MDT_Default = MDT_Effective_DPI
        }

        internal static short GetLoWord(int dword)
        {
            return (short)(dword & 0xffff);
        }

        [DllImport("Gdi32.dll", SetLastError = true)]
        internal static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        internal const int LOGPIXELSX = 88;

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);
    }
}
