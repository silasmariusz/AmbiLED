using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
//DX
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
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

namespace epiLight
{
    public static class GlobalVariables //A public static class to store global variables
    {
        //An int to store the average colors in the following pattern:
        //Red = L, Green = G, Blue = B
        //Left = L, Top = T, Right = R
        //{RL,RT,RR,GL,GT,GR,BL,BT,BR}
        //This is because the microcontroller receives the data in this order
        public static int[] PreviousColor30 = new int[9];
        public static int[] PreviousColor29 = new int[9];
        public static int[] PreviousColor28 = new int[9];
        public static int[] PreviousColor27 = new int[9];
        public static int[] PreviousColor26 = new int[9];
        public static int[] PreviousColor25 = new int[9];
        public static int[] PreviousColor24 = new int[9];
        public static int[] PreviousColor23 = new int[9];
        public static int[] PreviousColor22 = new int[9];
        public static int[] PreviousColor21 = new int[9];
        public static int[] PreviousColor20 = new int[9];
        public static int[] PreviousColor19 = new int[9];
        public static int[] PreviousColor18 = new int[9];
        public static int[] PreviousColor17 = new int[9];
        public static int[] PreviousColor16 = new int[9];
        public static int[] PreviousColor15 = new int[9];
        public static int[] PreviousColor14 = new int[9];
        public static int[] PreviousColor13 = new int[9];
        public static int[] PreviousColor12 = new int[9];
        public static int[] PreviousColor11 = new int[9];
        public static int[] PreviousColor10 = new int[9];
        public static int[] PreviousColor9 = new int[9];
        public static int[] PreviousColor8 = new int[9];
        public static int[] PreviousColor7 = new int[9];
        public static int[] PreviousColor6 = new int[9];
        public static int[] PreviousColor5 = new int[9];
        public static int[] PreviousColor4 = new int[9];
        public static int[] PreviousColor3 = new int[9];
        public static int[] PreviousColor2 = new int[9];
        public static int[] PreviousColor = new int[9];
        //An int to count: 0 = left, 1 = top, 2 = right
        //Values to determine what region control what lights
        //From top left to bottom right in the following way:
        //Top,Left,Bottom,Right
        public static short[] TopLightScan = new short[4];
        public static short[] LeftLightScan = new short[4];
        public static short[] RightLightScan = new short[4];
        public static int[] RealByte = new int[9];
        public static byte[] SendByte = new byte[9];
        public static byte[] OldSendByte = new byte[9];

        public static int Offset = 0;       
        public static bool enabled;
        public static int mode; //0 = movie, 1 = gaming
        public static int Counter = 0;
        public static int[] CurrentColor = new int[9];
        public static bool blackframe = false;
        public static int NrDisplays;
        public static int SelectedDisplay;

        public static int ColorIncP;
        public static int ColorIncTemp;

    }
}
