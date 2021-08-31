using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NineTime
{
    public partial class NTC_stopwatch : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;
        public NTC_stopwatch()
        {
            InitializeComponent();
        }
        private void IncreaseSecond()
        {
            if(seconds > 59)
            {
                seconds = 0;
                IncreaseMinute();
            }
            else
            {
                seconds++;
            }
        }
        private void IncreaseMinute()
        {
            if(minutes > 59)
            {
                minutes = 0;
                IncreaseHour();
            }
            else
            {
                minutes++;
            }
        }
        private void IncreaseHour()
        {
            hours++;
        }

        public void StopWatch_Tick(object sender, EventArgs e)
        {
            ShowTime();
            IncreaseSecond();
        }

        private void uiBtn_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += StopWatch_Tick;
        }

        private void uiBtn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void uiBtn_Reset_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            ShowTime();
        }

        private void ShowTime()
        {
            ui_b_Hour.Text = hours.ToString("00");
            ui_b_Minute.Text = minutes.ToString("00");
            ui_b_Second.Text = seconds.ToString("00");
        }

        private void NTC_stopwatch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
