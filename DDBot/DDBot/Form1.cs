using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DDBot
{
    public partial class Form1 : Form
    {   
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint cInputs, INPUT input, int size);

        Stopwatch stopky = new System.Diagnostics.Stopwatch();
        byte[,] barvy = new byte[14, 13];
        int delay = 0;
        double n = 0;
        bool finding = false;
        const int VelCt = 40;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        public Form1()
        {
            InitializeComponent();
            Stop.Visible = false;
            timer1.Interval = (int)TimVal.Value;
            timer3.Interval = (int)TimVal.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            lHint.Text = "click on coor x/y to get plaing table to the center";
        }

        public static void ClickSomePoint()
        {
            // Set the cursor position
            System.Windows.Forms.Cursor.Position = new Point(20, 35);

            DoClickMouse(0x2); // Left mouse button down
            DoClickMouse(0x4); // Left mouse button up
        }

        static void DoClickMouse(int mouseButton)
        {
            var input = new INPUT()
            {
                dwType = 0, // Mouse input
                mi = new MOUSEINPUT() { dwFlags = mouseButton }
            };
            /*
            if (SendInput(1, input, Marshal.SizeOf(input)) == 0)
            {
                throw new Exception();
            }*/
        }
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            int dx;
            int dy;
            int mouseData;
            public int dwFlags;
            int time;
            IntPtr dwExtraInfo;
        }
        struct INPUT
        {
            public uint dwType;
            public MOUSEINPUT mi;
        }
        



        public void click(int x, int y)
        {
            if (CBklik.Checked)
            {
                int mx = Cursor.Position.X;
                int my = Cursor.Position.Y;
                Cursor.Position = new Point(x,y);
                //mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x * 65535 / 1920, y * 65535 / 1080, 0, 0);
                System.Threading.Thread.SpinWait(delay / 2);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x * 65535 / 1920, y * 65535 / 1080, 0, 0);
                System.Threading.Thread.SpinWait(delay / 2);
                Cursor.Position = new Point(mx, my);
                //mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, (mx + 1) * 65535 / 1920, (my + 1) * 65535 / 1080, 0, 0);
            }
        }

        public void DelGem(int x, int y, int barva)
        {
            n++;
            barvy[x, y] = 10;
            if (barva != 0 && barva != 10)
            {
                if (barvy[x + 1, y] == barva)
                {
                    barvy[x + 1, y] = 10;
                    DelGem(x + 1, y, barva);
                }
                if (barvy[x, y + 1] == barva)
                {
                    barvy[x, y + 1] = 10;
                    DelGem(x, y + 1, barva);
                }
                if (barvy[x - 1, y] == barva)
                {
                    barvy[x - 1, y] = 10;
                    DelGem(x - 1, y, barva);
                }
                if (barvy[x, y - 1] == barva)
                {
                    barvy[x, y - 1] = 10;
                    DelGem(x, y - 1, barva);
                }
            }
        }
        
        public void update()
        {
            finding = true;
            int nX, nY;
            byte green;
            Bitmap bmpScreenshot;
            Bitmap obrazek;
            Graphics gfxScreenshot;            
            nX = 0; nY = 0;                              
            bmpScreenshot = new Bitmap(402, 362, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen((int)NudX.Value + 20, (int)NudY.Value + 19, 0, 0, new Size(402, 362), CopyPixelOperation.SourceCopy);

            PbCap.Image = bmpScreenshot;

            obrazek = new Bitmap(VelCt*10, VelCt*9);
            bitmapa.Height = VelCt * 9;
            bitmapa.Width = VelCt * 10;
            bitmapa.Image = obrazek;
            Graphics g = Graphics.FromImage(obrazek);

            for (int i = 0; i <= 11; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    barvy[i, j] = 0;
                }
            }
            for (int x = 18; x <= 378; x += 40)
            {
                nY = 0;
                for (int y = 20; y <= 340; y += 40)
                {
                    obrazek.SetPixel(nX, nY, bmpScreenshot.GetPixel(x, y));
                    green = bmpScreenshot.GetPixel(x, y).G;

                    if (green > 85 && green < 95)  //red
                    {
                        g.FillRectangle(Brushes.Red, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 1;
                    }
                    else if (green > 110 && green < 120)  //blue
                    {
                        g.FillRectangle(Brushes.Blue, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 2;
                    }
                    else if (green > 225 && green < 252)  //green
                    {
                        g.FillRectangle(Brushes.Green, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 3;
                    }
                    else if (green > 220 && green < 226)  //yellow
                    {
                        g.FillRectangle(Brushes.Yellow, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 4;
                    }
                    else if (green > 40 && green < 55)  //violet
                    {
                        g.FillRectangle(Brushes.Violet, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 5;
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, VelCt * nX, VelCt * nY, VelCt, VelCt);
                        barvy[nX + 1, nY + 1] = 0;
                    }
                    nY++;
                }
                nX++;
            }
            bitmapa.Image = obrazek;
            for (int x = 1; x <= 11; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    if (barvy[x, y] != 0 && barvy[x, y] != 10)
                    {
                        if (barvy[x, y] == barvy[x + 1, y] && barvy[x, y] == barvy[x, y + 1])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                        if (barvy[x, y] == barvy[x - 1, y] && barvy[x, y] == barvy[x, y + 1])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                        if (barvy[x, y] == barvy[x - 1, y] && barvy[x, y] == barvy[x, y - 1])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                        if (barvy[x, y] == barvy[x + 1, y] && barvy[x, y] == barvy[x, y - 1])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                        if (barvy[x, y] == barvy[x - 1, y] && barvy[x, y] == barvy[x + 1, y])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                        if (barvy[x, y] == barvy[x, y - 1] && barvy[x, y] == barvy[x, y + 1])
                        {
                            DelGem(x, y, barvy[x, y]);
                            click(x * 40 + (int)NudX.Value + 10, y * 40 + (int)NudY.Value + 10);
                        }
                    }
                }
            }
            for (int x = 0; x != 10; x++)
            {
                for (int y = 0; y != 9; y++)
                {
                    switch (barvy[x + 1, y + 1])
                    {
                        case 0: g.FillRectangle(Brushes.Black, VelCt * x, VelCt * y, VelCt, VelCt);     break;
                        case 1: g.FillRectangle(Brushes.Red, VelCt * x, VelCt * y, VelCt, VelCt);       break;
                        case 2: g.FillRectangle(Brushes.Blue, VelCt * x, VelCt * y, VelCt, VelCt);      break;
                        case 3: g.FillRectangle(Brushes.Green, VelCt * x, VelCt * y, VelCt, VelCt);     break;
                        case 4: g.FillRectangle(Brushes.Yellow, VelCt * x, VelCt * y, VelCt, VelCt);    break;
                        case 5: g.FillRectangle(Brushes.Violet, VelCt * x, VelCt * y, VelCt, VelCt);    break;
                        case 10: g.FillRectangle(Brushes.Cyan, VelCt * x, VelCt * y, VelCt, VelCt);     break;
                    }
                }
            }
            finding = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!finding)
            {
                stopky.Reset();
                stopky.Start();
                update();
                stopky.Stop();
                if ((int)stopky.ElapsedMilliseconds > TimVal.Value)
                    TimVal.BackColor = Color.Red;
                else
                    TimVal.BackColor = Color.White;
                LTime.Text = (((int)stopky.ElapsedMilliseconds).ToString() + "ms");
            }
        }

        private void CoorX_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Text = "Plaing";
            Stop.Visible = true;
            LTime.Visible = true;
            lHint.Text = "watch... , if game end click on the stop button";
            timer2.Start();
            timer1.Start();
            timer3.Stop();
            config(false);
            bEnConf.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            config(false);
            bEnConf.Enabled = true;
            stopky.Stop();
            LTime.Visible = false;
            Stop.Visible = false;
            Start.Text = "WTF ??";
            lHint.Text = "play again";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            Start.Text = "Start";
        }

        private void ClickerVal_ValueChanged(object sender, EventArgs e)
        {
            delay = (int)ClickVal.Value;
        }

        private void TimVal_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)TimVal.Value;
            timer3.Interval = (int)TimVal.Value;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Start.Text = "hotovo";
            Stop.Visible = false;
            Start.Update();
            timer1.Stop();
            timer2.Stop();
            config(false);
            bEnConf.Enabled = true;
            lHint.Text = "play again";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            Start.Text = "start";
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            stopky.Reset();
            stopky.Start();
            Bitmap bmpScreenshot;
            Graphics gfxScreenshot;
            bmpScreenshot = new Bitmap(402, 362, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen((int)NudX.Value + 20, (int)NudY.Value + 19, 0, 0, new Size(402, 362), CopyPixelOperation.SourceCopy);
            PbCap.Image = bmpScreenshot;
            stopky.Stop();
            if ((int)stopky.ElapsedMilliseconds > TimVal.Value)
                TimVal.BackColor = Color.Red;
            else
                TimVal.BackColor = Color.White;
            LTime.Text = (((int)stopky.ElapsedMilliseconds).ToString() + "ms");
        }

        public void config(bool stav)
        {
            if (stav)
            {
                timer3.Start();
                bEnConf.Text = "Stop configuration";
            }
            else
            {
                PbCap.Image = new Bitmap(402, 362, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                timer3.Stop();
                bEnConf.Text = "Start configuration";
            }
        }

        private void bEnConf_Click(object sender, EventArgs e)
        {
            if (!timer3.Enabled)
            {
                config(true);
            }
            else
            {
                config(false);
            }
            
        }
    }

    sealed class Win32
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        static public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }
}