using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Runtime.InteropServices;

namespace NineTime
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;

            label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.URL = "asset/Music/KissTheSky.mp3";
            Player.controls.play();
            //====Rounded PictureBox Settings==============
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Region rg = new Region(gp);
            //픽쳐박스1 gif
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void rounded_Button1_Click(object sender, EventArgs e)
        {
            NTInfo NTI = new NTInfo();
            NTI.Show();
        }

        private void rounded_Button2_Click(object sender, EventArgs e)
        {
            NTchoClock NTC = new NTchoClock();
            NTC.Show();
        }

        private void rounded_Button3_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            MusicSelect MSC = new MusicSelect();
            MSC.Show();
        }
    }
}
