using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


namespace BobLight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
                else if (root.ChildNodes[I].Name == "color")
                {
                    Colorslider.Value = Convert.ToInt32(root.ChildNodes[I].InnerText, 10);
                }
                else if (root.ChildNodes[I].Name == "enabled")
                {
                    if (root.ChildNodes[I].InnerText == "true")
                    {
                        OpenSerial();
                        CaptureTimer.Enabled = true;
                        this.Text = "BobLight";
                        EnableBtn.Text = "Disable";
                        disableToolStripMenuItem.Text = "Disable";

                    }
                    else
                    {
                        CaptureTimer.Enabled = false;
                        this.Text = "BobLight DISABLED";
                        EnableBtn.Text = "Enable";
                        disableToolStripMenuItem.Text = "Enable";
                    }
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
                        ModeCombo.Text = "Movie mode";
                        ModeCombo2.Text = "Movie mode";
                    }
                    else if (root.ChildNodes[I].InnerText == "gaming")
                    {
                        GlobalVariables.mode = 1;
                        ModeCombo.Text = "Gaming mode";
                        ModeCombo2.Text = "Gaming mode";
                        System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
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
            }
            
            //Colorlabel.Text = "Color: " + Colorslider.Value.ToString();

            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            //GlobalVariables.DeskDC = User32.GetDC(0);
            //GlobalVariables.DeskHandle = User32.GetDesktopWindow();
            //GlobalVariables.DeskDC = User32.GetDCEx(GlobalVariables.DeskHandle, 0, 0);
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

            //This was added later, so it looks ugly :P



            bool send = false;

            for (int I = 0; I < 9; I++)
            {
                if (GlobalVariables.SendByte[I] != GlobalVariables.OldSendByte[I])
                {
                    send = true;
                }
            }
            //if (true)
            if (send)
            {


                if (this.WindowState != FormWindowState.Minimized) //Show the average colors on screen
                {
                    ColorLeft.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[0], (int)GlobalVariables.SendByte[3], (int)GlobalVariables.SendByte[6]);
                    ColorTop.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[1], (int)GlobalVariables.SendByte[4], (int)GlobalVariables.SendByte[7]);
                    ColorRight.BackColor = Color.FromArgb((int)GlobalVariables.SendByte[2], (int)GlobalVariables.SendByte[5], (int)GlobalVariables.SendByte[8]);
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
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "BobLight", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    close = true;
                }
            }
            else
            {
                close = true;
            }
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
                }
                settings.Save(Application.StartupPath + "\\settings.xml");

                Array.Clear(GlobalVariables.SendByte, 0, 9);
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
                this.Text = "BobLight DISABLED";
                EnableBtn.Text = "Enable";
                disableToolStripMenuItem.Text = "Enable";
                CaptureTimer.Enabled = false;
                Array.Clear(GlobalVariables.SendByte, 0, 9);
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(GlobalVariables.SendByte, 0, 9); //send 9 zero chars to turn off the lights
                    serialPort1.Close();
                }
                txtPortname.Enabled = true;
                comboBaud.Enabled = true;
            }
            else
            {
                OpenSerial();
                Array.Clear(GlobalVariables.CurrentColor, 0, 9);
                EnableBtn.Text = "Disable";
                disableToolStripMenuItem.Text = "Disable";
                this.Text = "BobLight";
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
            if (ModeCombo.Text == "Movie mode")
            {
                GlobalVariables.mode = 0;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo2.Text = "Movie mode";
            }
            else if (ModeCombo.Text == "Gaming mode")
            {
                GlobalVariables.mode = 1;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                ModeCombo2.Text = "Gaming mode";
            }
        }

        private void ModeCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeCombo2.Text == "Movie mode")
            {
                GlobalVariables.mode = 0;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
                ModeCombo.Text = "Movie mode";
            }
            else if (ModeCombo2.Text == "Gaming mode")
            {
                GlobalVariables.mode = 1;
                System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
                ModeCombo.Text = "Gaming mode";
            }
        }
        private void DeskCapture()
        {
            GlobalVariables.DeskDC = User32.GetDC(0);
            int redL = 0, greenL = 0, blueL = 0;
            int redR = 0, greenR = 0, blueR = 0;
            int redT = 0, greenT = 0, blueT = 0;
            int CounterL = 0, CounterR = 0, CounterT = 0;
            uint temp;
            
            //Screen MyScreen = Screen.PrimaryScreen;
            Screen MyScreen = Screen.AllScreens[GlobalVariables.SelectedDisplay];
            //label2.Text = "X: " + MyScreen.Bounds.Left.ToString() + "Y: " + MyScreen.Bounds.Top.ToString();
            //ComPort.Text = "X: " + MyScreen.Bounds.Width.ToString() + "Y: " + MyScreen.Bounds.Height.ToString();
            //ResLabel.Text = X.ToString() + " * " + Y.ToString();
            int divide = 16;
            if (GlobalVariables.mode == 1)
            {
                divide = 32;
                GlobalVariables.Offset = 0;
            }
            for (int PixelY = MyScreen.Bounds.Height / divide / 3 * GlobalVariables.Offset; PixelY < MyScreen.Bounds.Height; PixelY += MyScreen.Bounds.Height / divide)
            {
                for (int PixelX = MyScreen.Bounds.Width / divide / 3 * GlobalVariables.Offset; PixelX < MyScreen.Bounds.Width; PixelX += MyScreen.Bounds.Width / divide)
                {

                    temp = GDI32.GetPixel(GlobalVariables.DeskDC, PixelX + MyScreen.Bounds.Left, PixelY + MyScreen.Bounds.Top);
                    //if (PixelX < X / 2 && temp != 0)
                    if ((temp & 0xFF000000) != 0)
                    {
                        //textBox1.Text = textBox1.Text + temp.ToString() + "\r\n";
                    }
                    //if (temp != 0xFFFFFFFF)
                    //if (temp != 0)
                    {
                        if (PixelX >= MyScreen.Bounds.Width * LeftBegin.Value / 100 && PixelX <= MyScreen.Bounds.Width * LeftEnd.Value / 100)
                        {
                            redL += (int)(temp & 0x000000FF);
                            greenL += (int)(temp & 0x0000FF00) >> 8;
                            blueL += (int)(temp & 0x00FF0000) >> 16;
                            CounterL++;
                        }
                        if (PixelX >= MyScreen.Bounds.Width * RightBegin.Value / 100 && PixelX <= MyScreen.Bounds.Width * RightEnd.Value / 100)
                        {
                            redR += (int)(temp & 0x000000FF);
                            greenR += (int)(temp & 0x0000FF00) >> 8;
                            blueR += (int)(temp & 0x00FF0000) >> 16;
                            CounterR++;
                        }
                        if (PixelY >= MyScreen.Bounds.Height * TopBegin.Value / 100 && PixelY <= MyScreen.Bounds.Height * TopEnd.Value / 100)
                        {
                            redT += (int)(temp & 0x000000FF);
                            greenT += (int)(temp & 0x0000FF00) >> 8;
                            blueT += (int)(temp & 0x00FF0000) >> 16;
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
            User32.ReleaseDC(GlobalVariables.DeskHandle, GlobalVariables.DeskDC);    
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
    }
}