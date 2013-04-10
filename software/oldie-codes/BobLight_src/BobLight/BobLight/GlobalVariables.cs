using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
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
    public static class GlobalVariables //A public static class to store global variables
    {
        //An int to store the average colors in the following pattern:
        //Red = L, Green = G, Blue = B
        //Left = L, Top = T, Right = R
        //{RL,RT,RR,GL,GT,GR,BL,BT,BR}
        //This is because the microcontroller receives the data in this order
        public static int[] PreviousColor2 = new int[9];
        public static int[] PreviousColor = new int[9];
        //An int to count: 0 = left, 1 = top, 2 = right
        //Values to determine what region control what lights
        //From top left to bottom right in the following way:
        //Top,Left,Bottom,Right
        public static short[] TopLightScan = new short[4];
        public static short[] LeftLightScan = new short[4];
        public static short[] RightLightScan = new short[4];
        public static byte[] SendByte = new byte[9];
        public static byte[] OldSendByte = new byte[9];
        public static int DeskHandle = User32.GetDesktopWindow();
        public static IntPtr DeskDC = new IntPtr();//User32.GetWindowDC(DeskHandle);
        //public static IntPtr DeskDC2 = User32.GetDCEx((IntPtr)DeskHandle, (IntPtr)0, (IntPtr)1024);
        public static int Offset = 0;       
        public static bool enabled;
        public static int mode; //0 = movie, 1 = gaming
        public static int Counter = 0;
        public static int[] CurrentColor = new int[9];
        public static bool blackframe = false;
        public static int NrDisplays;
        public static int SelectedDisplay;
    }
}
