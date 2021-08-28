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

namespace NineTime
{
    public partial class Form1 : Form
    {
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
    }
}
