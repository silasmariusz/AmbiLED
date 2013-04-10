using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Xml;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

        }

        public Bitmap b;

        public Graphics g;

        private int swidth, sheight, c = 0, CyclesInt = 0;


        public class DWM
        {
            [DllImport("dwmapi.dll", PreserveSig = false)]
            public static extern void DwmEnableComposition(bool bEnable);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumScreens();

            XmlDocument settings = new XmlDataDocument();
            settings.Load(Application.StartupPath + "\\settings.xml");
            XmlElement root = settings.DocumentElement;
            for (int I = 0; I < root.ChildNodes.Count; I++)
            {
                if (root.ChildNodes[I].Name == "comport")
                {
                    txtPortname.Text = root.ChildNodes[I].InnerText;
                }

                else if (root.ChildNodes[I].Name == "baudrate")
                {
                    comboBaud.Text = root.ChildNodes[I].InnerText;
                }
                else if (root.ChildNodes[I].Name == "CaptureEvery")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        CaptureEvery.Checked = true;
                    }
                }
                else if (root.ChildNodes[I].Name == "CaptureCycles")
                {
                    CaptureCycles.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "color")
                {
                    Colorslider.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "minimized")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                }
                else if (root.ChildNodes[I].Name == "mode")
                {
                    if (root.ChildNodes[I].InnerText == "movie")
                    {
                        GlobalVariables.mode = 0;                        
                        ModeCombo.Text = "Movie";
                        ModeCombo2.Text = "Movie";
                    }
                    else if (root.ChildNodes[I].InnerText == "gaming")
                    {
                        GlobalVariables.mode = 1;
                        ModeCombo.Text = "Gaming";
                        ModeCombo2.Text = "Gaming";
                        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                    }
                    else if (root.ChildNodes[I].InnerText == "10*movie smooth")
                    {
                        GlobalVariables.mode = 2;
                        ModeCombo.Text = "10*Movie smooth";
                        ModeCombo2.Text = "10*Movie smooth";
                        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                    }
                    else if (root.ChildNodes[I].InnerText == "30*movie smooth")
                    {
                        GlobalVariables.mode = 3;
                        ModeCombo.Text = "30*Movie smooth";
                        ModeCombo2.Text = "30*Movie smooth";
                        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                    }
                    else if (root.ChildNodes[I].InnerText == "10*movie smooth+fast scene")
                    {
                        GlobalVariables.mode = 3;
                        ModeCombo.Text = "10*movie smooth+fast scene";
                        ModeCombo2.Text = "10*movie smooth+fast scene";
                        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                    }
                }
                else if (root.ChildNodes[I].Name == "fsr")
                {
                    fsr.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "aggressivelevel")
                {
                    AggressiveLevel.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "colorincsmooth")
                {
                    ColorIncSmooth.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "smoothdarkness")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        SmoothDarkness.Checked = true;
                    }
                    else
                    {
                        SmoothDarkness.Checked = false;
                    }
                }
                else if (root.ChildNodes[I].Name == "expand")
                {
                    if (root.ChildNodes[I].InnerText == "1")
                    {
                        radioButton1.Checked = true;                 
                    }
                    else if (root.ChildNodes[I].InnerText == "2")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton3.Checked = true;
                    }
                }
                else if (root.ChildNodes[I].Name == "maxmultiply")
                {
                    numericUpDown1.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "RedLeft")
                    RedLeft.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RedTop")
                    RedTop.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RedRight")
                    RedRight.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenLeft")
                    GreenLeft.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenTop")
                    GreenTop.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenRight")
                    GreenRight.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueLeft")
                    BlueLeft.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueTop")
                    BlueTop.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueRight")
                    BlueRight.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);

                else if (root.ChildNodes[I].Name == "RedLeftOnExit")
                    RedLeftOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RedTopOnExit")
                    RedTopOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RedRightOnExit")
                    RedRightOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenLeftOnExit")
                    GreenLeftOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenTopOnExit")
                    GreenTopOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "GreenRightOnExit")
                    GreenRightOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueLeftOnExit")
                    BlueLeftOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueTopOnExit")
                    BlueTopOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "BlueRightOnExit")
                    BlueRightOnExit.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);


                else if (root.ChildNodes[I].Name == "LeftScanBegin")
                    LeftBegin.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "LeftScanEnd")
                    LeftEnd.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "TopScanBegin")
                    TopBegin.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "TopScanEnd")
                    TopEnd.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RightScanBegin")
                    RightBegin.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "RightScanEnd")
                    RightEnd.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "Interval")
                {
                    CaptureTimer.Interval = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                    TimerDelay.Value = CaptureTimer.Interval;
                }
                else if (root.ChildNodes[I].Name == "Display")
                {
                    if (Convert.ToInt32(root.ChildNodes[I].InnerText, 10) <= GlobalVariables.NrDisplays)
                    {
                        DisplaysBox.Text = "Display " + root.ChildNodes[I].InnerText;
                        GlobalVariables.SelectedDisplay = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                    }
                    else
                    {
                        DisplaysBox.Text = "Display 0";
                        GlobalVariables.SelectedDisplay = 0;
                    }
                }
                else if (root.ChildNodes[I].Name == "DivideLevel")
                    DivideLevel.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "OffsetLevel")
                    OffsetLevel.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                else if (root.ChildNodes[I].Name == "AutoEnable")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        AutoEnable.Checked = true;
                        EnableBtn.Enabled = false;
                    }
                    else
                    {
                        AutoEnable.Checked = false;
                    }
                }
                else if (root.ChildNodes[I].Name == "ProcessName")
                {
                    ProcessName.Text = root.ChildNodes[I].InnerText;
                }
                else if (root.ChildNodes[I].Name == "enabled")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        // DWM.DwmEnableComposition(false);
                        OpenSerial();
                        CaptureTimer.Enabled = true;
                        this.Text = "epiLight.NET";
                        EnableBtn.Text = "Disable";
                        disableToolStripMenuItem.Text = "Disable";

                    }
                    else
                    {
                        CaptureTimer.Enabled = false;
                        this.Text = "epiLight.NET DISABLED";
                        EnableBtn.Text = "Enable";
                        disableToolStripMenuItem.Text = "Enable";
                    }
                }

            }
            
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        
        }


        
        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.mode == 0)
            {
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                DeskCapture();
                int Red = 0, Green = 0, Blue = 0, Average = 0;
                for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                {
                    Red = (GlobalVariables.CurrentColor[I] + GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor2[I]) / 3;
                    Green = (GlobalVariables.CurrentColor[I + 3] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor2[I + 3]) / 3;
                    Blue = (GlobalVariables.CurrentColor[I + 6] + GlobalVariables.PreviousColor[I + 6] + GlobalVariables.PreviousColor2[I + 6]) / 3;
                    //Red = GlobalVariables.PreviousColor[I];
                    //Green = GlobalVariables.PreviousColor[I + 3];
                    //Blue = GlobalVariables.PreviousColor[I + 6];

                    Average = (Red + Green + Blue) / 3;

                    //Increase of color by extrapolation, or interpolation, I don't know :P
                    Red = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Red) / 10);
                    Green = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Green) / 10);
                    Blue = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Blue) / 10);
                    
                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;
                    if (Red < 0) Red = 0;
                    if (Green < 0) Green = 0;
                    if (Blue < 0) Blue = 0;

                    GlobalVariables.SendByte[I] = (byte)Red;
                    GlobalVariables.SendByte[I + 3] = (byte)Green;
                    GlobalVariables.SendByte[I + 6] = (byte)Blue;

                }
            }
            else if (GlobalVariables.mode == 1)
            {
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                GlobalVariables.Counter++;
                if (GlobalVariables.Counter == 10)
                {
                    GlobalVariables.Counter = 0;
                    DeskCapture();
                    int Red = 0, Green = 0, Blue = 0, Average = 0;
                    for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                    {
                        Red = GlobalVariables.PreviousColor[I];
                        Green = GlobalVariables.PreviousColor[I + 3];
                        Blue = GlobalVariables.PreviousColor[I + 6];

                        Average = (Red + Green + Blue) / 3;

                        Red = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Red) / 10);
                        Green = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Green) / 10);
                        Blue = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Blue) / 10);

                        if (Red > 255) Red = 255;
                        if (Green > 255) Green = 255;
                        if (Blue > 255) Blue = 255;
                        if (Red < 0) Red = 0;
                        if (Green < 0) Green = 0;
                        if (Blue < 0) Blue = 0;

                        GlobalVariables.SendByte[I] = (byte)Red;
                        GlobalVariables.SendByte[I + 3] = (byte)Green;
                        GlobalVariables.SendByte[I + 6] = (byte)Blue;

                    }

                }
                else
                {
                    int Red = 0, Green = 0, Blue = 0, Average = 0;
                    for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                    {
                        Red = GlobalVariables.PreviousColor[I] + ((GlobalVariables.CurrentColor[I] - GlobalVariables.PreviousColor[I]) * GlobalVariables.Counter / 10);
                        Green = GlobalVariables.PreviousColor[I + 3] + ((GlobalVariables.CurrentColor[I + 3] - GlobalVariables.PreviousColor[I + 3]) * GlobalVariables.Counter / 10);
                        Blue = GlobalVariables.PreviousColor[I + 6] + ((GlobalVariables.CurrentColor[I + 6] - GlobalVariables.PreviousColor[I + 6]) * GlobalVariables.Counter / 10);


                        
                        Average = (Red + Green + Blue) / 3;

                        Red = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Red) / 10);
                        Green = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Green) / 10);
                        Blue = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Blue) / 10);

                        if (Red > 255) Red = 255;
                        if (Green > 255) Green = 255;
                        if (Blue > 255) Blue = 255;
                        if (Red < 0) Red = 0;
                        if (Green < 0) Green = 0;
                        if (Blue < 0) Blue = 0;

                        GlobalVariables.SendByte[I] = (byte)Red;
                        GlobalVariables.SendByte[I + 3] = (byte)Green;
                        GlobalVariables.SendByte[I + 6] = (byte)Blue;

                    }
                
                
                }

            }
            else if (GlobalVariables.mode == 2)
            {
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
//                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                DeskCapture();
                int Red = 0, Green = 0, Blue = 0, Average = 0;
                for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                {
                    Red = (GlobalVariables.CurrentColor[I] + GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor2[I] + GlobalVariables.PreviousColor3[I] + GlobalVariables.PreviousColor4[I] + GlobalVariables.PreviousColor5[I] + GlobalVariables.PreviousColor6[I] + GlobalVariables.PreviousColor7[I] + GlobalVariables.PreviousColor8[I] + GlobalVariables.PreviousColor9[I]) / 10;
                    Green = (GlobalVariables.CurrentColor[I + 3] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor2[I + 3] + GlobalVariables.PreviousColor3[I + 3] + GlobalVariables.PreviousColor4[I + 3] + GlobalVariables.PreviousColor5[I + 3] + GlobalVariables.PreviousColor6[I + 3] + GlobalVariables.PreviousColor7[I + 3] + GlobalVariables.PreviousColor8[I + 3] + GlobalVariables.PreviousColor9[I + 3]) / 10;
                    Blue = (GlobalVariables.CurrentColor[I + 6] + GlobalVariables.PreviousColor[I + 6] + GlobalVariables.PreviousColor2[I + 6] + GlobalVariables.PreviousColor3[I + 6] + GlobalVariables.PreviousColor4[I + 6] + GlobalVariables.PreviousColor5[I + 6] + GlobalVariables.PreviousColor6[I + 6] + GlobalVariables.PreviousColor7[I + 6] + GlobalVariables.PreviousColor8[I + 6] + GlobalVariables.PreviousColor9[I + 6]) / 10;

                    Average = (Red + Green + Blue) / 3;

                    //Increase of color by extrapolation, or interpolation, I don't know :P
                    Red = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Red) / 10);
                    Green = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Green) / 10);
                    Blue = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Blue) / 10);

                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;
                    if (Red < 0) Red = 0;
                    if (Green < 0) Green = 0;
                    if (Blue < 0) Blue = 0;

                    GlobalVariables.SendByte[I] = (byte)Red;
                    GlobalVariables.SendByte[I + 3] = (byte)Green;
                    GlobalVariables.SendByte[I + 6] = (byte)Blue;

                }
            }
            else if (GlobalVariables.mode == 3)
            {
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                //                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                DeskCapture();
                int Red = 0, Green = 0, Blue = 0, Average = 0;
                for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                {
                    Red = (GlobalVariables.CurrentColor[I] + GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor2[I] + GlobalVariables.PreviousColor3[I] + GlobalVariables.PreviousColor4[I] + GlobalVariables.PreviousColor5[I] + GlobalVariables.PreviousColor6[I] + GlobalVariables.PreviousColor7[I] + GlobalVariables.PreviousColor8[I] + GlobalVariables.PreviousColor9[I]
                        + GlobalVariables.PreviousColor10[I] + GlobalVariables.PreviousColor11[I] + GlobalVariables.PreviousColor12[I] + GlobalVariables.PreviousColor13[I] + GlobalVariables.PreviousColor14[I] + GlobalVariables.PreviousColor15[I] + GlobalVariables.PreviousColor16[I] + GlobalVariables.PreviousColor17[I] + GlobalVariables.PreviousColor18[I] + GlobalVariables.PreviousColor19[I]
                        + GlobalVariables.PreviousColor20[I] + GlobalVariables.PreviousColor21[I] + GlobalVariables.PreviousColor22[I] + GlobalVariables.PreviousColor23[I] + GlobalVariables.PreviousColor24[I] + GlobalVariables.PreviousColor25[I] + GlobalVariables.PreviousColor26[I] + GlobalVariables.PreviousColor27[I] + GlobalVariables.PreviousColor28[I] + GlobalVariables.PreviousColor29[I]
                        + GlobalVariables.PreviousColor30[I]) / 31;
                    Green = (GlobalVariables.CurrentColor[I + 3] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor2[I + 3] + GlobalVariables.PreviousColor3[I + 3] + GlobalVariables.PreviousColor4[I + 3] + GlobalVariables.PreviousColor5[I + 3] + GlobalVariables.PreviousColor6[I + 3] + GlobalVariables.PreviousColor7[I + 3] + GlobalVariables.PreviousColor8[I + 3] + GlobalVariables.PreviousColor9[I + 3]
                          + GlobalVariables.PreviousColor10[I + 3] + GlobalVariables.PreviousColor11[I + 3] + GlobalVariables.PreviousColor12[I + 3] + GlobalVariables.PreviousColor13[I + 3] + GlobalVariables.PreviousColor14[I + 3] + GlobalVariables.PreviousColor15[I + 3] + GlobalVariables.PreviousColor16[I + 3] + GlobalVariables.PreviousColor17[I + 3] + GlobalVariables.PreviousColor18[I + 3] + GlobalVariables.PreviousColor19[I + 3]
                          + GlobalVariables.PreviousColor20[I + 3] + GlobalVariables.PreviousColor21[I + 3] + GlobalVariables.PreviousColor22[I + 3] + GlobalVariables.PreviousColor23[I + 3] + GlobalVariables.PreviousColor24[I + 3] + GlobalVariables.PreviousColor25[I + 3] + GlobalVariables.PreviousColor26[I + 3] + GlobalVariables.PreviousColor27[I + 3] + GlobalVariables.PreviousColor28[I + 3] + GlobalVariables.PreviousColor29[I + 3]
                          + GlobalVariables.PreviousColor30[I + 3]) / 30;
                    Blue = (GlobalVariables.CurrentColor[I + 6] + GlobalVariables.PreviousColor[I + 6] + GlobalVariables.PreviousColor2[I + 6] + GlobalVariables.PreviousColor3[I + 6] + GlobalVariables.PreviousColor4[I + 6] + GlobalVariables.PreviousColor5[I + 6] + GlobalVariables.PreviousColor6[I + 6] + GlobalVariables.PreviousColor7[I + 6] + GlobalVariables.PreviousColor8[I + 6] + GlobalVariables.PreviousColor9[I + 6]
                         + GlobalVariables.PreviousColor10[I + 6] + GlobalVariables.PreviousColor11[I + 6] + GlobalVariables.PreviousColor12[I + 6] + GlobalVariables.PreviousColor13[I + 6] + GlobalVariables.PreviousColor14[I + 6] + GlobalVariables.PreviousColor15[I + 6] + GlobalVariables.PreviousColor16[I + 6] + GlobalVariables.PreviousColor17[I + 6] + GlobalVariables.PreviousColor18[I + 6] + GlobalVariables.PreviousColor19[I + 6]
                         + GlobalVariables.PreviousColor20[I + 6] + GlobalVariables.PreviousColor21[I + 6] + GlobalVariables.PreviousColor22[I + 6] + GlobalVariables.PreviousColor23[I + 6] + GlobalVariables.PreviousColor24[I + 6] + GlobalVariables.PreviousColor25[I + 6] + GlobalVariables.PreviousColor26[I + 6] + GlobalVariables.PreviousColor27[I + 6] + GlobalVariables.PreviousColor28[I + 6] + GlobalVariables.PreviousColor29[I + 6]
                         + GlobalVariables.PreviousColor30[I + 6]) / 30;


                    Average = (Red + Green + Blue) / 3;

                    //Increase of color by extrapolation, or interpolation, I don't know :P
                    Red = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Red) / 10);
                    Green = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Green) / 10);
                    Blue = (10 - (int)Colorslider.Value) * Average / 10 + (((int)Colorslider.Value * Blue) / 10);

                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;
                    if (Red < 0) Red = 0;
                    if (Green < 0) Green = 0;
                    if (Blue < 0) Blue = 0;

                    GlobalVariables.SendByte[I] = (byte)Red;
                    GlobalVariables.SendByte[I + 3] = (byte)Green;
                    GlobalVariables.SendByte[I + 6] = (byte)Blue;

                }
            }
            else if (GlobalVariables.mode == 4)
            {
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                DeskCapture();
                int Red = 0, Green = 0, Blue = 0, Average = 0;
                int ColorInc = 0, rdiff, gdiff, bdiff, currentaverage, previousaverage, rdiff2, gdiff2, bdiff2;
                bool noagressive;
                GlobalVariables.ColorIncTemp = GlobalVariables.ColorIncTemp + 1;
                for (int I = 0; I < 3; I++) //Copy the current color into the send byte array
                {
                    GlobalVariables.RealByte[I] = GlobalVariables.CurrentColor[I];
                    GlobalVariables.RealByte[I + 3] = GlobalVariables.CurrentColor[I + 3];
                    GlobalVariables.RealByte[I + 6] = GlobalVariables.CurrentColor[I + 6];

                    rdiff = GlobalVariables.CurrentColor[I] - GlobalVariables.PreviousColor[I];
                    gdiff = GlobalVariables.CurrentColor[I + 3] - GlobalVariables.PreviousColor[I + 3];
                    bdiff = GlobalVariables.CurrentColor[I + 6] - GlobalVariables.PreviousColor[I + 6];

                    currentaverage = (GlobalVariables.CurrentColor[I] + GlobalVariables.CurrentColor[I + 3] + GlobalVariables.CurrentColor[I + 6]) / 3;
                    previousaverage = (GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor[I + 6]) / 3;

                    noagressive = false;

                    if ( (currentaverage < AggressiveLevel.Value) && (SmoothDarkness.Checked == true) )
                    {
                        noagressive = true;
                    }

                    if ( (rdiff > fsr.Value || gdiff > fsr.Value || bdiff > fsr.Value) && (currentaverage > previousaverage) && (noagressive == false) )
                    {
                        Red = GlobalVariables.CurrentColor[I];
                        Green = GlobalVariables.CurrentColor[I + 3];
                        Blue = GlobalVariables.CurrentColor[I + 6];
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor2, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor3, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor4, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor5, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor6, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor7, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor8, 9);
                        Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor9, 9);
                        c = 0;
                        GlobalVariables.ColorIncP = 0;
                        GlobalVariables.ColorIncTemp = 0;
                    }

                    else if (((rdiff + gdiff + bdiff) / 3 > fsr.Value / 3) || (c < 3 && c > 0))
                    {
                        Red = (GlobalVariables.CurrentColor[I] + GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor2[I]) / 3;
                        Green = (GlobalVariables.CurrentColor[I + 3] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor2[I + 3]) / 3;
                        Blue = (GlobalVariables.CurrentColor[I + 6] + GlobalVariables.PreviousColor[I + 6] + GlobalVariables.PreviousColor2[I + 6]) / 3;
                        c=c+1;
                        if (c == 3)
                        {
                            c = 0;
                        }
                    }
                    else
                    {
                        Red = (GlobalVariables.CurrentColor[I] + GlobalVariables.PreviousColor[I] + GlobalVariables.PreviousColor2[I] + GlobalVariables.PreviousColor3[I] + GlobalVariables.PreviousColor4[I] + GlobalVariables.PreviousColor5[I] + GlobalVariables.PreviousColor6[I] + GlobalVariables.PreviousColor7[I] + GlobalVariables.PreviousColor8[I] + GlobalVariables.PreviousColor9[I]) / 10;
                        Green = (GlobalVariables.CurrentColor[I + 3] + GlobalVariables.PreviousColor[I + 3] + GlobalVariables.PreviousColor2[I + 3] + GlobalVariables.PreviousColor3[I + 3] + GlobalVariables.PreviousColor4[I + 3] + GlobalVariables.PreviousColor5[I + 3] + GlobalVariables.PreviousColor6[I + 3] + GlobalVariables.PreviousColor7[I + 3] + GlobalVariables.PreviousColor8[I + 3] + GlobalVariables.PreviousColor9[I + 3]) / 10;
                        Blue = (GlobalVariables.CurrentColor[I + 6] + GlobalVariables.PreviousColor[I + 6] + GlobalVariables.PreviousColor2[I + 6] + GlobalVariables.PreviousColor3[I + 6] + GlobalVariables.PreviousColor4[I + 6] + GlobalVariables.PreviousColor5[I + 6] + GlobalVariables.PreviousColor6[I + 6] + GlobalVariables.PreviousColor7[I + 6] + GlobalVariables.PreviousColor8[I + 6] + GlobalVariables.PreviousColor9[I + 6]) / 10;
                    }

                    Average = (Red + Green + Blue) / 3;

                    
                    
                    // Color Increasing Smoother
                    ColorInc = 10 + GlobalVariables.ColorIncP;

                    if ((int)Colorslider.Value > 10)
                    {
                        if (GlobalVariables.CurrentColor[I] > GlobalVariables.PreviousColor[I])
                        {
                            rdiff2 = GlobalVariables.CurrentColor[I] - GlobalVariables.PreviousColor[I];
                        }
                        else
                        {
                            rdiff2 = GlobalVariables.PreviousColor[I] - GlobalVariables.CurrentColor[I];
                        }

                        if (GlobalVariables.CurrentColor[I + 3] > GlobalVariables.PreviousColor[I + 3])
                        {
                            gdiff2 = GlobalVariables.CurrentColor[I + 3] - GlobalVariables.PreviousColor[I + 3];
                        }
                        else
                        {
                            gdiff2 = GlobalVariables.PreviousColor[I + 3] - GlobalVariables.CurrentColor[I + 3];
                        }

                        if (GlobalVariables.CurrentColor[I + 6] > GlobalVariables.PreviousColor[I + 6])
                        {
                            bdiff2 = GlobalVariables.CurrentColor[I + 6] - GlobalVariables.PreviousColor[I + 6];
                        }
                        else
                        {
                            bdiff2 = GlobalVariables.PreviousColor[I + 6] - GlobalVariables.CurrentColor[I + 6];
                        }

//                        label40.Text = ColorInc.ToString();

                        if ((rdiff2 < 10 || gdiff2 < 10 || bdiff2 < 10) && (ColorInc < (int)Colorslider.Value))
                        {
                            if (GlobalVariables.ColorIncTemp < (int)ColorIncSmooth.Value)
                            {
                                GlobalVariables.ColorIncTemp = GlobalVariables.ColorIncTemp + 1;
                            }
                            else
                            {
                                GlobalVariables.ColorIncP = GlobalVariables.ColorIncP + 1;
                                GlobalVariables.ColorIncTemp = 0;
                            }
                        }
                        if ((rdiff2 > 10 || gdiff2 > 10 || bdiff2 > 10) && (ColorInc > 10))
                        {
                            GlobalVariables.ColorIncP = GlobalVariables.ColorIncP - 1;
                        }
                    }

//                    label39.Text = ColorInc.ToString();
                    if (this.WindowState != FormWindowState.Minimized)
                    {
                        numericUpDown2.Value = ColorInc;
                    }

                    //Increase of color by extrapolation, or interpolation, I don't know :P
                    Red = (10 - ColorInc) * Average / 10 + ((ColorInc * Red) / 10);
                    Green = (10 - ColorInc) * Average / 10 + ((ColorInc * Green) / 10);
                    Blue = (10 - ColorInc) * Average / 10 + ((ColorInc * Blue) / 10);

//                    label42.Text = Red.ToString();
//                    label43.Text = Green.ToString();
//                    label44.Text = Blue.ToString();

                    if (Red > 255) Red = 255;
                    if (Green > 255) Green = 255;
                    if (Blue > 255) Blue = 255;
                    if (Red < 0) Red = 0;
                    if (Green < 0) Green = 0;
                    if (Blue < 0) Blue = 0;

                    /*
                    // BACKLIGHT!!!!!
                    // make min value
                    if ((int)ColorIncSmooth.Value > 0)
                    {
                        if (Red > 0)
                        {
                            Red = ((255 - (int)ColorIncSmooth.Value) / (255 / Red) + (int)ColorIncSmooth.Value);
                        }
                        else
                        {
                            Red = (int)ColorIncSmooth.Value;
                        }
                        if (Green > 0)
                        {
                            Green = ((255 - (int)ColorIncSmooth.Value) / (255 / Green) + (int)ColorIncSmooth.Value);
                        }
                        else
                        {
                            Green = (int)ColorIncSmooth.Value;
                        }
                        if (Blue > 0)
                        {
                            Blue = ((255 - (int)ColorIncSmooth.Value) / (255 / Blue) + (int)ColorIncSmooth.Value);
                        }
                        else
                        {
                            Blue = (int)ColorIncSmooth.Value;
                        }
                    }
                     */
 

                    GlobalVariables.SendByte[I] = (byte)Red;
                    GlobalVariables.SendByte[I + 3] = (byte)Green;
                    GlobalVariables.SendByte[I + 6] = (byte)Blue;

                }
            }

            //This was added later, so it looks ugly :P


            bool send = true;
            /*
            bool send = false;

            for (int I = 0; I < 9; I++)
            {
                if (GlobalVariables.SendByte[I] != GlobalVariables.OldSendByte[I])
                {
                    send = true;
                }
            }
            */

            //if (true)
            if (send)
            {


                if (this.WindowState != FormWindowState.Minimized) //Show the average colors on screen
                {
                    ColorLeft.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[0], (int)GlobalVariables.SendByte[3], (int)GlobalVariables.SendByte[6]);
                    ColorTop.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[1], (int)GlobalVariables.SendByte[4], (int)GlobalVariables.SendByte[7]);
                    ColorRight.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[2], (int)GlobalVariables.SendByte[5], (int)GlobalVariables.SendByte[8]);
                    label44.Text = GlobalVariables.RealByte[1].ToString() + "/" + GlobalVariables.SendByte[1].ToString();
                    label43.Text = GlobalVariables.RealByte[4].ToString() + "/" + GlobalVariables.SendByte[4].ToString();
                    label42.Text = GlobalVariables.RealByte[7].ToString() + "/" + GlobalVariables.SendByte[7].ToString();
                    label48.Text = GlobalVariables.RealByte[0].ToString() + "/" + GlobalVariables.SendByte[0].ToString();
                    label47.Text = GlobalVariables.RealByte[3].ToString() + "/" + GlobalVariables.SendByte[3].ToString();
                    label45.Text = GlobalVariables.RealByte[6].ToString() + "/" + GlobalVariables.SendByte[6].ToString();
                    label54.Text = GlobalVariables.RealByte[2].ToString() + "/" + GlobalVariables.SendByte[2].ToString();
                    label53.Text = GlobalVariables.RealByte[5].ToString() + "/" + GlobalVariables.SendByte[5].ToString();
                    label52.Text = GlobalVariables.RealByte[8].ToString() + "/" + GlobalVariables.SendByte[8].ToString();
                }
                GlobalVariables.SendByte[0] = (byte)((int)GlobalVariables.SendByte[0] * RedLeft.Value / 255);
                GlobalVariables.SendByte[1] = (byte)((int)GlobalVariables.SendByte[1] * RedTop.Value / 255);
                GlobalVariables.SendByte[2] = (byte)((int)GlobalVariables.SendByte[2] * RedRight.Value / 255);
                GlobalVariables.SendByte[3] = (byte)((int)GlobalVariables.SendByte[3] * GreenLeft.Value / 255);
                GlobalVariables.SendByte[4] = (byte)((int)GlobalVariables.SendByte[4] * GreenTop.Value / 255);
                GlobalVariables.SendByte[5] = (byte)((int)GlobalVariables.SendByte[5] * GreenRight.Value / 255);
                GlobalVariables.SendByte[6] = (byte)((int)GlobalVariables.SendByte[6] * BlueLeft.Value / 255);
                GlobalVariables.SendByte[7] = (byte)((int)GlobalVariables.SendByte[7] * BlueTop.Value / 255);
                GlobalVariables.SendByte[8] = (byte)((int)GlobalVariables.SendByte[8] * BlueRight.Value / 255);
                Send(); //send the values
                //this.Text = "sending";
            }
            else
            {
                //this.Text = "not sending";
            }
            
            Array.Copy(GlobalVariables.SendByte, GlobalVariables.OldSendByte, 9);
            
        }






        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool close = false;
            this.TopMost = false;
/*
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "epiLight", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    close = true;
                }
            }
            else
            {
                close = true;
            }
*/
            close = true;
            if (close)
            {
                XmlDocument settings = new XmlDataDocument();

                settings.Load(Application.StartupPath + "\\settings.xml");
                XmlElement root = settings.DocumentElement;
                for (int I = 0; I < root.ChildNodes.Count; I++)
                {
                    if (root.ChildNodes[I].Name == "comport")
                    {
                        root.ChildNodes[I].InnerText = txtPortname.Text;
                    }

                    else if (root.ChildNodes[I].Name == "baudrate")
                    {
                        root.ChildNodes[I].InnerText = serialPort1.BaudRate.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "CaptureEvery")
                    {
                        if (CaptureEvery.Checked == true)
                        {
                            root.ChildNodes[I].InnerText = "true";
                        }
                        else
                        {
                            root.ChildNodes[I].InnerText = "false";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "CaptureCycles")
                    {
                        root.ChildNodes[I].InnerText = CaptureCycles.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "color")
                    {
                        root.ChildNodes[I].InnerText = Colorslider.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "enabled")
                    {
                        if (CaptureTimer.Enabled == true)
                        {
                            root.ChildNodes[I].InnerText = "true";
                        }
                        else
                        {
                            root.ChildNodes[I].InnerText = "false";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "minimized")
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            root.ChildNodes[I].InnerText = "true";
                        }
                        else
                        {
                            root.ChildNodes[I].InnerText = "false";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "mode")
                    {
                        if (GlobalVariables.mode == 0)
                        {
                            root.ChildNodes[I].InnerText = "movie";
                        }
                        else if (GlobalVariables.mode == 1)
                        {
                            root.ChildNodes[I].InnerText = "gaming";
                        }
                        else if (GlobalVariables.mode == 2)
                        {
                            root.ChildNodes[I].InnerText = "10*movie smooth";
                        }
                        else if (GlobalVariables.mode == 3)
                        {
                            root.ChildNodes[I].InnerText = "30*movie smooth";
                        }
                        else if (GlobalVariables.mode == 4)
                        {
                            root.ChildNodes[I].InnerText = "10*movie smooth+fast scene";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "fsr")
                    {
                        root.ChildNodes[I].InnerText = fsr.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "aggressivelevel")
                    {
                        root.ChildNodes[I].InnerText = AggressiveLevel.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "colorincsmooth")
                    {
                        root.ChildNodes[I].InnerText = ColorIncSmooth.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "smoothdarkness")
                    {
                        if (SmoothDarkness.Checked == true)
                        {
                            root.ChildNodes[I].InnerText = "true";
                        }
                        else
                        {
                            root.ChildNodes[I].InnerText = "false";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "expand")
                    {
                        if (radioButton1.Checked)
                            root.ChildNodes[I].InnerText = "1";
                        else if (radioButton2.Checked)
                            root.ChildNodes[I].InnerText = "2";
                        else
                            root.ChildNodes[I].InnerText = "3";
                    }
                    else if (root.ChildNodes[I].Name == "maxmultiply")
                    {
                        root.ChildNodes[I].InnerText = numericUpDown1.Value.ToString();
                    }
                    else if (root.ChildNodes[I].Name == "RedLeft")
                        root.ChildNodes[I].InnerText = RedLeft.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RedTop")
                        root.ChildNodes[I].InnerText = RedTop.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RedRight")
                        root.ChildNodes[I].InnerText = RedRight.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenLeft")
                        root.ChildNodes[I].InnerText = GreenLeft.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenTop")
                        root.ChildNodes[I].InnerText = GreenTop.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenRight")
                        root.ChildNodes[I].InnerText = GreenRight.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueLeft")
                        root.ChildNodes[I].InnerText = BlueLeft.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueTop")
                        root.ChildNodes[I].InnerText = BlueTop.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueRight")
                        root.ChildNodes[I].InnerText = BlueRight.Value.ToString();

                    else if (root.ChildNodes[I].Name == "RedLeftOnExit")
                        root.ChildNodes[I].InnerText = RedLeftOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RedTopOnExit")
                        root.ChildNodes[I].InnerText = RedTopOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RedRightOnExit")
                        root.ChildNodes[I].InnerText = RedRightOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenLeftOnExit")
                        root.ChildNodes[I].InnerText = GreenLeftOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenTopOnExit")
                        root.ChildNodes[I].InnerText = GreenTopOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "GreenRightOnExit")
                        root.ChildNodes[I].InnerText = GreenRightOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueLeftOnExit")
                        root.ChildNodes[I].InnerText = BlueLeftOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueTopOnExit")
                        root.ChildNodes[I].InnerText = BlueTopOnExit.Value.ToString();
                    else if (root.ChildNodes[I].Name == "BlueRightOnExit")
                        root.ChildNodes[I].InnerText = BlueRightOnExit.Value.ToString();

                    else if (root.ChildNodes[I].Name == "LeftScanBegin")
                        root.ChildNodes[I].InnerText = LeftBegin.Value.ToString();
                    else if (root.ChildNodes[I].Name == "LeftScanEnd")
                        root.ChildNodes[I].InnerText = LeftEnd.Value.ToString();
                    else if (root.ChildNodes[I].Name == "TopScanBegin")
                        root.ChildNodes[I].InnerText = TopBegin.Value.ToString();
                    else if (root.ChildNodes[I].Name == "TopScanEnd")
                        root.ChildNodes[I].InnerText = TopEnd.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RightScanBegin")
                        root.ChildNodes[I].InnerText = RightBegin.Value.ToString();
                    else if (root.ChildNodes[I].Name == "RightScanEnd")
                        root.ChildNodes[I].InnerText = RightEnd.Value.ToString();
                    else if (root.ChildNodes[I].Name == "Interval")
                        root.ChildNodes[I].InnerText = CaptureTimer.Interval.ToString();
                    else if (root.ChildNodes[I].Name == "Display")
                        root.ChildNodes[I].InnerText = DisplaysBox.Text.Remove(0, 8);
                    else if (root.ChildNodes[I].Name == "DivideLevel")
                        root.ChildNodes[I].InnerText = DivideLevel.Value.ToString();
                    else if (root.ChildNodes[I].Name == "OffsetLevel")
                        root.ChildNodes[I].InnerText = OffsetLevel.Value.ToString();
                    else if (root.ChildNodes[I].Name == "AutoEnable")
                    {
                        if (AutoEnable.Checked == true)
                        {
                            root.ChildNodes[I].InnerText = "true";
                        }
                        else
                        {
                            root.ChildNodes[I].InnerText = "false";
                        }
                    }
                    else if (root.ChildNodes[I].Name == "ProcessName")
                    {
                        root.ChildNodes[I].InnerText = ProcessName.Text;
                    }
                }
                settings.Save(Application.StartupPath + "\\settings.xml");

                SendOnExit();
            }
            else
            {
                e.Cancel = true;
                this.TopMost = true;
            }
        }

        private void Send() //send out the colors
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(GlobalVariables.SendByte, 0, 9);
            }
        }

        private bool OpenSerial()
        {
            try
            {
                txtPortname.Enabled = false;
                comboBaud.Enabled = false;
                serialPort1.PortName = txtPortname.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBaud.Text, 10);
                serialPort1.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Error opening com port", "Error");
                return false;
            }
        }

        private void SendOnExit()
        {
            Array.Clear(GlobalVariables.SendByte, 0, 9);

            GlobalVariables.SendByte[0] = (byte)((int)RedLeftOnExit.Value);
            GlobalVariables.SendByte[1] = (byte)((int)RedTopOnExit.Value);
            GlobalVariables.SendByte[2] = (byte)((int)RedRightOnExit.Value);

            GlobalVariables.SendByte[3] = (byte)((int)GreenLeftOnExit.Value);
            GlobalVariables.SendByte[4] = (byte)((int)GreenTopOnExit.Value);
            GlobalVariables.SendByte[5] = (byte)((int)GreenRightOnExit.Value);

            GlobalVariables.SendByte[6] = (byte)((int)BlueLeftOnExit.Value);
            GlobalVariables.SendByte[7] = (byte)((int)BlueTopOnExit.Value);
            GlobalVariables.SendByte[8] = (byte)((int)BlueRightOnExit.Value);

            Send(); //send the values

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(GlobalVariables.SendByte, 0, 9); //send 9 zero chars to turn off the lights

                while (serialPort1.BytesToWrite != 0)//wait for the serial port to finish sending
                {
                }
                serialPort1.Close();//close the serial port
            }
            serialPort1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableDisable()
        {
            if (CaptureTimer.Enabled)
            {
//                DWM.DwmEnableComposition(true);
                this.Text = "epiLight.NET DISABLED";
                EnableBtn.Text = "Enable";
                disableToolStripMenuItem.Text = "Enable";
                CaptureTimer.Enabled = false;
                Array.Clear(GlobalVariables.SendByte, 0, 9);
/*
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GlobalVariables.SendByte, 0, 9); //send 9 zero chars to turn off the lights
                    serialPort1.Close();
                }
 */
                txtPortname.Enabled = true;
                comboBaud.Enabled = true;
                SendOnExit();
            }
            else
            {
                //DWM.DwmEnableComposition(false);
                OpenSerial();
                Array.Clear(GlobalVariables.CurrentColor, 0, 9);
                EnableBtn.Text = "Disable";
                disableToolStripMenuItem.Text = "Disable";
                this.Text = "epiLight.NET";
                CaptureTimer.Enabled = true;
            }
        }

        private void EnableBtn_Click(object sender, EventArgs e)
        {
            EnableDisable();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }

        }

        private void ModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeCombo.Text == "Movie")
            {
                GlobalVariables.mode = 0;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo2.Text = "Movie";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo.Text == "Gaming")
            {
                GlobalVariables.mode = 1;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                ModeCombo2.Text = "Gaming";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo.Text == "10*Movie smooth")
            {
                GlobalVariables.mode = 2;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo2.Text = "10*Movie smooth";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo.Text == "30*Movie smooth")
            {
                GlobalVariables.mode = 3;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo2.Text = "30*Movie smooth";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo.Text == "10*Movie smooth+Fast scene")
            {
                GlobalVariables.mode = 4;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo2.Text = "10*Movie smooth+Fast scene";
                label31.Visible = true;
                fsr.Visible = true;
                SmoothDarkness.Visible = true;
                label38.Visible = true;
                AggressiveLevel.Visible = true;
                label46.Visible = true;
                ColorIncSmooth.Visible = true;
            }
        }

        private void ModeCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeCombo2.Text == "Movie")
            {
                GlobalVariables.mode = 0;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo.Text = "Movie";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo2.Text == "Gaming")
            {
                GlobalVariables.mode = 1;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                ModeCombo.Text = "Gaming";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo2.Text == "10*Movie smooth")
            {
                GlobalVariables.mode = 2;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo.Text = "10*Movie smooth";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo2.Text == "30*Movie smooth")
            {
                GlobalVariables.mode = 3;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo.Text = "30*Movie smooth";
                label31.Visible = false;
                fsr.Visible = false;
                SmoothDarkness.Visible = false;
                label38.Visible = false;
                AggressiveLevel.Visible = false;
                label46.Visible = false;
                ColorIncSmooth.Visible = false;
            }
            else if (ModeCombo2.Text == "10*Movie smooth+Fast scene")
            {
                GlobalVariables.mode = 4;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo.Text = "10*Movie smooth+Fast scene";
                label31.Visible = true;
                fsr.Visible = true;
                SmoothDarkness.Visible = true;
                label38.Visible = true;
                AggressiveLevel.Visible = true;
                label46.Visible = true;
                ColorIncSmooth.Visible = true;
            }
        }


        public static Bitmap CreateThumbnail(Bitmap loBMP, int lnWidth, int lnHeight)
        {

            Bitmap bmpOut = null;

            try
            {

//                Bitmap loBMP = new Bitmap(lcFilename);
                ImageFormat loFormat = loBMP.RawFormat;

                decimal lnRatio;

                int lnNewWidth = 0;
                int lnNewHeight = 0;

                //*** If the image is smaller than a thumbnail just return it
/*
                if (loBMP.Width < lnWidth && loBMP.Height < lnHeight)
                    return loBMP;
 */
                if (loBMP.Width > loBMP.Height)
                {
                    lnRatio = (decimal)lnWidth / loBMP.Width;
                    lnNewWidth = lnWidth;
                    decimal lnTemp = loBMP.Height * lnRatio;
                    lnNewHeight = (int)lnTemp;
                }
                else
                {
                    lnRatio = (decimal)lnHeight / loBMP.Height;
                    lnNewHeight = lnHeight;
                    decimal lnTemp = loBMP.Width * lnRatio;
                    lnNewWidth = (int)lnTemp;
                }
                bmpOut = new Bitmap(lnNewWidth, lnNewHeight);
                Graphics g = Graphics.FromImage(bmpOut);
//                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
//                g.InterpolationMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
//                g.FillRectangle(Brushes.White, 0, 0, lnNewWidth, lnNewHeight);
                g.DrawImage(loBMP, 0, 0, lnNewWidth, lnNewHeight);

                loBMP.Dispose();
            }
            catch
            {
                return null;
            }
            return bmpOut;
        }


        private void DeskCapture()
        {
            int redL = 0, greenL = 0, blueL = 0;
            int redR = 0, greenR = 0, blueR = 0;
            int redT = 0, greenT = 0, blueT = 0;
            int CounterL = 0, CounterR = 0, CounterT = 0;
            bool read = false;
            bool CaptureScreen = false;
            
            Color c = Color.Black;

            Screen MyScreen = Screen.AllScreens[GlobalVariables.SelectedDisplay];

            if ((CaptureEvery.Checked == false) || (CaptureEvery.Checked == true && CyclesInt == 0))
            {
                CaptureScreen = true;
            }

            if (CaptureEvery.Checked == true)
            {
                CyclesInt = CyclesInt + 1;
            }

            if (CaptureScreen == true)
            {
                b = new Bitmap(MyScreen.Bounds.Width, MyScreen.Bounds.Height);
                g = Graphics.FromImage(b);
                g.CopyFromScreen(MyScreen.Bounds.Left, MyScreen.Bounds.Top, 0, 0, new Size(MyScreen.Bounds.Width, MyScreen.Bounds.Height));
            }

            // b.Save("temp.jpg", ImageFormat.Jpeg);

            swidth = b.Width;
            sheight = b.Height;

            // b.Save("temp.jpg", ImageFormat.Jpeg);

            int divide = (int)DivideLevel.Value;
            GlobalVariables.Offset = (int)OffsetLevel.Value;
            if (GlobalVariables.mode == 1)
            {
                divide = 32;
                GlobalVariables.Offset = 0;
            }

            int dx = swidth / divide;
            int dy = sheight / divide;

            int offsetx = dx / 3 * GlobalVariables.Offset;
            int offsety = dy / 3 * GlobalVariables.Offset;

            if (this.WindowState != FormWindowState.Minimized)
            {
                label36.Text = MyScreen.Bounds.Width + "x" + MyScreen.Bounds.Height + " (" + MyScreen.Bounds.Left + ", " + MyScreen.Bounds.Top + ")";

                label60.Text = dx.ToString();
                label62.Text = dy.ToString();

                label66.Text = swidth.ToString();
                label69.Text = sheight.ToString();

                label64.Text = "~" + divide.ToString();
                label65.Text = "~" + divide.ToString();

                label74.Text = offsetx.ToString();
                label72.Text = offsety.ToString();
            }

            for (int PixelY = offsety; PixelY < sheight; PixelY += dy)
                {
                for (int PixelX = offsetx; PixelX < swidth; PixelX += swidth / divide)
                {

                    {
                        read = false;

                        if (PixelX >= swidth * LeftBegin.Value / 100 && PixelX <= swidth * LeftEnd.Value / 100)
                        {
                            if (read == false)
                            {
                                c = b.GetPixel(PixelX, PixelY);
                                read = true;
                            }
                            redL += c.R;
                            greenL += c.G;
                            blueL += c.B;
                            CounterL++;
                        }
                        if (PixelX >= swidth * RightBegin.Value / 100 && PixelX <= swidth * RightEnd.Value / 100)
                        {
                            if (read == false)
                            {
                                c = b.GetPixel(PixelX, PixelY);
                                read = true;
                            }
                            redR += c.R;
                            greenR += c.G;
                            blueR += c.B;
                            CounterR++;
                        }
                        if (PixelY >= sheight * TopBegin.Value / 100 && PixelY <= sheight * TopEnd.Value / 100)
                        {
                            if (read == false)
                            {
                                c = b.GetPixel(PixelX, PixelY);
                                read = true;
                            }
                            redT += c.R;
                            greenT += c.G;
                            blueT += c.B;
                            CounterT++;
                        }

                    }
                }
            }

            if (CounterL > 0)
            {
                redL /= CounterL;
                greenL /= CounterL;
                blueL /= CounterL;
            }
            if (CounterR > 0)
            {
                redR /= CounterR;
                greenR /= CounterR;
                blueR /= CounterR;
            }
            if (CounterT > 0)
            {
                redT /= CounterT;
                greenT /= CounterT;
                blueT /= CounterT;
            }
            if (redL > 0 || greenL > 0 || blueL > 0 || redR > 0 || greenR > 0 || blueR > 0 || redT > 0 || greenT > 0 || blueT > 0 || GlobalVariables.blackframe)
            {
                GlobalVariables.blackframe = false;
                Array.Copy(GlobalVariables.PreviousColor29, GlobalVariables.PreviousColor30, 9);
                Array.Copy(GlobalVariables.PreviousColor28, GlobalVariables.PreviousColor29, 9);
                Array.Copy(GlobalVariables.PreviousColor27, GlobalVariables.PreviousColor28, 9);
                Array.Copy(GlobalVariables.PreviousColor26, GlobalVariables.PreviousColor27, 9);
                Array.Copy(GlobalVariables.PreviousColor25, GlobalVariables.PreviousColor26, 9);
                Array.Copy(GlobalVariables.PreviousColor24, GlobalVariables.PreviousColor25, 9);
                Array.Copy(GlobalVariables.PreviousColor23, GlobalVariables.PreviousColor24, 9);
                Array.Copy(GlobalVariables.PreviousColor22, GlobalVariables.PreviousColor23, 9);
                Array.Copy(GlobalVariables.PreviousColor21, GlobalVariables.PreviousColor22, 9);
                Array.Copy(GlobalVariables.PreviousColor20, GlobalVariables.PreviousColor21, 9);
                Array.Copy(GlobalVariables.PreviousColor19, GlobalVariables.PreviousColor20, 9);
                Array.Copy(GlobalVariables.PreviousColor18, GlobalVariables.PreviousColor19, 9);
                Array.Copy(GlobalVariables.PreviousColor17, GlobalVariables.PreviousColor18, 9);
                Array.Copy(GlobalVariables.PreviousColor16, GlobalVariables.PreviousColor17, 9);
                Array.Copy(GlobalVariables.PreviousColor15, GlobalVariables.PreviousColor16, 9);
                Array.Copy(GlobalVariables.PreviousColor14, GlobalVariables.PreviousColor15, 9);
                Array.Copy(GlobalVariables.PreviousColor13, GlobalVariables.PreviousColor14, 9);
                Array.Copy(GlobalVariables.PreviousColor12, GlobalVariables.PreviousColor13, 9);
                Array.Copy(GlobalVariables.PreviousColor11, GlobalVariables.PreviousColor12, 9);
                Array.Copy(GlobalVariables.PreviousColor10, GlobalVariables.PreviousColor11, 9);
                Array.Copy(GlobalVariables.PreviousColor9, GlobalVariables.PreviousColor10, 9);
                Array.Copy(GlobalVariables.PreviousColor8, GlobalVariables.PreviousColor9, 9);
                Array.Copy(GlobalVariables.PreviousColor7, GlobalVariables.PreviousColor8, 9);
                Array.Copy(GlobalVariables.PreviousColor6, GlobalVariables.PreviousColor7, 9);
                Array.Copy(GlobalVariables.PreviousColor5, GlobalVariables.PreviousColor6, 9);
                Array.Copy(GlobalVariables.PreviousColor4, GlobalVariables.PreviousColor5, 9);
                Array.Copy(GlobalVariables.PreviousColor3, GlobalVariables.PreviousColor4, 9);
                Array.Copy(GlobalVariables.PreviousColor2, GlobalVariables.PreviousColor3, 9);
                Array.Copy(GlobalVariables.PreviousColor, GlobalVariables.PreviousColor2, 9);
                Array.Copy(GlobalVariables.CurrentColor, GlobalVariables.PreviousColor, 9);

                GlobalVariables.CurrentColor[0] = redL;
                GlobalVariables.CurrentColor[3] = greenL;
                GlobalVariables.CurrentColor[6] = blueL;
                GlobalVariables.CurrentColor[2] = redR;
                GlobalVariables.CurrentColor[5] = greenR;
                GlobalVariables.CurrentColor[8] = blueR;
                GlobalVariables.CurrentColor[1] = redT;
                GlobalVariables.CurrentColor[4] = greenT;
                GlobalVariables.CurrentColor[7] = blueT;

                
                //if (checkBox1.Checked)
                if (radioButton2.Checked)
                {
                    int[] Highest = new int[3] { 0, 0, 0 };
                    for (int I = 0; I < 9; I += 3)
                    {
                        if (Highest[0] < GlobalVariables.CurrentColor[I]) Highest[0] = GlobalVariables.CurrentColor[I];
                        if (Highest[1] < GlobalVariables.CurrentColor[I + 1]) Highest[1] = GlobalVariables.CurrentColor[I + 1];
                        if (Highest[2] < GlobalVariables.CurrentColor[I + 2]) Highest[2] = GlobalVariables.CurrentColor[I + 2];
                    }
                    float[] Multiply = new float[3];
                    for (int I = 0; I < 3; I++)
                    {
                        Multiply[I] = 255.0F / (float)Highest[I];
                        if (Multiply[I] > (float)numericUpDown1.Value) Multiply[I] = (float)numericUpDown1.Value;
                    }
                    for (int I = 0; I < 9; I += 3)
                    {
                        GlobalVariables.CurrentColor[I] = (int)((float)GlobalVariables.CurrentColor[I] * Multiply[0]);
                        GlobalVariables.CurrentColor[I + 1] = (int)((float)GlobalVariables.CurrentColor[I + 1] * Multiply[1]);
                        GlobalVariables.CurrentColor[I + 2] = (int)((float)GlobalVariables.CurrentColor[I + 2] * Multiply[2]);
                    }
                }
                
                
                
                if (radioButton3.Checked)
                {
                    int Highest = 0;
                    for (int I = 0; I < 9; I++)
                    {
                        if (Highest < GlobalVariables.CurrentColor[I])
                            Highest = GlobalVariables.CurrentColor[I];
                    }
                    float Multiply = 255.0F / (float)Highest;
                    if (Multiply > (float)numericUpDown1.Value)
                    {
                        Multiply = (float)numericUpDown1.Value;
                    }
                    for (int I = 0; I < 9; I++)
                    {
                        GlobalVariables.CurrentColor[I] = (int)((float)GlobalVariables.CurrentColor[I] * Multiply);
                    }
                }
                GlobalVariables.Offset++;
                if (GlobalVariables.Offset == 3)
                {
                    GlobalVariables.Offset = 0;
                }
            }
            else
            {
                GlobalVariables.blackframe = true;
            }

            if (CaptureScreen == true)
            {
            }

            if ((CyclesInt > CaptureCycles.Value) || (CaptureEvery.Checked == false))
            {
                CyclesInt = 0;
                g.Dispose();
                b.Dispose();
            }

        }

        private void TimerDelay_ValueChanged(object sender, EventArgs e)
        {
            CaptureTimer.Interval = (int)TimerDelay.Value;
        }

        private void EnumScreens()
        {
            Screen[] screens = Screen.AllScreens;
            int upperBound = screens.GetUpperBound(0);
            GlobalVariables.NrDisplays = upperBound;

            for (int I = 0; I <= upperBound; I++)
            {
                DisplaysBox.Items.Add("Display " + I.ToString());
            }
        }

        private void DisplaysBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariables.SelectedDisplay = Convert.ToInt32(DisplaysBox.Text.Remove(0, 8), 10);
        }

        private void RedTopOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorTopOnExit.BackColor = Color.FromArgb((int)RedTopOnExit.Value, (int)GreenTopOnExit.Value, (int)BlueTopOnExit.Value);
        }

        private void GreenTopOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorTopOnExit.BackColor = Color.FromArgb((int)RedTopOnExit.Value, (int)GreenTopOnExit.Value, (int)BlueTopOnExit.Value);
        }

        private void BlueTopOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorTopOnExit.BackColor = Color.FromArgb((int)RedTopOnExit.Value, (int)GreenTopOnExit.Value, (int)BlueTopOnExit.Value);
        }

        private void RedLeftOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorLeftOnExit.BackColor = Color.FromArgb((int)RedLeftOnExit.Value, (int)GreenLeftOnExit.Value, (int)BlueLeftOnExit.Value);
        }

        private void GreenLeftOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorLeftOnExit.BackColor = Color.FromArgb((int)RedLeftOnExit.Value, (int)GreenLeftOnExit.Value, (int)BlueLeftOnExit.Value);
        }

        private void BlueLeftOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorLeftOnExit.BackColor = Color.FromArgb((int)RedLeftOnExit.Value, (int)GreenLeftOnExit.Value, (int)BlueLeftOnExit.Value);
        }

        private void RedRightOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorRightOnExit.BackColor = Color.FromArgb((int)RedRightOnExit.Value, (int)GreenRightOnExit.Value, (int)BlueRightOnExit.Value);
        }

        private void GreenRightOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorRightOnExit.BackColor = Color.FromArgb((int)RedRightOnExit.Value, (int)GreenRightOnExit.Value, (int)BlueRightOnExit.Value);
        }

        private void BlueRightOnExit_ValueChanged(object sender, EventArgs e)
        {
            ColorRightOnExit.BackColor = Color.FromArgb((int)RedRightOnExit.Value, (int)GreenRightOnExit.Value, (int)BlueRightOnExit.Value);
        }

        private void AutoDetect_Tick(object sender, EventArgs e)
        {
            bool foundit = false;
            Process[] prs = Process.GetProcesses();
            foreach (Process proces in prs)
            {
                if (proces.ProcessName == ProcessName.Text)
                {
                    foundit = true;
                }
            }

            if (foundit == true)
            {
                if (CaptureTimer.Enabled == false && AutoEnable.Checked)
                {
                    DWM.DwmEnableComposition(false);
                    EnableDisable();
                }

            }
            else
            {
                if (CaptureTimer.Enabled == true && AutoEnable.Checked)
                {
                    DWM.DwmEnableComposition(true);
                    EnableDisable();
                }
            }


        }

        private void AutoEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoEnable.Checked)
            {
                EnableBtn.Enabled = false;
            }
            else
            {
                EnableBtn.Enabled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


    }
}