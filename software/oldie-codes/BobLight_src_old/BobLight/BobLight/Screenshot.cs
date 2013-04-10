using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
/*
Copyright 2006-2007 Bob van Loosen

This file is part of BobLight.

BobLight is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.

BobLight is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Foobar; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/


namespace BobLight
{
    class GDI32
    {
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int x, int y);


        

    }
        class User32
        {
            [DllImport("User32.dll")]
            public static extern int GetDesktopWindow();
            [DllImport("User32.dll")]
            public static extern IntPtr GetWindowDC(int hWnd);
            [DllImport("User32.dll")]
            public static extern IntPtr GetDC(int hWnd);
            [DllImport("User32.dll")]
            public static extern int ReleaseDC(int hWnd, IntPtr hDC);
            //[DllImport("User32.dll")]
            //public static extern IntPtr GetDCEx(int hWnd, uint hrgnClip, uint flags);
            [DllImport("user32.dll")]
            public static extern IntPtr GetDCEx(int hWnd, int hrgnClip, int flags);
        }

}